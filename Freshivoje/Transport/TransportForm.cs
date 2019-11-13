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
        private int idTransport = 0;
        
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
            decimal price = Convert.ToDecimal(priceTxtBox.Text);
            decimal quantity = Convert.ToDecimal(quantityTxtBox.Text);
            decimal travel = Convert.ToDecimal(travelTxtBox.Text);
            decimal totalPrice = price * quantity * travel;
            idTransport++;
            transportItems.Add(new TransportItem(_clientId, price, quantity, travel, totalPrice, idTransport));
            var bindingList = new BindingList<TransportItem>(transportItems);
            var source = new BindingSource(bindingList, null);
            transportDataGridView.DataSource = source;

            priceTxtBox.ResetText();
            quantityTxtBox.ResetText();
            travelTxtBox.ResetText();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomDialog.ShowDialog(this,$"Da li ste sigurni da želite da završite putni nalog?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            DbConnection.executeTransportQuery(transportItems, _clientId);
            CustomMessageBox.ShowDialog(this,$"Uspešno ste kreirali putni nalog!");
            Close();
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
                int rowindex = transportDataGridView.CurrentRow.Index;
                for (int i = 0; i < transportItems.Count; i++)
                {
                    if((transportItems[i]._id - 1) == rowindex)
                    {
                        transportItems.RemoveAt(Convert.ToInt32(rowindex));
                        var bindingList = new BindingList<TransportItem>(transportItems);
                        var source = new BindingSource(bindingList, null);
                        transportDataGridView.DataSource = source;
                    }
                }
            }
        }
    }
}
