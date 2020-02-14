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

        public InsertStorageForm(int _storageId)
        {
            InitializeComponent();
            storageId = _storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            string query1 = "SELECT * FROM `pallete` WHERE pallete.status = 'aktivna'";
            string query = "SELECT `pallete`.`pallet_number`, pallete.classification FROM `pallete_positioning` INNER JOIN `pallete` ON pallete_positioning.fk_pallete_id = pallete.id_pallete WHERE pallete_positioning.fk_storage_id = " + storageId;
            //DbConnection.fillDGV(insertPalleteDataGridView, query);
            DbConnection.FillCmbBoxQuery(palleteCmbBox, query1, "id_pallete", "pallet_number");
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
            Pallete pallete = new Pallete(_palletId, _palletNumber);
            insertPalleteDataGridView.Rows.Add(pallete._id, pallete._number);
            palleteCmbBox.SelectedIndex = 0;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }


     
        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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

