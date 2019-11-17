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
    public partial class EditPackageForm : Form
    {
        private readonly int _packageId;
        public EditPackageForm(Package package)
        {
            InitializeComponent();
            _packageId = package._id;
            packageCapacityTxtBox.Text = package._capacity.ToString();
            packagePriceTxtBox.Text = package._price.ToString();
            packageQuantityTxtBox.Text = package._quantity.ToString();
            packageCategoryTxtBox.Text = package._category.ToString();
            packageWeightTxtBox.Text = package._weight.ToString();
            packageProducerTxtBox.Text = package._producer.ToString();
            packageStatusCmbBox.Text = package._state.ToString();

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
            // 2 decimals only
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packageCapacityTxtBox.Text) || string.IsNullOrWhiteSpace(packagePriceTxtBox.Text) || string.IsNullOrWhiteSpace(packageQuantityTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            Package package = new Package(_packageId, Convert.ToInt32(packageCapacityTxtBox.Text), Convert.ToDecimal(packagePriceTxtBox.Text), Convert.ToString(packageCategoryTxtBox.Text), Convert.ToInt32(packageQuantityTxtBox.Text), Convert.ToInt32(packageWeightTxtBox.Text), Convert.ToString(packageProducerTxtBox.Text), Convert.ToString(packageStatusCmbBox.Text));

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da izmenite ambalažu?\nNosivost: {package._capacity} g\nKategorija: {packageCategoryTxtBox.Text}\nKoličina: {package._quantity}\nCena: {package._price} RSD\nTežina: {package._weight} g\nProizvođač: {package._producer}\nStatus: {package._state}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "UPDATE `packaging` SET `capacity` = @packageCapacity, `price` = @packagePrice,`category` = @packageCategory, `quantity` = @packageQuantity, `weight` = @packageWeight, `producer` = @packageProducer, `state` = @packageStatus WHERE `id_packaging` = @packagingId"

            };
            mySqlCommand.Parameters.AddWithValue("@packagingId", package._id);
            mySqlCommand.Parameters.AddWithValue("@packageCapacity", package._capacity);
            mySqlCommand.Parameters.AddWithValue("@packageQuantity", package._quantity);
            mySqlCommand.Parameters.AddWithValue("@packagePrice", package._price);
            mySqlCommand.Parameters.AddWithValue("@packageCategory", package._category);
            mySqlCommand.Parameters.AddWithValue("@packageWeight", package._weight);
            mySqlCommand.Parameters.AddWithValue("@packageProducer", package._producer);
            mySqlCommand.Parameters.AddWithValue("@packageStatus", package._state);

            DbConnection.executeQuery(mySqlCommand);
            Close();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
