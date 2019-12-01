using System;
using System.Data;
using System.Windows.Forms;
using Freshivoje.Models;
using Freshivoje.Transport;

namespace Freshivoje.Shared_Forms
{
    public partial class ChooseClientForm : Form
    {
        private int _selectedClientId;
        private readonly string _childForm, _fillDGVQuery = "SELECT * FROM `clients` WHERE type = 'Fizičko lice'";
        private string _selectedClientFirstName = string.Empty,
                        _selectedClientLastName = string.Empty,
                        _selectedClientAddress = string.Empty,
                        _selectedClientJMBG = string.Empty,
                        _selectedClientBPG = string.Empty,
                        _selectedClientZipCode = string.Empty,
                        _selectedClientPhone = string.Empty;
        private string _clientInfo;
        public ChooseClientForm(string childForm)
        {
            InitializeComponent();
            _childForm = childForm;
            clientsDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(clientsDataGridView, _fillDGVQuery);

            switch (_childForm)
            {
                case "InsertForm":
                    {
                        lblTitle.Text += " ZA UNOS ARTIKALA";
                        break;
                    }
                case "RentPackagesForm":
                    {
                        lblTitle.Text += " ZA IZNAJMLJIVANJE AMBALAŽA";
                        break;
                    }
                case "TransportForm":
                    {
                        lblTitle.Text += " ZA PLAĆANJE PUTNIH NALOGA";
                        break;
                    }
            }

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
        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 8)
            {
                _selectedClientId = Convert.ToInt32(clientsDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);
                _selectedClientFirstName = clientsDataGridView.Rows[e.RowIndex].Cells["firstName"].Value.ToString();
                _selectedClientLastName = clientsDataGridView.Rows[e.RowIndex].Cells["lastName"].Value.ToString();
                _selectedClientAddress = clientsDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();
                _selectedClientJMBG = clientsDataGridView.Rows[e.RowIndex].Cells["JMBG"].Value.ToString();
                _selectedClientBPG = clientsDataGridView.Rows[e.RowIndex].Cells["BPG"].Value.ToString();
                _selectedClientZipCode = clientsDataGridView.Rows[e.RowIndex].Cells["zipCode"].Value.ToString();
                _selectedClientPhone = clientsDataGridView.Rows[e.RowIndex].Cells["phone"].Value.ToString();

                _clientInfo = $"{_selectedClientFirstName} {_selectedClientLastName} ({_selectedClientJMBG})";
                switch (_childForm)
                {
                    case "InsertForm":
                        {
                            Hide();
                            using InsertForm insertForm = new InsertForm(_selectedClientId);
                            insertForm.ShowDialog(this);
                            if (!IsDisposed)
                            {
                                Show();
                            }
                            break;
                        }
                    case "RentPackagesForm":
                        {
                            Hide();
                            using RentPackagesForm rentPackagesForm = new RentPackagesForm(_selectedClientId, _clientInfo);
                            rentPackagesForm.ShowDialog(this);
                            if (!IsDisposed)
                            {
                                Show();
                            }
                            break;
                        }
                    case "TransportForm":
                        {
                            Client client = new Client(_selectedClientId, _selectedClientFirstName, _selectedClientLastName, _selectedClientAddress,
                                                       string.Empty, _selectedClientJMBG, _selectedClientBPG, _selectedClientZipCode, string.Empty, _selectedClientPhone,
                                                       string.Empty, string.Empty, string.Empty);
                            Hide();
                            using TransportForm transportForm = new TransportForm(client);
                            transportForm.ShowDialog(this);
                            if (!IsDisposed)
                            {
                                Show();
                            }
                            break;
                        }
                    case "ChooseStorageRentingMethodForm":
                        {
                            Hide();
                            using InsertForm insertForm = new InsertForm(_selectedClientId);
                            insertForm.ShowDialog(this);
                            if (!IsDisposed)
                            {
                                Show();
                            }
                            break;
                        }
                }
            }
        }
        private void searchClientsTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchClientsTxtBox.Text;
            (clientsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`first_name` LIKE '%{searchValue}%' 
                                                                                    OR `last_name` LIKE '%{searchValue}%' 
                                                                                    OR `address` LIKE '%{searchValue}%'  
                                                                                    OR `JMBG` LIKE '%{searchValue}%'
                                                                                    OR `BPG` LIKE '%{searchValue}%' 
                                                                                    OR `zip_code` LIKE '%{searchValue}%'  
                                                                                    OR `bank_account` LIKE '%{searchValue}%'   
                                                                                    OR `phone` LIKE '%{searchValue}%'";
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
