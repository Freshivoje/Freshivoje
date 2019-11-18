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
            WindowState = FormWindowState.Maximized;
            StorageRentingDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(StorageRentingDataGridView, _fillDGVQuery);
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

        private void StorageRentingDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            if(e.ColumnIndex == 6)
            {
                _storageRentingId = Convert.ToInt32(StorageRentingDataGridView.Rows[e.RowIndex].Cells["id_renting_storage"].Value);
                _selectStoregeRentingStatus = StorageRentingDataGridView.Rows[e.RowIndex].Cells["renting_status"].Value.ToString();
                if(_selectStoregeRentingStatus == "plaćeno")
                {
                    CustomMessageBox.ShowDialog(this, $"Ova faktura za lagerovanje je vec placena!");
                    return;
                }

                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da ste platili fakturu za lagerovanje?");
                if(_selectStoregeRentingStatus == "plaćeno")
                {
                    return;
                }

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `renting_storage` SET `renting_status`='1' WHERE id_renting_storage=@id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _storageRentingId);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(StorageRentingDataGridView, _fillDGVQuery);
            }
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
