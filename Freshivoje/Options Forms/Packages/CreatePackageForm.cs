using Freshivoje.Custom_Forms;
using Freshivoje.Models;
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

namespace Freshivoje.Options_Forms
{
    public partial class CreatePackageForm : Form
    {
        public CreatePackageForm()
        {
            InitializeComponent();
            packageStatusCmbBox.SelectedIndex = 0;
        }

        // Disables flickering on FormLoad
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        private void blockEnter(object sender, KeyPressEventArgs e)
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

            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packageCapacityTxtBox.Text) || string.IsNullOrWhiteSpace(packagePriceTxtBox.Text) || string.IsNullOrWhiteSpace(packageQuantityTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            Package package = new Package(0, Convert.ToInt32(packageCapacityTxtBox.Text), Convert.ToDecimal(packagePriceTxtBox.Text), Convert.ToString(packageCategoryTxtBox.Text), Convert.ToInt32(packageQuantityTxtBox.Text), Convert.ToInt32(packageWeightTxtBox.Text), Convert.ToString(packageProducerTxtBox.Text), Convert.ToString(packageStatusCmbBox.Text));

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da kreirate ambalažu?\nNosivost: {package._capacity} grama\nKategorija: {packageCategoryTxtBox.Text}\nKoličina: {package._quantity}\nCena: {package._price} RSD\nTežina: {package._weight}grama\nProizvođač: {package._producer}\nStatus: {package._status}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "INSERT INTO `packaging` (`capacity`, `price`, `quantity`, `category`, `weight`, `producer`, `status`) VALUES (@packageCapacity, @packagePrice, @packageQuantity, @packageCategory, @packageWeight, @packageProducer, @packageStatus);"
            };
            mySqlCommand.Parameters.AddWithValue("@packageCapacity", package._capacity);
            mySqlCommand.Parameters.AddWithValue("@packagePrice", package._price);
            mySqlCommand.Parameters.AddWithValue("@packageQuantity", package._quantity);
            mySqlCommand.Parameters.AddWithValue("@packageCategory", package._packageCategory);
            mySqlCommand.Parameters.AddWithValue("@packageWeight", package._weight);
            mySqlCommand.Parameters.AddWithValue("@packageProducer", package._producer);
            mySqlCommand.Parameters.AddWithValue("@packageStatus", package._status);
             
            ///test
            DbConnection.executeQuery(mySqlCommand);
            Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
