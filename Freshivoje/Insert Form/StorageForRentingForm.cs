﻿using Freshivoje.Custom_Forms;
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

namespace Freshivoje.Insert_Form
{
    public partial class StorageForRentingForm : Form
    {
        int fkClientId, storageId;
        public StorageForRentingForm(int clientId)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DbConnection.fillCmbBox(storagePositionCmbBox, "storage", "id_storage", "storage_position", "article_quantity",  "package_quantity");
            storagePositionCmbBox.SelectedIndex = 1;
            rentingDataPicker.MinDate = DateTime.Now;
            fkClientId = clientId;
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

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            //odavde proveravaj
            if (string.IsNullOrWhiteSpace(storagePositionCmbBox.Text) || string.IsNullOrWhiteSpace(pricelTxtBox.Text)
           || string.IsNullOrWhiteSpace(rentingDataPicker.Text) || string.IsNullOrWhiteSpace(endDataOfRentPicker.Text)
           )
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }
            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da iznajmite\n Odeljak : {storagePositionCmbBox.Text}\nCena : {pricelTxtBox.Text} RSD\n Od : {rentingDataPicker.Text}\n Do : {endDataOfRentPicker.Text}\n");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            string dateOfRenting = rentingDataPicker.Value.Date.ToString("yyyy-MM-dd");
                string dateOfRentingEnd = endDataOfRentPicker.Value.Date.ToString("yyyy-MM-dd");
                storageId = (storagePositionCmbBox.SelectedItem as ComboBoxItem).Value;

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "INSERT INTO `renting_storage` (`fk_storage_id`, `price`, `renting_data`, `end_of_renting_data`, `fk_client_id`) VALUES (@storageId, @price, @dateOfRenting, @end_of_renting_data, @clientId);"
                };
                mySqlCommand.Parameters.AddWithValue("@storageId", storageId);
                mySqlCommand.Parameters.AddWithValue("@price", Decimal.Parse(pricelTxtBox.Text));
                mySqlCommand.Parameters.AddWithValue("@dateOfRenting", dateOfRenting);
                mySqlCommand.Parameters.AddWithValue("@end_of_renting_data", dateOfRentingEnd);
                mySqlCommand.Parameters.AddWithValue("@clientId", fkClientId);
                
                DbConnection.executeQuery(mySqlCommand);
                Close();
        }
    }
}