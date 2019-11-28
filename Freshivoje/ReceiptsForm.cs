using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Freshivoje
{
    public partial class ReceiptsForm : Form
    {
        private int _selectedReceiptId;
        private string _selectedReceiptStatus, _selectedReceiptDate;
        private decimal _selectedReceiptTotalPrice;
        private readonly string _fillDGVQuery = @"SELECT
                                                `receipts`.`id_receipt`,
                                                CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`,' (', `clients`.`JMBG`, ')') as client,
												`receipts`.`receipt_status`,
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

            if (e.ColumnIndex == 6)
            {
                _selectedReceiptId = Convert.ToInt32(receiptsDataGridView.Rows[e.RowIndex].Cells["receiptId"].Value);
                _selectedReceiptStatus = receiptsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
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

                string message = $"{details}\nDatum: {_selectedReceiptDate}\nStatus: {_selectedReceiptStatus}\nUkupna cena: {_selectedReceiptTotalPrice} RSD";

                CustomMessageBox.ShowDialog(this, message);
                return;
            }

            if (e.ColumnIndex == 7)
            {
                _selectedReceiptStatus = receiptsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();

                if (_selectedReceiptStatus == "plaćeno")
                {
                    CustomMessageBox.ShowDialog(this, "Plaćeno!");
                    return;
                }
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da ste platili OVO?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }

                _selectedReceiptId = Convert.ToInt32(receiptsDataGridView.Rows[e.RowIndex].Cells["receiptId"].Value);


                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `receipts` SET `receipt_status` = 'plaćeno' WHERE `id_receipt` = @id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _selectedReceiptId);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(receiptsDataGridView, _fillDGVQuery);
            }
        }
    }
}
