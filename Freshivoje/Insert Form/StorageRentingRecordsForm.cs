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
    public partial class StorageRentingRecordsForm : Form
    {
        private int _storageRentingId;
        private string _selectStoregeRentingStatus;
        private string _fillDGVQuery = "SELECT CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`) as client, `clients`.`id_client` as fk_client_id, renting_storage.id_renting_storage, renting_storage.renting_status, renting_storage.issuing_date FROM renting_storage JOIN `clients` ON `clients`.`id_client` = renting_storage.`fk_client_id`";
                                                   
        public StorageRentingRecordsForm()
        {
            InitializeComponent();
            StorageRentingDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(StorageRentingDataGridView, _fillDGVQuery);
        }

        private void StorageRentingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StorageRentingDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

        private void searchRentingTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchRentingTxtBox.Text;
            (StorageRentingDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`issuing_date`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `client` LIKE '%{searchValue}%'";
        }
    }
}
