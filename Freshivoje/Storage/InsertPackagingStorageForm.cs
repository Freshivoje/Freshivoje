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
using Freshivoje.Models;

namespace Freshivoje.Storage
{
    public partial class InsertPackagingStorageForm : Form
    {
        public Dictionary<Int32, Int32> MapOfPackages = new Dictionary<int, int>();
        public Dictionary<Int32, Int32> MapOfPacakges1 = new Dictionary<int, int>();
        public Dictionary<Int32, Int32> MapOfPackages2 = new Dictionary<int, int>();
        int _storageId;
        int _packagingId;
        bool state1;
       
        string _fillCmbBox = "SELECT `packaging`.`id_packaging` , `packaging`.`capacity`, `packaging`.`category`, `packaging`.`state`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() GROUP BY `packaging`.`id_packaging`;";
        public InsertPackagingStorageForm(int storageId)
        {
            InitializeComponent();
            _storageId = storageId;
            MySqlCommand cmd = new MySqlCommand();
            state1 = true;
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            DbConnection.FillCmbBoxQuery(packagingCmbBox, _fillCmbBox, "id_packaging", "capacity", "category", "state");
            string _fillLbl = $"SELECT COALESCE(SUM(storage_record_items.package_quantity), 0) as StoragePackagingQuantity, storage.id_storage, storage.storage_position, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = {storageId} AND storage_record_items.status = 'aktivna';";
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
            if (PackagingDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, "Niste uneli nijedanu ambalažu");
                return;
            }
            DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da želite da unesete ove ambalaže u komoru ?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }


