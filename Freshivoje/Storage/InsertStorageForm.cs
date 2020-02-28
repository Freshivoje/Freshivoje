using Freshivoje.Custom_Forms;
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
using Freshivoje.Models;

namespace Freshivoje.Storage
{
    public partial class InsertStorageForm : Form
    {
        int storageId;
        private object storageData;
        public List<Pallete> palletes = new List<Pallete>();

        public InsertStorageForm(int _storageId)
        {
            InitializeComponent();
            storageId = _storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            if(storageId == 9)
            {
                string query1 = "SELECT * FROM `pallete` WHERE pallete.status = 'aktivna'";
                DbConnection.FillCmbBoxQuery(palleteCmbBox, query1, "id_pallete", "pallet_number");
            }
            else
            {
                string query1 = "SELECT * FROM `pallete_positioning` INNER JOIN `pallete` ON `pallete_positioning`.`fk_pallete_id` = `pallete`.`id_pallete` WHERE `pallete_positioning`.`fk_storage_id`=9;";
                DbConnection.FillCmbBoxQuery(palleteCmbBox, query1, "id_pallete", "pallet_number");
            }
          
            insertPalleteDataGridView.AutoGenerateColumns = false;
            lblTitle.Text = "ULAZ PALETA U KOMORU " + storageData.getName();
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


        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (palleteCmbBox.SelectedIndex == 0)
            {
                CustomMessageBox.ShowDialog(this, "Niste izabrali paletu za unos.");
                return;
            }

            int _palletId = (palleteCmbBox.SelectedItem as ComboBoxItem).Value;
            int _palletNumber = Convert.ToInt32(palleteCmbBox.Text);

            foreach(DataGridViewRow row in insertPalleteDataGridView.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id_pallet"].Value);
                if(_palletId == id)
                {
                    CustomMessageBox.ShowDialog(this, "Već ste izabrali paletu sa ovim paletnim brojem.");
                    return;
                }
            }
            Pallete _pallete = new Pallete(_palletId, _palletNumber);
            insertPalleteDataGridView.Rows.Add(_pallete._id, _pallete._number);
            palleteCmbBox.SelectedIndex = 0;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da ste završili sa ubacivanjem artikala u komoru ?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            foreach (DataGridViewRow row in insertPalleteDataGridView.Rows)
            {
                int idPallete = Convert.ToInt32(row.Cells["id_pallet"].Value);
                int numberPallete = Convert.ToInt32(row.Cells["pallet_number"].Value);

                Pallete item = new Pallete(idPallete, numberPallete);
                palletes.Add(item);
            }
            DbConnection.palleting(palletes, storageId, true);
            Close();
        }


     
        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da ne ubacite ovu paletu ?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DataGridViewRow _selectedRow = insertPalleteDataGridView.CurrentRow;
                insertPalleteDataGridView.Rows.Remove(_selectedRow);
            }
            if(e.ColumnIndex == 2)
            {
                int _id_pallete = Convert.ToInt32(insertPalleteDataGridView.Rows[e.RowIndex].Cells["id_pallet"].Value);

                string query2 = @$"SELECT receipts.fk_client_id, clients.first_name, clients.last_name, items_receipt.fk_receipt_id, items_receipt.fk_article_id, items_receipt.id_items_receipt, items_receipt.quantity, items_receipt.status, articles.article_name, articles.sort, articles.organic, articles.category,  item_pallete.fk_id_item_recepit, item_pallete.fk_id_pallete, pallete.pallet_number FROM receipts INNER JOIN clients ON receipts.fk_client_id = clients.id_client INNER JOIN items_receipt ON items_receipt.fk_receipt_id = receipts.id_receipt INNER JOIN articles ON articles.id_article = items_receipt.fk_article_id INNER JOIN item_pallete ON items_receipt.id_items_receipt = item_pallete.fk_id_item_recepit INNER JOIN pallete ON pallete.id_pallete = item_pallete.fk_id_pallete WHERE pallete.id_pallete = '{_id_pallete}'";

                CustomMessageBox.ShowDialog(this, "Na ovoj paleti se nalazi : \n\t" + DbConnection.fillCustom(query2, "first_name", "last_name", "article_name", "sort", "organic", "category", "quantity"));
                return;
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void palleteCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

