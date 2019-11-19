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

namespace Freshivoje.Packages
{
    public partial class PackagesRecordForm : Form
    {
        private int _selectedTransportId;
        private decimal _selectedTransportTotalPrice;
        private string _selectedTransportStatus, _selectedTransportDate;
        private readonly string _fillDGVQuery = @"SELECT 
		                                                    `clients`.`id_client` as `fk_client_id`,
		                                                    CONCAT_WS(' ', `clients`.`first_name`,`clients`.`last_name`,' (', `clients`.`JMBG`, ')') as `client`, 
		                                                    CONCAT_WS(' / ',`packaging`.`capacity`, `packaging`.`category`, `packaging`.`weight`, `packaging`.`producer`,`packaging`.`state`) as `packaging`,                                                            `packaging_record_items`.`quantity`,
                                                            IF (`packaging_records`.`type` = -1, 'IZNAJMLJENO', 'VRAĆENO') as `type`,
                                                            DATE_FORMAT(`packaging_records`.`date`, '%d.%m.%Y. %H:%i') as `datetime`
                                                    FROM `packaging_records`
                                                    JOIN `clients` ON `clients`.`id_client` = `packaging_records`.`fk_client_id`
                                                    JOIN `packaging_record_items` ON `packaging_records`.`id_packaging_record` = `packaging_record_items`.`fk_packaging_records_id`
                                                    JOIN `packaging` ON `packaging_record_items`.`fk_packaging_id` = `packaging`.`id_packaging`
                                                    GROUP BY `clients`.`id_client`, `packaging_records`.`id_packaging_record`, `packaging`.`id_packaging`, `type`
                                                    ORDER BY `date` DESC";

        public PackagesRecordForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //packagesRecordsDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(packagesRecordsDataGridView, _fillDGVQuery);
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
            string searchValue = searchRentPackagesRecordTxtBox.Text;
            (packagesRecordsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`datetime`, 'System.String') LIKE '%{searchValue}%' 
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
                _selectedTransportId = Convert.ToInt32(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["transportId"].Value);
                _selectedTransportStatus = packagesRecordsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
                _selectedTransportTotalPrice = Convert.ToDecimal(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["totalPrice"].Value);
                _selectedTransportDate = Convert.ToDateTime(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["transportDate"].Value).ToString("dd.MM.yyyy.");
            
                    MySqlCommand mySqlCommand = new MySqlCommand
                    {
                        CommandText = "SELECT * FROM `transport_items` WHERE `fk_transport_id` = @fkTransportId"
                    };
                    mySqlCommand.Parameters.AddWithValue("@fkTransportId", _selectedTransportId);
                    
                    string transportDetails = DbConnection.getTransportDetails(mySqlCommand);

                    string message = $"Cena po kilogramu (RSD) / Količina (kg) / Kilometri / Cena (RSD)\n\n{transportDetails}\nDatum: {_selectedTransportDate}\nStatus: {_selectedTransportStatus}\nUkupna cena: {_selectedTransportTotalPrice}";

                    CustomMessageBox.ShowDialog(this, message);
                    return;
               
            }
         
            if (e.ColumnIndex == 7)
            {
                _selectedTransportStatus = packagesRecordsDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();
               
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

                _selectedTransportId = Convert.ToInt32(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["transportId"].Value);


                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "UPDATE `transport` SET `transport_status` = 'plaćeno' WHERE `id_transport` = @id"
                };
                mySqlCommand.Parameters.AddWithValue("@id", _selectedTransportId);
                DbConnection.executeQuery(mySqlCommand);
                DbConnection.fillDGV(packagesRecordsDataGridView, _fillDGVQuery);
            }
        }
    }
}
