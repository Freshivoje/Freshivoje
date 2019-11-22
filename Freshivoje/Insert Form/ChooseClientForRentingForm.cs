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

                using StorageForRentingForm storageForRentingForm = new StorageForRentingForm(_selectedClientId);
                storageForRentingForm.ShowDialog(this);
                Show();
            }
        }

        private void searchClientsTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchClientsTxtBox.Text;
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
