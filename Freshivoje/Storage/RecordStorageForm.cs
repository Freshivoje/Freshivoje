using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshivoje.Storage
{
    public partial class RecordStorageForm : Form
    {
        int _storageId;
        string searchValue;
        public RecordStorageForm(int storageId)
        {
            _storageId = storageId;
            InitializeComponent();
            _storageId = storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            WindowState = FormWindowState.Maximized;
            RecordsDataGridView.AutoGenerateColumns = false;
           
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            lblTitle.Text = "EVIDENCIJA KOMORE " + storageData.getName();
            if (_storageId == 8)
            {
                string query = "SELECT * FROM `pallete_positioning` INNER JOIN `pallete` ON `pallete_positioning`.`fk_pallete_id` = `pallete`.`id_pallete` WHERE pallete_positioning.sell = 'aktivna' AND `pallete_positioning`.`status`='aktivna' AND `pallete_positioning`.`fk_storage_id`=" + _storageId;
                DbConnection.fillDGV(RecordsDataGridView, query);
            }
            else
            {
                string query = "SELECT * FROM `pallete_positioning` INNER JOIN `pallete` ON `pallete_positioning`.`fk_pallete_id` = `pallete`.`id_pallete` WHERE `pallete_positioning`.`status`='aktivna' AND `pallete_positioning`.`fk_storage_id`=" + _storageId;
                DbConnection.fillDGV(RecordsDataGridView, query);
            }

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
        public void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void onlyNumerics(object sender, KeyPressEventArgs e)
        {
            // Limit input to numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // 2 decimals limit
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void packagesRecordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            
        }

        private void searchRecordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void searchRecordTxtBox_TextChanged(object sender, EventArgs e)
        {
                searchValue = searchRecordTxtBox.Text.Replace('\'', (char)0x2019); // &rsquo; 
            (RecordsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`pallet_number` LIKE '%{searchValue}%' OR `classification` LIKE '%{searchValue}%' OR `pallete_positioning_date` LIKE '%{searchValue}%'"; 
        }

        private void insertPalleteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 4) {

                int _id_pallete = Convert.ToInt32(RecordsDataGridView.Rows[e.RowIndex].Cells["id_pallet"].Value);

                string query2 = @$"SELECT receipts.fk_client_id, clients.first_name, clients.last_name, items_receipt.fk_receipt_id, items_receipt.fk_article_id, items_receipt.id_items_receipt, items_receipt.quantity, items_receipt.status, articles.article_name, articles.sort, articles.organic, articles.category, item_pallete.fk_id_item_recepit, item_pallete.fk_id_pallete, pallete.pallet_number, pallete.id_pallete FROM receipts INNER JOIN clients ON receipts.fk_client_id = clients.id_client INNER JOIN items_receipt ON items_receipt.fk_receipt_id = receipts.id_receipt INNER JOIN articles ON articles.id_article = items_receipt.fk_article_id INNER JOIN item_pallete ON items_receipt.id_items_receipt = item_pallete.fk_id_item_recepit INNER JOIN pallete ON pallete.id_pallete = item_pallete.fk_id_pallete WHERE pallete.id_pallete = '{_id_pallete}'";

                CustomMessageBox.ShowDialog(this, "Na ovoj paleti se nalazi : \n\t" + DbConnection.fillCustom(query2, "first_name", "last_name", "article_name", "sort", "organic", "category", "quantity"));
                return;
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
