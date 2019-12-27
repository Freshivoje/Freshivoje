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
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
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

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTxtBox.Text) || string.IsNullOrWhiteSpace(productTypeTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            Product product = new Product(0, productNameTxtBox.Text, productTypeTxtBox.Text);

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da kreirate proizvod?\nIme: {product._name}\nVrsta: {product._type}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "INSERT INTO `products` (`name`, `type`) VALUES (@name, @type)"
            };
            mySqlCommand.Parameters.AddWithValue("@name", product._name);
            mySqlCommand.Parameters.AddWithValue("@type", product._type);
     
             
            DbConnection.executeQuery(mySqlCommand);
            Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
