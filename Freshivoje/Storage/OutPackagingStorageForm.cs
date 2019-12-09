using Freshivoje.Custom_Forms;
using Freshivoje.Models;
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
    public partial class OutPackagingStorageForm : Form
    {
        public Dictionary<Int32, Int32> MapOfPackages = new Dictionary<int, int>();
        public Dictionary<Int32, Int32> MapOfPacakges1 = new Dictionary<int, int>();
        public Dictionary<Int32, Int32> MapOfPackages2 = new Dictionary<int, int>();
        int _storageId;
        int _packagingId;
        bool state1;
        public OutPackagingStorageForm(int storageId)
        {
            _storageId = storageId;
            state1 = true;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            lblTitle.Text = "IZLAZ AMBALAŽA IZ KOMORU " + storageData.getName();
            string _fillCmdBox = $"SELECT packaging.id_packaging, packaging.capacity, packaging.category, packaging.state FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} GROUP BY packaging.id_packaging";
            DbConnection.FillCmbBoxQuery(packagingCmbBox, _fillCmdBox, "id_packaging", "capacity", "category", "state");
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


        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packagingLbl.Text) || packagingCmbBox.SelectedIndex < 0 || (Convert.ToDecimal(packagingLbl.Text) - Convert.ToDecimal(packagingQuantityTxtBox.Text) < 0))
            {
                CustomMessageBox.ShowDialog(this, "Količina koju ste uneli nije validna !");
                return;
            }

            int packageStorageQuantity = Convert.ToInt32(packagingLbl.Text);
            int packageQuantity = Convert.ToInt32(packagingQuantityTxtBox.Text);
            int sum, suma;
            if (packageStorageQuantity > packageQuantity)
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

                suma = packageStorageQuantity - packageQuantity;
                MapOfPackages.Add(package._id, suma);

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

        private void packagingCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packagingCmbBox.SelectedIndex < 1)
            {
                packagingLbl.Text = string.Empty;
                return;
            }
            _packagingId = ((ComboBoxItem)packagingCmbBox.SelectedItem).Value;
            if (PackagingDataGridView.RowCount == 0)
            {
                string _packagingQuantity = $"SELECT packaging.id_packaging as QuantityPackagingId, COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity), 0) FROM storage_record_items WHERE storage_record_items.status = 'neaktivna' AND storage_record_items.fk_storage_id = {_storageId} AND packaging.id_packaging = {_packagingId}) as QuantityPackg FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
                DbConnection.fillLbl(packagingLbl, _packagingQuantity, "", "QuantityPackagingId", "QuantityPackg");
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
                        string _packagingQuantity = $"SELECT packaging.id_packaging as QuantityPackagingId, COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity), 0) FROM storage_record_items WHERE storage_record_items.status = 'neaktivna' AND storage_record_items.fk_storage_id = {_storageId} AND packaging.id_packaging = {_packagingId}) as QuantityPackg FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
                        DbConnection.fillLbl(packagingLbl, _packagingQuantity, "", "QuantityPackagingId", "QuantityPackg");
                    }
                }
            }

        }

        private void PackagingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                int sum, suma;

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
                    CommandText = $"INSERT INTO `storage_record_items` ( `fk_storage_id`, `fk_packaging_id`, `date`, `type_of_storage_action`, `status`, `package_quantity`) VALUES ( @storageId, @packagingId, current_timestamp(), 'ulaz', 'neaktivna', @packagingQuantity);"
                };
                MySqlCommand mySqlCommand1 = new MySqlCommand
                {
                    CommandText = $"INSERT INTO `storage_record_items` ( `fk_storage_id`, `fk_packaging_id`, `date`, `type_of_storage_action`, `status`, `package_quantity`) VALUES ( '5', @packagingId, current_timestamp(), 'ulaz', 'neaktivna', @packagingQuantity);"
                };
                // Dodati query za vracanje ambalaza da su slobodne za ponovno koriscenje
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
    }
}
