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
        public List<TransportItems> transportItems = new List<TransportItems>();
        int fkClientId;
        int idTransport = 0;
        
        public TransportForm(int clientId)
        {
            
            InitializeComponent();
            transportDataGridView.AutoGenerateColumns = false;
            fkClientId = clientId;
            WindowState = FormWindowState.Maximized;
         
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

        private void TransportForm_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(priceTxtBox.Text);
            decimal quantity = Convert.ToDecimal(quantityTxtBox.Text);
            decimal travel = Convert.ToDecimal(travelTxtBox.Text);
            decimal totalPrice = price * quantity * travel;
            idTransport++;
            transportItems.Add(new TransportItems(fkClientId, price, quantity, travel, totalPrice, idTransport));
            var bindingList = new BindingList<TransportItems>(transportItems);
            var source = new BindingSource(bindingList, null);
            transportDataGridView.DataSource = source;

            priceTxtBox.Text = "";
            quantityTxtBox.Text = "";
            travelTxtBox.Text = "";
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomDialog.ShowDialog(this,$"Da li ste sigurni da želite da zavrsite putni nalog?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            DbConnection.executeTransportQuery(transportItems);
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
                int broj = transportItems.Count;
                for (int i = 0; i < transportItems.Count; i++)
                {
                    if((transportItems[i]._id - 1) == rowindex)
                    {
                        transportItems.RemoveAt(Convert.ToInt32(rowindex));
                        var bindingList = new BindingList<TransportItems>(transportItems);
                        var source = new BindingSource(bindingList, null);
                        transportDataGridView.DataSource = source;
                    }
                }
            }
        }
    }
}
