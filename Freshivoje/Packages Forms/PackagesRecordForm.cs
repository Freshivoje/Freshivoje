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
        private readonly string _fillDGVQuery = @"SELECT 
		                                                    `clients`.`id_client` as `fk_client_id`,
                                                            `packaging`.`id_packaging` as `packaging_id`,
		                                                    CONCAT(`clients`.`first_name`, ' ', `clients`.`last_name`, ' (', `clients`.`JMBG`, ')') as `client`, 
		                                                    CONCAT_WS(' / ',`packaging`.`capacity`, `packaging`.`category`, `packaging`.`weight`, `packaging`.`producer`,`packaging`.`state`) as `packaging`,                                                            `packaging_record_items`.`quantity`,
                                                            IF (`packaging_records`.`type` = -1, 'IZNAJMLJENO', 'VRAĆENO') as `type`,
                                                            DATE_FORMAT(`packaging_records`.`date`, '%d.%m.%Y. %H:%i') as `datetime`
                                                    FROM `packaging_records`
                                                    JOIN `clients` ON `clients`.`id_client` = `packaging_records`.`fk_client_id`
                                                    JOIN `packaging_record_items` ON `packaging_records`.`id_packaging_record` = `packaging_record_items`.`fk_packaging_records_id`
                                                    JOIN `packaging` ON `packaging_record_items`.`fk_packaging_id` = `packaging`.`id_packaging`
                                                    GROUP BY `clients`.`id_client`, `packaging_records`.`id_packaging_record`, `packaging`.`id_packaging`, `type`
                                                    ORDER BY `date` DESC";
        private readonly string _totaDebtByPackagingIdAndClientQuery = @"SELECT 
		                                                    `clients`.`id_client` as `fk_client_id`,
                                                            `packaging`.`id_packaging` as `packaging_id`,
		                                                    CONCAT_WS(' ', `clients`.`first_name`,`clients`.`last_name`,' (', `clients`.`JMBG`, ')') as `client`, 
		                                                    CONCAT_WS(' / ',`packaging`.`capacity`, `packaging`.`category`, `packaging`.`weight`, `packaging`.`producer`,`packaging`.`state`) as `packaging`, 
                                                            SUM(`packaging_record_items`.`quantity` * `packaging_records`.`type` * -1) as `quantity`                         
                                                    FROM `packaging_records`
                                                    JOIN `clients` ON `clients`.`id_client` = `packaging_records`.`fk_client_id`
                                                    JOIN `packaging_record_items` ON `packaging_records`.`id_packaging_record` = `packaging_record_items`.`fk_packaging_records_id`
                                                    JOIN `packaging` ON `packaging_record_items`.`fk_packaging_id` = `packaging`.`id_packaging`
                                                    GROUP BY `clients`.`id_client`, `packaging`.`id_packaging`
                                                    HAVING `quantity` > 0";

        public PackagesRecordForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            packagesRecordsDataGridView.AutoGenerateColumns = false;

            searchRecordTypeComboBox.SelectedIndex = 0;

          
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

        private void searchRentPackagesRecordTxtBox_TextChanged(object sender, EventArgs e)
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

        private void searchRecordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchRecordTypeComboBox.SelectedIndex == 0)
            {
                DbConnection.fillDGV(packagesRecordsDataGridView, _fillDGVQuery);
                packagesRecordsDataGridView.Columns["datetime"].Visible = true;
                packagesRecordsDataGridView.Columns[7].Visible = false;
            }
            else if (searchRecordTypeComboBox.SelectedIndex == 1)
            {
                DbConnection.fillDGV(packagesRecordsDataGridView, _totaDebtByPackagingIdAndClientQuery);
                packagesRecordsDataGridView.Columns["datetime"].Visible = false;
                packagesRecordsDataGridView.Columns[7].Visible = true;
            }
        }

        private void packagesRecordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int clientId = Convert.ToInt32(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["idClient"].Value);
                int packagingId = Convert.ToInt32(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["packagingId"].Value);
                int debt = Convert.ToInt32(packagesRecordsDataGridView.Rows[e.RowIndex].Cells["quantity"].Value);

                DialogResult result = CustomTextBoxDialog.ShowDialog(this, $"Klijent trenutno duguje {debt} ambalaža.\nKoliko sada vraća?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                
                int quantity = CustomTextBoxDialog._value;

                if (quantity < 1)
                {
                    CustomMessageBox.ShowDialog(this, "Molimo pokušajte ponovo sa odgovarajućim brojem.");
                    return;
                }

                if (quantity > debt)
                {
                    CustomMessageBox.ShowDialog(this, "Broj ambalaža koje klijent vraća premašuje ukupan broj ovih ambalaža koje duguje.\nMolimo pokušajte ponovo sa manjim brojem.");
                    return;
                }

                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = "INSERT INTO `packaging_records` (`fk_client_id`, `type`) VALUES (@clientId, @type); SELECT LAST_INSERT_ID();"
                };
                mySqlCommand.Parameters.AddWithValue("@clientId", clientId);
                mySqlCommand.Parameters.AddWithValue("@type", 1);

                int packagingRecordsId = Convert.ToInt32(DbConnection.getValue(mySqlCommand));

                mySqlCommand.Parameters.Clear();

                mySqlCommand.CommandText = "INSERT INTO `packaging_record_items` (`fk_packaging_records_id`, `fk_packaging_id`, `quantity`) VALUES (@packagingRecordsId, @packagingId, @quantity);";
                mySqlCommand.Parameters.AddWithValue("@packagingRecordsId", packagingRecordsId);
                mySqlCommand.Parameters.AddWithValue("@packagingId", packagingId);
                mySqlCommand.Parameters.AddWithValue("@quantity", quantity);

                DbConnection.executeQuery(mySqlCommand);
                mySqlCommand.Parameters.Clear();

                DbConnection.fillDGV(packagesRecordsDataGridView, _totaDebtByPackagingIdAndClientQuery);
            }

        }
    }
}
