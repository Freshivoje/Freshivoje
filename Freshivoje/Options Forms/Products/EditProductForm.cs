using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Freshivoje.Options_Forms
{
    public partial class EditProductForm : Form
    {
        private readonly Product _product;
        public EditProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTxtBox.Text) || string.IsNullOrWhiteSpace(productTypeTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }


            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da izmenite proizvod?\nIme: {_product._name}\nVrsta: {_product._type}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "UPDATE `products` SET `name` = @name, `type` = @type WHERE `id_product` = @productId"
            };
            mySqlCommand.Parameters.AddWithValue("@productId", _product._id);
            mySqlCommand.Parameters.AddWithValue("@name", _product._name);
            mySqlCommand.Parameters.AddWithValue("@type", _product._type);

            DbConnection.executeQuery(mySqlCommand);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
