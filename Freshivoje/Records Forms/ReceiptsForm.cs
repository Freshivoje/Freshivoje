using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Freshivoje.Records_Forms
{
    public partial class ReceiptsForm : Form
    {
        private int _selectedReceiptId;
        private string _selectedReceiptStatus, _selectedReceiptDate;
        private decimal _selectedReceiptPricePaid, _selectedReceiptTotalPrice;
        private readonly string _fillDGVQuery = @"SELECT
                                                `receipts`.`id_receipt`,
                                                CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`,' (', `clients`.`JMBG`, ')') as client,
												`receipts`.`receipt_status`,
                                                `receipts`.`price_paid`,
                                                `receipts`.`total_price`,
                                                DATE_FORMAT(`receipts`.`date`, '%d.%m.%Y.') as `date`
                                                FROM `receipts`
                                                JOIN `clients` ON `clients`.`id_client` = `receipts`.`fk_client_id`
                                                ORDER BY date DESC";
        public ReceiptsForm()
        {
            InitializeComponent();
            receiptsDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(receiptsDataGridView, _fillDGVQuery);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void searchTxtBox_TextChanged(object sender, System.EventArgs e)
        {
            string searchValue = searchTxtBox.Text;
            (receiptsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`date`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `client` LIKE '%{searchValue}%'
                                                                                    OR `receipt_status` LIKE '%{searchValue}%'";
        }

        private void receiptsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 7)
            {
                _selectedReceiptId = Convert.ToInt32(receiptsDataGridView.Rows[e.RowIndex].Cells["receiptId"].Value);
                _selectedReceiptStatus = receiptsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
                _selectedReceiptPricePaid = Convert.ToDecimal(receiptsDataGridView.Rows[e.RowIndex].Cells["pricePaid"].Value);
                _selectedReceiptTotalPrice = Convert.ToDecimal(receiptsDataGridView.Rows[e.RowIndex].Cells["totalPrice"].Value);
                _selectedReceiptDate = Convert.ToDateTime(receiptsDataGridView.Rows[e.RowIndex].Cells["date"].Value).ToString("dd.MM.yyyy.");

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = @"SELECT
                                    CONCAT_WS(' / ', `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`) as article, 
                                    `items_receipt`.`quantity`,
                                    `items_receipt`.`price`
                                    FROM `items_receipt`
                                    JOIN `articles` ON `items_receipt`.`fk_article_id` = `articles`.`id_article`
                                    JOIN `receipts` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt`
                                    WHERE `receipts`.`id_receipt` = @receiptId"
                };
                mySqlCommand.Parameters.AddWithValue("@receiptId", _selectedReceiptId);

                string details = DbConnection.getReceiptDetails(mySqlCommand);

                string message = $"{details}\nDatum: {_selectedReceiptDate}\nStatus: {_selectedReceiptStatus}\nUkupna cena: {_selectedReceiptTotalPrice} RSD\nIsplaćeno: {_selectedReceiptPricePaid} RSD";

                CustomMessageBox.ShowDialog(this, message);
                return;
            }

            if (e.ColumnIndex == 8)
            {
                _selectedReceiptStatus = receiptsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
                _selectedReceiptPricePaid = Convert.ToDecimal(receiptsDataGridView.Rows[e.RowIndex].Cells["pricePaid"].Value);
                _selectedReceiptTotalPrice = Convert.ToDecimal(receiptsDataGridView.Rows[e.RowIndex].Cells["totalPrice"].Value);

                if (_selectedReceiptPricePaid == _selectedReceiptTotalPrice)
                {
                    CustomMessageBox.ShowDialog(this, "Ovaj nalog je isplaćen!");
                    return;
                }
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li želite da isplatite klijenta?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }

                _selectedReceiptId = Convert.ToInt32(receiptsDataGridView.Rows[e.RowIndex].Cells["receiptId"].Value);
              

                CustomTextBoxDialog.ShowDialog(this, $"Klijentu dugujete {_selectedReceiptTotalPrice - _selectedReceiptPricePaid} RSD.\nKoliko sada isplaćujete?");
                decimal pay = Convert.ToDecimal(CustomTextBoxDialog._value) + _selectedReceiptPricePaid;
                if (pay > _selectedReceiptTotalPrice)
                {
                    CustomMessageBox.ShowDialog(this, "Trenutna isplata premašuje sumu koju dugujete klijentu.\nMolimo pokušajte ponovo!");
                    return;
                }

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `receipts` SET `receipt_status` = 'plaćeno', `price_paid` = @pricePaid WHERE `id_receipt` = @id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _selectedReceiptId);
                mySqlCommand.Parameters.AddWithValue("@pricePaid", pay);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(receiptsDataGridView, _fillDGVQuery);
            }
        }
    }
}
