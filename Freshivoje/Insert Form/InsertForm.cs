using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;
using Freshivoje.Custom_Forms;


namespace Freshivoje
{
    public partial class InsertForm : Form
    {
        private readonly int _selectedClientId;
        private int _articleId, _packagingId;
        private decimal _palletWeight = 1M, _packagingWeight, _selectedArticlePrice;
        private readonly string _selectedArticleName = string.Empty,
                        _selectedArticleSort = string.Empty, 
                        _selectedArticleOrganic = string.Empty,
                        _selectedArticleCategory = string.Empty;

        public InsertForm(int clientId)
        {
            InitializeComponent();
            insertedArticlesDataGridView.AutoGenerateColumns = false;

            _selectedClientId = clientId;
            
            DbConnection.fillCmbBox(articlesCmbBox, "articles", '/', "id_article", "article_name", "sort", "organic", "category");
            DbConnection.fillCmbBox(cratesCmbBox, "packaging",  '/', "id_packaging", "capacity", "category", "weight", "producer", "state");

            palletCmbBox.SelectedIndex = 1;
            articlesCmbBox.SelectedIndex = 0;

            crateOwnerCmbBox.SelectedIndex = 0;
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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (articlesCmbBox.SelectedIndex == 0 || cratesCmbBox.SelectedIndex == 0)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.selectComboBoxItemMsg);
                return;
            }

