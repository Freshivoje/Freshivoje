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

            transportItems.Add(new TransportItems(fkClientId, price, quantity, travel, totalPrice));
            var bindingList = new BindingList<TransportItems>(transportItems);
            var source = new BindingSource(bindingList, null);
            transportDataGridView.DataSource = source;
            priceTxtBox.Text = "";
            quantityTxtBox.Text = "";
            travelTxtBox.Text = "";
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da želite da zavrsite plaćanje?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            DbConnection.executeTransportQuery(transportItems);
            CustomMessageBox.ShowDialog(this, "Uspešno ste kreirali nalog za plaćanje!");
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
    }
}
