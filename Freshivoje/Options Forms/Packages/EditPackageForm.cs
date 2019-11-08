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
            DbConnection.fillCmbBox(packageCategoryCmbBox, "categories", "id_category", "category_name");
            _packageId = package._id;
            packageCapacityTxtBox.Text = package._capacity.ToString();
            packagePriceTxtBox.Text = package._price.ToString();
            packageQuantityTxtBox.Text = package._quantity.ToString();
            packageCategoryCmbBox.SelectedIndex = package._packageFkCategoryId - 1;
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packageCapacityTxtBox.Text) || string.IsNullOrWhiteSpace(packagePriceTxtBox.Text) || string.IsNullOrWhiteSpace(packageQuantityTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            Package package = new Package(_packageId, Convert.ToInt32(packageCapacityTxtBox.Text), Convert.ToDecimal(packagePriceTxtBox.Text), ((ComboBoxItem)packageCategoryCmbBox.SelectedItem).Value, Convert.ToInt32(packageQuantityTxtBox.Text));

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da izmenite ambalažu?\nNosivost: {package._capacity} grama\nKategorija: {packageCategoryCmbBox.Text}\nKoličina: {package._quantity}\nCena: {package._price} RSD");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }


            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "UPDATE `packaging` SET `capacity` = @packageCapacity, `price` = @packagePrice,`fk_category_id` = @packageCategoryId, `quantity` = @packageQuantity WHERE `id_packaging` = @packagingId"

            };
            mySqlCommand.Parameters.AddWithValue("@packagingId", package._id);
            mySqlCommand.Parameters.AddWithValue("@packageCapacity", package._capacity);
            mySqlCommand.Parameters.AddWithValue("@packageQuantity", package._quantity);
            mySqlCommand.Parameters.AddWithValue("@packagePrice", package._price);
            mySqlCommand.Parameters.AddWithValue("@packageCategoryId", package._packageFkCategoryId);

            DbConnection.executeQuery(mySqlCommand);
            Close();
        }
    }
}