            if (crateOwnerCmbBox.SelectedIndex == 0 && Convert.ToInt32(debtLbl.Text) < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.packagingDebtMsg);
                return;
            }

            if ((palletCmbBox.SelectedIndex == 0 && (string.IsNullOrWhiteSpace(palletWeightTxtBox.Text) || string.IsNullOrWhiteSpace(numberOfPalletsTxtBox.Text))) 
                || (string.IsNullOrWhiteSpace(articleQuantityTxtBox.Text) || string.IsNullOrWhiteSpace(crateQuantityTxtBox.Text)))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            if (palletCmbBox.SelectedIndex == 0)
            {
                _palletWeight = Convert.ToDecimal(palletWeightTxtBox.Text) * Convert.ToDecimal(numberOfPalletsTxtBox.Text);
            }

            string article = articlesCmbBox.Text;

            int brutoWeight = Convert.ToInt32(articleQuantityTxtBox.Text);
            decimal articlePrice = Convert.ToDecimal(articlePriceLbl.Text);

            decimal crateWeight = _packagingWeight;
            int numberOfReturnedPackagings = Convert.ToInt32(crateQuantityTxtBox.Text);

            decimal nonArticleWeight = crateWeight * numberOfReturnedPackagings + _palletWeight;

            decimal netoWeight = decimal.Round(brutoWeight - nonArticleWeight, 2);

            decimal price = Math.Round(netoWeight * articlePrice, 2);

            int articleId = (articlesCmbBox.SelectedItem as ComboBoxItem).Value;

            string packageOwnership = crateOwnerCmbBox.Text;

            int totalNumberOfReturnedPackagings = numberOfReturnedPackagings;
            int packagingDebt;

            foreach (DataGridViewRow row in insertedArticlesDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["packagingId"].Value) == _packagingId
                    && row.Cells["packagingOwnership"].Value.ToString() == packageOwnership
                    && crateOwnerCmbBox.SelectedIndex == 0)
                {
                    packagingDebt = Convert.ToInt32(row.Cells["packagingDebt"].Value);
                    totalNumberOfReturnedPackagings = Convert.ToInt32(row.Cells["packagingQuantity"].Value) + totalNumberOfReturnedPackagings;
                    if (!checkAvailability(totalNumberOfReturnedPackagings, packagingDebt))
                    {
                        CustomMessageBox.ShowDialog(this, Properties.Resources.packagingDebtAvailabilityErrorMsg);
                        return;
                    }
                }
  
            }
            
            foreach (DataGridViewRow row in insertedArticlesDataGridView.Rows)
            {
  
                if (Convert.ToInt32(row.Cells["articleId"].Value) == articleId 
                    && Convert.ToInt32(row.Cells["packagingId"].Value) == _packagingId 
                    && row.Cells["packagingOwnership"].Value.ToString() == packageOwnership)
                {
                    netoWeight = Convert.ToDecimal(row.Cells["articleQuantity"].Value) + netoWeight;
                    numberOfReturnedPackagings = Convert.ToInt32(row.Cells["packagingQuantity"].Value) + numberOfReturnedPackagings;
                    if (packageOwnership == "Hladnjača" && numberOfReturnedPackagings > totalNumberOfReturnedPackagings)
                    {
                        CustomMessageBox.ShowDialog(this, Properties.Resources.packagingDebtAvailabilityErrorMsg);
                        return;
                    }
                    price = Convert.ToDecimal(row.Cells["articlePrice"].Value) + price;

                    if (packageOwnership == "Hladnjača" && !checkAvailability(numberOfReturnedPackagings, Convert.ToInt32(debtLbl.Text)))
                    {
                        CustomMessageBox.ShowDialog(this, Properties.Resources.packagingDebtAvailabilityErrorMsg);
                        return;
                    }

                    row.Cells["articleQuantity"].Value = netoWeight;
                    row.Cells["packagingQuantity"].Value = numberOfReturnedPackagings;
                    row.Cells["articlePrice"].Value = price;
                    
                    crateQuantityTxtBox.ResetText();
                    articleQuantityTxtBox.ResetText();
                    crateQuantityTxtBox.Select();

                    return;
                } 
            }

            if (crateOwnerCmbBox.SelectedIndex == 0 && !checkAvailability(numberOfReturnedPackagings, Convert.ToInt32(debtLbl.Text)))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.packagingDebtAvailabilityErrorMsg);
                return;
            }

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da unesete artikal?\n{article}\nNeto kilaža: {netoWeight.ToString("0.00")}\nCena: {price} RSD");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            insertedArticlesDataGridView.Rows.Add(_packagingId, articleId, articlesCmbBox.Text, netoWeight.ToString("0.00"), cratesCmbBox.Text, numberOfReturnedPackagings, debtLbl.Text, packageOwnership, price);

            crateQuantityTxtBox.ResetText();
            articleQuantityTxtBox.ResetText();
            crateQuantityTxtBox.Select();
        }

        public void getPackagingDebtQuantity()
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = @"SELECT 
                                    SUM(`packaging_record_items`.`quantity` * `packaging_records`.`type` * -1) as `quantity`                         
                                FROM `packaging_records`
                                JOIN `clients` ON `clients`.`id_client` = `packaging_records`.`fk_client_id`
                                JOIN `packaging_record_items` ON `packaging_records`.`id_packaging_record` = `packaging_record_items`.`fk_packaging_records_id`
                                JOIN `packaging` ON `packaging_record_items`.`fk_packaging_id` = `packaging`.`id_packaging`
                                WHERE `packaging_record_items`.`ownership` = 'Hladnjača' AND `packaging_record_items`.`fk_packaging_id` = @packagingId AND `clients`.`id_client` = @clientId
                                GROUP BY `clients`.`id_client`, `packaging`.`id_packaging`
                                HAVING `quantity` > 0"
            };
            mySqlCommand.Parameters.AddWithValue("@packagingId", _packagingId);
            mySqlCommand.Parameters.AddWithValue("@clientId", _selectedClientId);

            int quantity = Convert.ToInt32(DbConnection.getValue(mySqlCommand));
            debtLbl.Text = quantity.ToString();
        }

        private void crateOwnerCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (crateOwnerCmbBox.SelectedIndex == 0)
            {
                
                debtLbl.Visible = true;
                packagingDebtLbl.Visible = true;
            } else
            {
                debtLbl.Text = Properties.Resources.dashInput;
                debtLbl.Visible = false;
                packagingDebtLbl.Visible = false;
            }
        }

        public void getArticlePrice()
        {
            if (articlesCmbBox.SelectedIndex < 1)
            {
                articlePriceLbl.Text = string.Empty;
                return;
            }
            _articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = $"SELECT `value` FROM `prices` WHERE `fk_article_id` = {_articleId} AND `status` = 'aktivna'"
            };

            _selectedArticlePrice = DbConnection.getValue(mySqlCommand);
            articlePriceLbl.Text = _selectedArticlePrice.ToString();
        }

        private bool checkAvailability(int quantity, int availablePackages)
        {
            return quantity <= availablePackages ? true : false;
        }
        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            if (insertedArticlesDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyDGVMsg);
                return;
            }

            DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da želite da otkupite ove artikle?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "INSERT INTO `packaging_records` (`fk_client_id`, `type`) VALUES (@clientId, @type); SELECT LAST_INSERT_ID();"
            };
            mySqlCommand.Parameters.AddWithValue("@clientId", _selectedClientId);
            mySqlCommand.Parameters.AddWithValue("@type", 1);

            int packagingRecordsId = Convert.ToInt32(DbConnection.getValue(mySqlCommand));

            mySqlCommand.Parameters.Clear();

            mySqlCommand.CommandText = "INSERT INTO `packaging_record_items` (`fk_packaging_records_id`, `fk_packaging_id`, `quantity`, `ownership`) VALUES (@packagingRecordsId, @packagingId, @packagingQuantity, @packagingOwnership);";

            decimal totalPrice = 0;
            foreach (DataGridViewRow row in insertedArticlesDataGridView.Rows)
            {         
                int packagingId = Convert.ToInt32(row.Cells["packagingId"].Value);
                int packagingQuantity = Convert.ToInt32(row.Cells["packagingQuantity"].Value);
                string packagingOwnership = row.Cells["packagingOwnership"].Value.ToString();

                mySqlCommand.Parameters.AddWithValue("@packagingRecordsId", packagingRecordsId);
                mySqlCommand.Parameters.AddWithValue("@packagingId", packagingId);
                mySqlCommand.Parameters.AddWithValue("@packagingQuantity", packagingQuantity);
                mySqlCommand.Parameters.AddWithValue("@packagingOwnership", packagingOwnership);

                DbConnection.executeQuery(mySqlCommand);

                mySqlCommand.Parameters.Clear();

                // Get article prices here to save memory after
                decimal articlePrice = Convert.ToDecimal(row.Cells["articlePrice"].Value);
                totalPrice += articlePrice;
            }


            mySqlCommand.CommandText = "SELECT `receipt_number` FROM `receipts` ORDER BY `id_receipt` DESC LIMIT 1";

            int? receiptNumber = Convert.ToInt32(DbConnection.getValue(mySqlCommand));

            if (receiptNumber == null)
            {
                receiptNumber = 0;
            }
            receiptNumber += 1;

            mySqlCommand.CommandText = "INSERT INTO `receipts` (`fk_client_id`, `receipt_number`, `total_price`) VALUES (@clientId, @receiptNumber, @totalPrice); SELECT LAST_INSERT_ID()";
            mySqlCommand.Parameters.AddWithValue("@clientId", _selectedClientId);
            mySqlCommand.Parameters.AddWithValue("@receiptNumber", receiptNumber);
            mySqlCommand.Parameters.AddWithValue("@totalPrice", totalPrice);

            int receiptId = Convert.ToInt32(DbConnection.getValue(mySqlCommand));

            mySqlCommand.Parameters.Clear();

            mySqlCommand.CommandText = "INSERT INTO `items_receipt` (`fk_receipt_id`, `fk_article_id`, `quantity`, `price`) VALUES (@receiptId, @articleId, @articleQuantity, @articlePrice)";

            foreach (DataGridViewRow row in insertedArticlesDataGridView.Rows)
            { 
                decimal articleId = Convert.ToInt32(row.Cells["articleId"].Value);
                decimal articleQuantity = Convert.ToDecimal(row.Cells["articleQuantity"].Value);
                decimal articlePrice = Convert.ToDecimal(row.Cells["articlePrice"].Value);

                mySqlCommand.Parameters.AddWithValue("@receiptId", receiptId);
                mySqlCommand.Parameters.AddWithValue("@articleId", articleId);
                mySqlCommand.Parameters.AddWithValue("@articleQuantity", articleQuantity);
                mySqlCommand.Parameters.AddWithValue("@articlePrice", articlePrice);

                DbConnection.executeQuery(mySqlCommand);

                mySqlCommand.Parameters.Clear();
            }

            insertedArticlesDataGridView.Rows.Clear();

            result = CustomDialog.ShowDialog(this, "Da li želite da iznajmite nove ambalaže ovom klijentu?");
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                using RentPackagesForm rentPackagesForm = new RentPackagesForm(_selectedClientId);
                rentPackagesForm.ShowDialog(this);
            }

            Close();
          
        }

        private void insertedArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ovaj artikal iz unosa?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }

                DataGridViewRow _selectedRow = insertedArticlesDataGridView.CurrentRow;
                insertedArticlesDataGridView.Rows.Remove(_selectedRow);
            }
        }

        private void cratesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cratesCmbBox.SelectedIndex == 0)
            {
                return;
            }
          
            _packagingId = (cratesCmbBox.SelectedItem as ComboBoxItem).Value;

            if (crateOwnerCmbBox.SelectedIndex == 0)
            {
                getPackagingDebtQuantity();
            }
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = $"SELECT `weight` FROM `packaging` WHERE `id_packaging` = @packagingId"
            };

            mySqlCommand.Parameters.AddWithValue("@packagingId", _packagingId);
            _packagingWeight = Convert.ToDecimal(DbConnection.getValue(mySqlCommand)) / 1000;
        }

        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getArticlePrice();
        }

        private void palletCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                palletWeightLbl.Enabled = true;
                palletWeightTxtBox.Enabled = true;

                numberOfPalletsLbl.Enabled = true;
                numberOfPalletsTxtBox.Enabled = true;
            } else
            {
                palletWeightLbl.Enabled = false;
                palletWeightTxtBox.Enabled = false;

                numberOfPalletsLbl.Enabled = false;
                numberOfPalletsTxtBox.Enabled = false;
            }
        }
    }
}
