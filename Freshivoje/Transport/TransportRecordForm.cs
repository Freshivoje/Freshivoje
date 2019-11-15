using Freshivoje.Custom_Forms;
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
using System.Windows.Threading;

namespace Freshivoje.Transport
{
    public partial class TransportRecordForm : Form
    {
        private int _selectedTransportId;
        private decimal _selectedTransportTotalPrice;
        private string _selectedTransportStatus, _selectedTransportDate;
        private readonly string _fillDGVQuery = @"SELECT CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`,' (', `clients`.`JMBG`, ')') as client, 
                                                `clients`.`id_client` as fk_client_id, 
                                                `transport`.`id_transport`, 
                                                DATE_FORMAT(`transport`.`transport_date`, '%d.%m.%Y.') as `transport_date`, `transport`.`total_price`, `transport`.`transport_status` 
                                                FROM `transport`
                                                JOIN `clients` ON `clients`.`id_client` = `transport`.`fk_client_id`";

        public TransportRecordForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            transportDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(transportDataGridView, _fillDGVQuery);
        }
    
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

        private void searchTransportxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTransportTxtBox.Text;
            (transportDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`transport_date`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `client` LIKE '%{searchValue}%'
                                                                                    OR `transport_status` LIKE '%{searchValue}%'";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TransportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                _selectedTransportId = Convert.ToInt32(transportDataGridView.Rows[e.RowIndex].Cells["transportId"].Value);
                _selectedTransportStatus = transportDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
                _selectedTransportTotalPrice = Convert.ToDecimal(transportDataGridView.Rows[e.RowIndex].Cells["totalPrice"].Value);
                _selectedTransportDate = Convert.ToDateTime(transportDataGridView.Rows[e.RowIndex].Cells["transportDate"].Value).ToString("dd.MM.yyyy.");
            
                    MySqlCommand mySqlCommand = new MySqlCommand
                    {
                        CommandText = "SELECT * FROM `transport_items` WHERE `fk_transport_id` = @fkTransportId"
                    };
                    mySqlCommand.Parameters.AddWithValue("@fkTransportId", _selectedTransportId);
                    
                    string transportDetails = DbConnection.getTransportDetails(mySqlCommand);

                    string message = $"Cena po kilogramu / Količina / Kilometri / Cena\n\n{transportDetails}\nDatum: {_selectedTransportDate}\nStatus: {_selectedTransportStatus}\nUkupna cena: {_selectedTransportTotalPrice}";

                    CustomMessageBox.ShowDialog(this, message);
                    return;
               
            }
         
            if (e.ColumnIndex == 7)
            {
                _selectedTransportStatus = transportDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
               
                if(_selectedTransportStatus == "plaćeno")
                {
                    CustomMessageBox.ShowDialog(this, "Ovaj putni nalog je plaćen!");
                    return;
                }
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da ste platili putni nalog?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }

                _selectedTransportId = Convert.ToInt32(transportDataGridView.Rows[e.RowIndex].Cells["transportId"].Value);


                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `transport` SET `transport_status` = 1 WHERE `id_transport` = @id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _selectedTransportId);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(transportDataGridView, _fillDGVQuery);
            }
        }
    }
}
