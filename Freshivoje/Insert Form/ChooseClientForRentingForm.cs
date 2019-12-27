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

namespace Freshivoje.Insert_Form
{
    public partial class ChooseClientForRentingForm : Form
    {
        private int _selectedClientId;
        private string _selectedClientFirstName;
        private string _selectedClientLastName;
        private string _selectedClientAddress;
        private string _selectedClientJMBG;
        private string _selectedClientPIB;
        private string _selectedClientZipCode;
        private string _selectedClientPhone;
        private string _selectedClientCompanyName;
        private string _selectedClientSPO;
        private readonly string _fillDGVQuery = "SELECT * FROM `clients` WHERE type = 'Pravno lice'";
        public ChooseClientForRentingForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            clientsDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(clientsDataGridView, _fillDGVQuery);
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

            _selectedClientId = Convert.ToInt32(clientsDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);

            if (e.ColumnIndex == 10)
            {
                Hide();
                _selectedClientId = Convert.ToInt32(clientsDataGridView.Rows[e.RowIndex].Cells["clientId"].Value);
                _selectedClientFirstName = clientsDataGridView.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
                _selectedClientLastName = clientsDataGridView.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
                _selectedClientAddress = clientsDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();
                _selectedClientJMBG = clientsDataGridView.Rows[e.RowIndex].Cells["JMBG"].Value.ToString();
                _selectedClientPIB = clientsDataGridView.Rows[e.RowIndex].Cells["PIB"].Value.ToString();
                _selectedClientZipCode = clientsDataGridView.Rows[e.RowIndex].Cells["zip_code"].Value.ToString();
                _selectedClientPhone = clientsDataGridView.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                _selectedClientCompanyName = clientsDataGridView.Rows[e.RowIndex].Cells["company_name"].Value.ToString();
                _selectedClientSPO = clientsDataGridView.Rows[e.RowIndex].Cells["SPO"].Value.ToString();
                Client client = new Client(_selectedClientId, _selectedClientFirstName, _selectedClientLastName, _selectedClientAddress, string.Empty, _selectedClientJMBG, string.Empty, _selectedClientZipCode, string.Empty, _selectedClientPhone, _selectedClientPIB, _selectedClientSPO, _selectedClientCompanyName);

                using StorageForRentingForm storageForRentingForm = new StorageForRentingForm(client);
                storageForRentingForm.ShowDialog(this);
                Show();
            }
        }

        private void searchClientsTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchClientsTxtBox.Text.Replace('\'', (char)0x2019); // &rsquo; 
            (clientsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`first_name` LIKE '%{searchValue}%' 
                                                                                    OR `last_name` LIKE '%{searchValue}%' 
                                                                                    OR `address` LIKE '%{searchValue}%'  
                                                                                    OR `JMBG` LIKE '%{searchValue}%'
                                                                                    OR `PIB` LIKE '%{searchValue}%' 
                                                                                    OR `zip_code` LIKE '%{searchValue}%'  
                                                                                    OR `bank_account` LIKE '%{searchValue}%'   
                                                                                    OR `company_name` LIKE '%{searchValue}%'
                                                                                    OR `SPO` LIKE '%{searchValue}%'";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
