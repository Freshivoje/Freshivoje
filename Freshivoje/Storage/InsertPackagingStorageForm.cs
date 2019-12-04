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

namespace Freshivoje.Storage
{
    public partial class InsertPackagingStorageForm : Form
    {
        int _storageId;
        int _packagingId;
        string _fillLbl = "SELECT COALESCE(SUM(storage_record_items.package_quantity), 0) as StoragePackagingQuantity, storage.id_storage, storage.storage_position, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 1";
        string _fillCmbBox = "SELECT `packaging`.`id_packaging` , `packaging`.`capacity`, `packaging`.`category`, `packaging`.`state`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() GROUP BY `packaging`.`id_packaging`;";
        public InsertPackagingStorageForm(int storageId)
        {
            InitializeComponent();
            _storageId = storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            DbConnection.FillCmbBoxQuery(packagingCmbBox, _fillCmbBox, "id_packaging", "capacity", "category", "state");
            string _fillLbl = $"SELECT COALESCE(SUM(storage_record_items.package_quantity), 0) as StoragePackagingQuantity, storage.id_storage, storage.storage_position, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = {storageId}";
            WindowState = FormWindowState.Maximized;
            lblTitle.Text = "UNOS AMBALAŽA U KOMORU " + storageData.getName();
            DbConnection.Storage(freeStorageLbl, _fillLbl, "StoragePackagingQuantity", "package_quantity");
            packagingCmbBox.SelectedIndex = 0;
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
        public void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void onlyNumerics(object sender, KeyPressEventArgs e)
        {
            // Limit input to numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // 2 decimals limit
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void packagingCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packagingCmbBox.SelectedIndex < 1)
            {
                packagingLbl.Text = string.Empty;
                return;
            }
             _packagingId = ((ComboBoxItem)packagingCmbBox.SelectedItem).Value;
            foreach (DataGridViewRow row in PackagingDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["articleId"].Value) == _packagingId)
                {

                    return;
                }
            }
            string _packagingQuantity = $"SELECT `packaging`.`id_packaging` as QuantityPackagingId, SUM(`packaging_record_items`.`quantity`) as `QuantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() AND `packaging`.`id_packaging` = {_packagingId} GROUP BY `packaging`.`id_packaging`";
            string _packagingStorageQuantity = $"SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as QuantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`= 5 AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
            _packagingId = ((ComboBoxItem)packagingCmbBox.SelectedItem).Value;
            DbConnection.fillLbl(packagingLbl, _packagingQuantity, _packagingStorageQuantity, "QuantityPackagingId", "QuantityPackg", "QuantityStoragePackagingId", "QuantityStoragePackaging");
        }
    }
}