            foreach (DataGridViewRow row in PackagingDataGridView.Rows)
            {
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = $"INSERT INTO `storage_record_items` ( `fk_storage_id`, `fk_packaging_id`, `date`, `type_of_storage_action`, `status`, `package_quantity`) VALUES ( @storageId, @packagingId, current_timestamp(), 'ulaz', 'aktivna', @packagingQuantity);"
                };
                MySqlCommand mySqlCommand1 = new MySqlCommand
                {
                    CommandText = $"INSERT INTO `storage_record_items` ( `fk_storage_id`, `fk_packaging_id`, `date`, `type_of_storage_action`, `status`, `package_quantity`) VALUES ( '5', @packagingId, current_timestamp(), 'ulaz', 'aktivna', @packagingQuantity);"
                };
                mySqlCommand.Parameters.AddWithValue("@storageId", _storageId);
                mySqlCommand.Parameters.AddWithValue("@packagingId", row.Cells["packagingId"].Value);
                mySqlCommand.Parameters.AddWithValue("@packagingQuantity", row.Cells["quantity"].Value);
                mySqlCommand1.Parameters.AddWithValue("@packagingId", row.Cells["packagingId"].Value);
                mySqlCommand1.Parameters.AddWithValue("@packagingQuantity", row.Cells["quantity"].Value);
                DbConnection.executeQuery(mySqlCommand1);
                DbConnection.executeQuery(mySqlCommand);

            }

            PackagingDataGridView.Rows.Clear();
            Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packagingLbl.Text) || packagingCmbBox.SelectedIndex < 0 || (Convert.ToDecimal(packagingLbl.Text) - Convert.ToDecimal(packagingQuantityTxtBox.Text) < 0))
            {
                CustomMessageBox.ShowDialog(this, "Količina koju ste uneli nije validna !");
                return;
            }
            int freeStorage = Convert.ToInt32(freeStorageLbl.Text);
            int packageStorageQuantity = Convert.ToInt32(packagingLbl.Text);
            int packageQuantity = Convert.ToInt32(packagingQuantityTxtBox.Text);
            int sum, suma;
            if (freeStorage > packageQuantity && packageStorageQuantity > packageQuantity)
            {
                int packageId = (packagingCmbBox.SelectedItem as ComboBoxItem).Value;
                string[] packageFields = packagingCmbBox.Text.Split('/');
                Package package = new Package(packageId, Convert.ToInt32(packageFields[0]), 0, packageFields[1], packageQuantity, 0, "", packageFields[2]);

                foreach (DataGridViewRow row in PackagingDataGridView.Rows)
                {

                    if (Convert.ToInt32(row.Cells["packagingId"].Value) == package._id)
                    {
                        int sumQuantity = Convert.ToInt32(row.Cells["quantity"].Value) + package._quantity;
                        row.Cells["quantity"].Value = sumQuantity;
                        sum = freeStorage - sumQuantity;
                        suma = packageStorageQuantity - package._quantity;

                        
                        packagingCmbBox.SelectedItem = 0;
                        MapOfPackages2 = MapOfPackages;

                        foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                        {

                            if (item.Key == package._id)
                            {
                                MapOfPacakges1[item.Key] = suma;
                            }

                        }
                        foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                        {
                            foreach (KeyValuePair<Int32, Int32> item1 in MapOfPacakges1)
                            {
                                if (item.Key == item1.Key)
                                {
                                    int key = item.Key;
                                    int value = MapOfPacakges1[item1.Key];
                                    MapOfPackages2[key] = value;
                                    MapOfPackages = MapOfPackages2;
                                    freeStorageLbl.Text = sum.ToString();
                                    packagingLbl.Text = suma.ToString();
                                    packagingQuantityTxtBox.ResetText();
                                    return;
                                }

                            }
                        }


                    }
                }
                MapOfPackages2 = MapOfPackages;
                suma = packageStorageQuantity - package._quantity;
                foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                {

                    if (item.Key == package._id)
                    {
                        MapOfPacakges1[item.Key] = suma;
                    }

                }
                foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                {
                    foreach (KeyValuePair<Int32, Int32> item1 in MapOfPacakges1)
                    {
                        if (item.Key == package._id)
                        {
                            int key = item.Key;
                            int value = MapOfPacakges1[item1.Key];
                            MapOfPackages2[key] = value;
                            MapOfPackages = MapOfPackages2;
                            packagingLbl.Text = value.ToString();
                            PackagingDataGridView.Rows.Add(package._id, package._capacity, package._category, package._state, packageQuantity);
                            packagingQuantityTxtBox.ResetText();
                            return;
                        }

                    }
                }
                PackagingDataGridView.Rows.Add(package._id, package._capacity, package._category, package._state, packageQuantity);
                state1 = false;
                sum = freeStorage - package._quantity;
                suma = packageStorageQuantity - packageQuantity;
                MapOfPackages.Add(package._id, suma);
                freeStorageLbl.Text = sum.ToString();
                packagingLbl.Text = suma.ToString();
                packagingQuantityTxtBox.ResetText();
                packagingCmbBox.SelectedItem = 0;
            }
            else
            {
                CustomMessageBox.ShowDialog(this, "Količina koju ste uneli je van limita!");
                return;
            }
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
            if(PackagingDataGridView.RowCount == 0)
            {
                string _packagingQuantity = $"SELECT `packaging`.`id_packaging` as QuantityPackagingId, SUM(`packaging_record_items`.`quantity`) as `QuantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() AND `packaging`.`id_packaging` = {_packagingId} GROUP BY `packaging`.`id_packaging`";
                string _packagingStorageQuantity = $"SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as QuantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`= 5 AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
                DbConnection.fillLbl(packagingLbl, _packagingQuantity, _packagingStorageQuantity, "QuantityPackagingId", "QuantityPackg", "QuantityStoragePackagingId", "QuantityStoragePackaging");
            }
            foreach (DataGridViewRow row in PackagingDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["packagingId"].Value) == _packagingId)
                {
                    foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                    {
                        if (item.Key == _packagingId)
                        {
                            packagingLbl.Text = MapOfPackages[item.Key].ToString();
                            return;
                        }
                    }
                }
            }
            foreach (DataGridViewRow row in PackagingDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["packagingId"].Value) != _packagingId)
                {
                    foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                    {
                        string _packagingQuantity = $"SELECT `packaging`.`id_packaging` as QuantityPackagingId, SUM(`packaging_record_items`.`quantity`) as `QuantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() AND `packaging`.`id_packaging` = {_packagingId} GROUP BY `packaging`.`id_packaging`";
                        string _packagingStorageQuantity = $"SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as QuantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`= 5 AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
                        DbConnection.fillLbl(packagingLbl, _packagingQuantity, _packagingStorageQuantity, "QuantityPackagingId", "QuantityPackg", "QuantityStoragePackagingId", "QuantityStoragePackaging");
                    }
                }
            }

        }

        private void PackagingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                
                    int sum, suma;
                    int freeStorage = Convert.ToInt32(freeStorageLbl.Text);
                    int articleStorageQuantity = Convert.ToInt32(packagingLbl.Text);
                    DataGridViewRow _selectedRow = PackagingDataGridView.CurrentRow;
                    int sumsa = Convert.ToInt32(_selectedRow.Cells["quantity"].Value);
                    int _selectedPackagingId = Convert.ToInt32(_selectedRow.Cells["packagingId"].Value);

                    if ((packagingCmbBox.SelectedItem as ComboBoxItem).Value == _selectedPackagingId)
                    {
                        DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ovu ambalažu iz unosa?");
                        if (result == DialogResult.No || result == DialogResult.Cancel)
                        {
                            return;
                        }

                        sumsa = Convert.ToInt32(_selectedRow.Cells["quantity"].Value);
                        sum = freeStorage + sumsa;
                        MapOfPackages2 = MapOfPackages;
                        foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                        {
                            if (item.Key == _selectedPackagingId)
                            {
                                suma = articleStorageQuantity + sumsa;
                                MapOfPacakges1[item.Key] = suma;
                            }

                        }
                        foreach (KeyValuePair<Int32, Int32> item in MapOfPackages)
                        {
                            foreach (KeyValuePair<Int32, Int32> item1 in MapOfPackages)
                            {
                                if (item.Key == _selectedPackagingId)
                                {
                                    int key = item.Key;
                                    int value = MapOfPacakges1[item.Key];
                                    MapOfPackages2[key] = value;
                                    MapOfPackages = MapOfPackages2;

                                    freeStorageLbl.Text = sum.ToString();
                                    packagingLbl.Text = value.ToString();
                                    packagingQuantityTxtBox.ResetText();
                                    PackagingDataGridView.Rows.Remove(_selectedRow);
                                    return;
                                }

                            }
                        }

                    }
                    else
                    {
                        CustomMessageBox.ShowDialog(this, "Niste Izabrali dobar artikl za brisanje!");
                        return;
                    }
                
            }
        }
    }
}
