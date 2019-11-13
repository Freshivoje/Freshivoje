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
            storagePositionCmbBox.SelectedIndex = 0;
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
                string yearOfRenting = rentingDataPicker.Value.Year.ToString();
                string mounthOfRenting = rentingDataPicker.Value.Month.ToString();
                string dayOfRenting = rentingDataPicker.Value.Month.ToString();
                string dateOfRenting = $"{yearOfRenting}-{mounthOfRenting}-{dayOfRenting}";
                string yearOfRentingEnd = endDataOfRentPicker.Value.Year.ToString();
                string mounthOfRentingEnd = endDataOfRentPicker.Value.Month.ToString();
                string dayOfRentingEnd = endDataOfRentPicker.Value.Month.ToString();
                string dateOfRentingEnd = $"{yearOfRentingEnd}-{mounthOfRentingEnd}-{dayOfRentingEnd}";
                storageId = (storagePositionCmbBox.SelectedItem as ComboBoxItem).Value;

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "INSERT INTO `renting_storage` (`fk_storage_id`, `price`, `renting_data`, `end_of_renting_data`, `fk_client_id`) VALUES (@storageId, @price, @dateOfRenting, @end_of_renting_data, @clientId);"
                };
                mySqlCommand.Parameters.AddWithValue("@storageId", storageId);
                mySqlCommand.Parameters.AddWithValue("@price", Convert.ToInt32(pricelTxtBox.Text));
                mySqlCommand.Parameters.AddWithValue("@dateOfRenting", dateOfRenting);
                mySqlCommand.Parameters.AddWithValue("@end_of_renting_data", dateOfRentingEnd);
                mySqlCommand.Parameters.AddWithValue("@clientId", fkClientId);
            
        }
    }
}