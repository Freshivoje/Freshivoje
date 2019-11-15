using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;

namespace Freshivoje.Transport
{
    public partial class TransportForm : Form
    {
        public List<TransportItem> transportItems = new List<TransportItem>();
        private int _clientId;
        
        public TransportForm(int clientId)
        {    
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            transportDataGridView.AutoGenerateColumns = false;
            _clientId = clientId;   
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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTxtBox.Text) || string.IsNullOrWhiteSpace(quantityTxtBox.Text)
             || string.IsNullOrWhiteSpace(travelTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }
            decimal priceSingle = Convert.ToDecimal(priceTxtBox.Text);
            decimal quantity = Convert.ToDecimal(quantityTxtBox.Text);
            decimal travel = Convert.ToDecimal(travelTxtBox.Text);
            decimal price = priceSingle * quantity * travel;

            TransportItem transportItem = new TransportItem(0, _clientId, priceSingle, quantity, travel, price);

            transportDataGridView.Rows.Add(transportItem._id, transportItem._priceSingle, transportItem._quantity, transportItem._traveled, transportItem._price);

            priceTxtBox.ResetText();
            quantityTxtBox.ResetText();
            travelTxtBox.ResetText();

            priceTxtBox.Focus();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            if (transportDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyDGVMsg);
                return;
            } 

            DialogResult result = CustomDialog.ShowDialog(this,$"Da li ste sigurni da želite da unesete putne naloge?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            decimal totalPrice = 0;
            foreach (DataGridViewRow row in transportDataGridView.Rows)
            {
                decimal priceSingle = Convert.ToDecimal(row.Cells["price"].Value);
                decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                decimal traveled = Convert.ToDecimal(row.Cells["traveled"].Value);
                decimal price = Convert.ToDecimal(row.Cells["totalPrice"].Value);

                totalPrice += price;

                TransportItem item = new TransportItem(0, _clientId, priceSingle, quantity, traveled, price);
                transportItems.Add(item);
            }

            DbConnection.executeTransportQuery(transportItems, totalPrice);
            transportDataGridView.Rows.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void transportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete putni nalog?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DataGridViewRow _selectedRow = transportDataGridView.CurrentRow;
                transportDataGridView.Rows.Remove(_selectedRow);
            }
        }
    }
}
