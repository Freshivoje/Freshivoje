using Freshivoje.Models;
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
    public partial class ChooseClientTransportForm : Form
    {
        private int _selectedClientId;
        private readonly string _fillDGVQuery = "SELECT * FROM `clients` WHERE type = 'Fizičko lice'";
        private string _selectedClientFirstName = string.Empty,
                        _selectedClientLastName = string.Empty,
                        _selectedClientAddress = string.Empty,
                        _selectedClientJMBG = string.Empty,
                        _selectedClientBPG = string.Empty,
                        _selectedClientZipCode = string.Empty,
                        _selectedClientPhone = string.Empty;
        public ChooseClientTransportForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientsTransportDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(clientsTransportDataGridView, _fillDGVQuery);
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
        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            _selectedClientId = Convert.ToInt32(clientsTransportDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);

            if (e.ColumnIndex == 8)
            {
                _selectedClientId = Convert.ToInt32(clientsTransportDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);
                _selectedClientFirstName = clientsTransportDataGridView.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
                _selectedClientLastName = clientsTransportDataGridView.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
                _selectedClientAddress = clientsTransportDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();
                _selectedClientJMBG = clientsTransportDataGridView.Rows[e.RowIndex].Cells["JMBG"].Value.ToString();
                _selectedClientBPG = clientsTransportDataGridView.Rows[e.RowIndex].Cells["BPG"].Value.ToString();
                _selectedClientZipCode = clientsTransportDataGridView.Rows[e.RowIndex].Cells["zip_code"].Value.ToString();
                _selectedClientPhone = clientsTransportDataGridView.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                

                Client client = new Client(_selectedClientId,
                    _selectedClientFirstName, _selectedClientLastName, _selectedClientAddress, string.Empty,
                    _selectedClientJMBG, _selectedClientBPG,
                    _selectedClientZipCode, string.Empty, _selectedClientPhone,
                    string.Empty, string.Empty, string.Empty
                    );
                using TransportForm transportForm = new TransportForm(client);
                transportForm.ShowDialog(this);
            }
        
        }
        private void searchClientsTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchClientsTxtBox.Text;
            (clientsTransportDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`first_name` LIKE '%{searchValue}%' 
                                                                                    OR `last_name` LIKE '%{searchValue}%' 
                                                                                    OR `address` LIKE '%{searchValue}%'  
                                                                                    OR `JMBG` LIKE '%{searchValue}%'
                                                                                    OR `BPG` LIKE '%{searchValue}%' 
                                                                                    OR `zip_code` LIKE '%{searchValue}%'  
                                                                                    OR `bank_account` LIKE '%{searchValue}%'   
                                                                                    OR `phone` LIKE '%{searchValue}%'";
        }

        private void exitBtn_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
