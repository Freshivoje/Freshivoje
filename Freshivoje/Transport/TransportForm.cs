using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transportItems.Count; i++)
            {
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = @"INSERT INTO `transport` (`fk_client_id`, `price`, `quantity`, `traveled`, `total_price`) VALUES ('@fkClientId', '@price', '@quantity', '@travel', '@total_price')"
                };

                mySqlCommand.Parameters.AddWithValue("@fkClientId", transportItems[i]._clientId);
                mySqlCommand.Parameters.AddWithValue("@price", transportItems[i]._price);
                mySqlCommand.Parameters.AddWithValue("@quantity", transportItems[i]._quantity);
                mySqlCommand.Parameters.AddWithValue("@travel", transportItems[i]._traveled);
                mySqlCommand.Parameters.AddWithValue("@total_price", transportItems[i]._totalPrice);

                DbConnection.executeQuery(mySqlCommand);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
