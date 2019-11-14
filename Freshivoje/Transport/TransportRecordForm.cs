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

namespace Freshivoje.Transport
{
    public partial class TransportRecordForm : Form
    {
        private int _selectedTransportId;
        private string _selectedTransportStatus;
         string _fillDGVQuery = @"SELECT CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`) as client, `clients`.`id_client` as fk_client_id, `transport`.`id_transport`, `transport`.`transport_date`,`transport`.`transport_status` 
                                                    FROM `transport` 
                                                    JOIN `clients` ON `clients`.`id_client` = `transport`.`fk_client_id`";

        public TransportRecordForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TransportDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(TransportDataGridView, _fillDGVQuery);
            
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
            (TransportDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`transport_date`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `client` LIKE '%{searchValue}%'";
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
                _selectedTransportId = Convert.ToInt32(TransportDataGridView.Rows[e.RowIndex].Cells["id_transport"].Value);
                _selectedTransportStatus = TransportDataGridView.Rows[e.RowIndex].Cells["transport_status"].Value.ToString();
                if (_selectedTransportStatus == "plaćeno")
                {
                    CustomMessageBox.ShowDialog(this, $"Ovaj putni nalog je već plaćen!");
                    return;
                }
         
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da ste platili putni nalog?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `transport` SET transport_status='plaćeno' WHERE `id_transport`=@id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _selectedTransportId);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(TransportDataGridView, _fillDGVQuery);
            } 
        }
     
    }
}
