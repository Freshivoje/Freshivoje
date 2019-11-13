using Freshivoje.Custom_Forms;
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

namespace Freshivoje.Options_Forms
{
    public partial class CRUDClientsForm : Form
    {

        private readonly string _fillDGVQuery = "SELECT * FROM `clients`";
        private int _selectedClientId;
        private string _selectedClientFirstName = string.Empty,
                        _selectedClientLastName = string.Empty,
                        _selectedClientAddress = string.Empty,
                        _selectedClientType = string.Empty,
                        _selectedClientCompanyName = string.Empty,
                        _selectedClientJMBG = string.Empty,
                        _selectedClientPIB = string.Empty,
                        _selectedClientBPG = string.Empty,
                        _selectedClientSPO = string.Empty,
                        _selectedClientZipCode = string.Empty,
                        _selectedClientBankAccount = string.Empty,
                        _selectedClientPhone = string.Empty;
        public CRUDClientsForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientsDataGridView.AutoGenerateColumns = false;
            // BUG?
            clientsDataGridView.DefaultCellStyle.ForeColor = Color.Black;
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

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
        private void insertClientBtn_Click(object sender, EventArgs e)
        {
            using CreateClientForm createClientForm = new CreateClientForm();
            createClientForm.ShowDialog(this);
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            _selectedClientId = Convert.ToInt32(clientsDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);
            _selectedClientFirstName = clientsDataGridView.Rows[e.RowIndex].Cells["clientFirstName"].Value.ToString();
            _selectedClientLastName = clientsDataGridView.Rows[e.RowIndex].Cells["clientLastName"].Value.ToString();
            _selectedClientAddress = clientsDataGridView.Rows[e.RowIndex].Cells["clientAddress"].Value.ToString();
            _selectedClientType = clientsDataGridView.Rows[e.RowIndex].Cells["clientType"].Value.ToString();
            _selectedClientCompanyName = clientsDataGridView.Rows[e.RowIndex].Cells["clientCompanyName"].Value.ToString();
            _selectedClientJMBG = clientsDataGridView.Rows[e.RowIndex].Cells["clientJMBG"].Value.ToString();
            _selectedClientPIB = clientsDataGridView.Rows[e.RowIndex].Cells["clientPIB"].Value.ToString();
            _selectedClientBPG = clientsDataGridView.Rows[e.RowIndex].Cells["clientBPG"].Value.ToString();
            _selectedClientSPO = clientsDataGridView.Rows[e.RowIndex].Cells["clientSPO"].Value.ToString();
            _selectedClientZipCode = clientsDataGridView.Rows[e.RowIndex].Cells["clientZipCode"].Value.ToString();
            _selectedClientBankAccount = clientsDataGridView.Rows[e.RowIndex].Cells["clientBankAccount"].Value.ToString();
            _selectedClientPhone = clientsDataGridView.Rows[e.RowIndex].Cells["clientPhone"].Value.ToString();

            if (e.ColumnIndex == 13)
            {
                Client client = new Client(_selectedClientId,
                    _selectedClientFirstName, _selectedClientLastName, _selectedClientAddress, _selectedClientType,
                    _selectedClientJMBG,  _selectedClientBPG, 
                    _selectedClientZipCode, _selectedClientBankAccount, _selectedClientPhone, 
                    _selectedClientPIB, _selectedClientSPO, _selectedClientCompanyName
                    );

                using EditClientForm editClientForm = new EditClientForm(client);
                editClientForm.ShowDialog(this);
            }
            if (e.ColumnIndex == 14)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete klijenta?\nIme: {_selectedClientFirstName} {_selectedClientLastName}\nJMBG: {_selectedClientJMBG}\nTelefon: {_selectedClientPhone}");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DbConnection.deleteFromDB("clients", "id_client", _selectedClientId);
                DbConnection.fillDGV(clientsDataGridView, _fillDGVQuery);
            }

        }

        private void CRUDClientsForm_Activated(object sender, EventArgs e)
        {
            DbConnection.fillDGV(clientsDataGridView, _fillDGVQuery);
        }

        private void searchClientsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchValue = searchClientsTxtBox.Text;
            (clientsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`first_name` LIKE '%{searchValue}%' 
                                                                                    OR `last_name` LIKE '%{searchValue}%' 
                                                                                    OR `address` LIKE '%{searchValue}%'  
                                                                                    OR `type` LIKE '%{searchValue}%'  
                                                                                    OR `company_name` LIKE '%{searchValue}%'  
                                                                                    OR `JMBG` LIKE '%{searchValue}%'  
                                                                                    OR `PIB` LIKE '%{searchValue}%' 
                                                                                    OR `BPG` LIKE '%{searchValue}%' 
                                                                                    OR `zip_code` LIKE '%{searchValue}%'  
                                                                                    OR `bank_account` LIKE '%{searchValue}%'   
                                                                                    OR `phone` LIKE '%{searchValue}%'";
        }
    }
}
