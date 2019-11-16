using System;
using System.Data;
using System.Windows.Forms;
using Freshivoje.Transport;

namespace Freshivoje
{
    public partial class ChooseClientForm : Form
    {
        private int _selectedClientId;
        private readonly string _childForm,_fillDGVQuery = "SELECT * FROM `clients` WHERE type = 'Fizičko lice'";
        private string _clientInfo;
        public ChooseClientForm(string childForm)
        {
            InitializeComponent();
            _childForm = childForm;
            WindowState = FormWindowState.Maximized;
            clientsDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(clientsDataGridView, _fillDGVQuery);
            
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
                _clientInfo = $"{clientsDataGridView.Rows[e.RowIndex].Cells["firstName"].Value.ToString()} {clientsDataGridView.Rows[e.RowIndex].Cells["lastName"].Value.ToString()} ({clientsDataGridView.Rows[e.RowIndex].Cells["JMBG"].Value.ToString()})";
                switch (_childForm)
                {
                    case "InsertForm":
                        {
                            Hide();
                            using InsertForm insertForm = new InsertForm(_selectedClientId);
                            insertForm.ShowDialog(this);
                            Show();
                            break;
                        }
                    case "RentPackagesForm":
                        {
                            Hide();
                            using RentPackagesForm rentPackagesForm = new RentPackagesForm(_selectedClientId, _clientInfo);
                            rentPackagesForm.ShowDialog(this);
                            Show();
                            break;
                        }
                    case "TransportForm":
                        {
                            Hide();
                            using TransportForm transportForm = new TransportForm(_selectedClientId);
                            transportForm.ShowDialog(this);
                            Show();
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
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
