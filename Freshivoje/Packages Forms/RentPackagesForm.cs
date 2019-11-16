using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;
using Freshivoje.Custom_Forms;


namespace Freshivoje
{
    public partial class RentPackagesForm : Form
    {
        private int _selectedClientId, _selectedPackagingId;
        private string _selectedClientInfo = string.Empty;

        public RentPackagesForm(int clientId, string clientInfo)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            rentedPackagesDataGridView.AutoGenerateColumns = false;

            _selectedClientId = clientId;
            _selectedClientInfo = clientInfo;
            
            DbConnection.fillCmbBox(cratesCmbBox, "packaging", "id_packaging", "capacity", "category", "weight", "producer", "state");

            cratesCmbBox.SelectedIndex = 0;
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void rentPackagesBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(crateQuantityTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            int packagingId = (cratesCmbBox.SelectedItem as ComboBoxItem).Value;
            string[] packagingFields = cratesCmbBox.Text.Split('/');
            int packagingQuantity = Convert.ToInt32(crateQuantityTxtBox.Text);
            decimal packagingPrice = Convert.ToDecimal(price.Text) * packagingQuantity;
            int available = Convert.ToInt32(availablePackages.Text);

            Package package = new Package(packagingId, Convert.ToInt32(packagingFields[0]), packagingPrice, packagingFields[1], packagingQuantity, Convert.ToInt32(packagingFields[2]), packagingFields[3], packagingFields[4]);

            if (!checkAvailabilty(package._quantity, available)) 
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.packagingAvailabiltyErrorMsg);
                return;
            } 


            crateQuantityTxtBox.ResetText();
            crateQuantityTxtBox.Focus();

            foreach (DataGridViewRow row in rentedPackagesDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["packagingId"].Value) == package._id) 
                {
                    int sumQuantity = Convert.ToInt32(row.Cells["quantity"].Value) + package._quantity;
                    decimal sumCost = Convert.ToDecimal(row.Cells["totalCost"].Value) + package._price;

                    if (!checkAvailabilty(sumQuantity, available))
                    {
                        CustomMessageBox.ShowDialog(this, Properties.Resources.packagingAvailabiltyErrorMsg);
                        return;
                    }

                    row.Cells["quantity"].Value = sumQuantity;
                    row.Cells["totalCost"].Value = sumCost;
                    return;
                }
            }

            rentedPackagesDataGridView.Rows.Add(package._id, package._capacity, package._category, package._weight, package._producer, package._state, package._quantity, available, package._price);
           
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            if (rentedPackagesDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyDGVMsg);
                return;
            }

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da iznajmite ambalaže klijentu?\n{_selectedClientInfo}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "INSERT INTO `packaging_records` (`fk_packaging_id`, `fk_client_id`, `type`, `quantity`, `cost`) VALUES (@packagingId, @clientId, @type, @quantity, @cost)"
            };



            foreach (DataGridViewRow row in rentedPackagesDataGridView.Rows)
            {
                int packagingId = Convert.ToInt32(row.Cells["packagingId"].Value);
                int packagingQuantity = Convert.ToInt32(row.Cells["quantity"].Value);
                decimal cost = Convert.ToInt32(row.Cells["totalCost"].Value);

                mySqlCommand.Parameters.AddWithValue("@packagingId", packagingId);
                mySqlCommand.Parameters.AddWithValue("@clientId", _selectedClientId);
                mySqlCommand.Parameters.AddWithValue("@type", "IZLAZ");
                mySqlCommand.Parameters.AddWithValue("@quantity", packagingQuantity);
                mySqlCommand.Parameters.AddWithValue("@cost", cost);

                DbConnection.executeQuery(mySqlCommand);

                mySqlCommand.Parameters.Clear();

            }

            //mySqlCommand1.CommandText = "UPDATE `receipts` SET `total_price` = @totalPrice WHERE `id_receipt` = @receiptId";
            //mySqlCommand1.Parameters.AddWithValue("@totalPrice", totalPrice);
            //mySqlCommand1.Parameters.AddWithValue("@receiptId", receiptId);

            //DbConnection.executeQuery(mySqlCommand1);

            rentedPackagesDataGridView.Rows.Clear();
        }

        private void insertedArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da uklonite ove ambalaže iz iznajmljivanja?"); //\n{_selectedArticleName}/{_selectedArticleSort}/{_selectedArticleOrganic}\nKlasa: {_selectedArticleCategory}\nCena: {_selectedArticlePrice}");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }

                DataGridViewRow _selectedRow = rentedPackagesDataGridView.CurrentRow;
                rentedPackagesDataGridView.Rows.Remove(_selectedRow);
            }
        }

        private void cratesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPackagingId = (cratesCmbBox.SelectedItem as ComboBoxItem).Value;
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "SELECT `quantity` FROM `packaging` WHERE `id_packaging` = @packagingId"
            };

            mySqlCommand.Parameters.AddWithValue("@packagingId", _selectedPackagingId);

            int packagingQuantity = Convert.ToInt32(DbConnection.getValue(mySqlCommand));
            availablePackages.Text = packagingQuantity.ToString();

            mySqlCommand.CommandText = "SELECT `price` FROM `packaging` WHERE `id_packaging` = @packagingId";
            decimal packagingPrice = Convert.ToDecimal(DbConnection.getValue(mySqlCommand));
            price.Text = packagingPrice.ToString();
        }

        private bool checkAvailabilty(int quantity, int availablePackages)
        {
            return quantity <= availablePackages ? true : false;
        }
    }
}
