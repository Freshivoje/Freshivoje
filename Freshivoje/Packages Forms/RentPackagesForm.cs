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

        public RentPackagesForm(int clientId)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            rentedPackagesDataGridView.AutoGenerateColumns = false;

            _selectedClientId = clientId;
            
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

        private void insertBtn_Click(object sender, EventArgs e)
        {



            int packagingId = (cratesCmbBox.SelectedItem as ComboBoxItem).Value;
            string[] packagingFields = cratesCmbBox.Text.Split('/');
            int packagingQuantity = Convert.ToInt32(crateQuantityTxtBox.Text);
            decimal packagingPrice = Convert.ToDecimal(price.Text);

            Package package = new Package(packagingId, Convert.ToInt32(packagingFields[0]), packagingPrice, packagingFields[1], packagingQuantity, Convert.ToInt32(packagingFields[2]), packagingFields[3], packagingFields[4]);

            //Article article = new Article(_articleId, articleFields[0], articleFields[1], articleFields[2], price);

            //DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da unesete artikal?\n{articlesCmbBox.Text}\nKlasa: {articleCategory}\nNeto kilaža: {netoWeight.ToString("0.00")}\nCena: {article._priceI} RSD");
            //if (result == DialogResult.No || result == DialogResult.Cancel)
            //{
            //    return;
            //}

            rentedPackagesDataGridView.Rows.Add(package._id, package._capacity, package._category, package._weight, package._producer, package._state, package._quantity, package._price);

            //crateQuantityTxtBox.ResetText();
            //articleQuantityTxtBox.ResetText();
            //crateQuantityTxtBox.Select();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            //if (rentedPackagesDataGridView.Rows.Count < 1)
            //{
            //    CustomMessageBox.ShowDialog(this, Properties.Resources.emptyDGVMsg);
            //    return;
            //}

            //DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da želite da unesete ove artikle u magacin?");
            //if (result == DialogResult.No || result == DialogResult.Cancel)
            //{
            //    return;
            //}

            //MySqlCommand mySqlCommand = new MySqlCommand
            //{
            //    CommandText = "INSERT INTO `packaging_records` (`fk_packaging_id`, `fk_client_id`, `packaging_ownership`, `packaging_record_quantity`) VALUES (@packagingId, @clientId, @packagingOwnership, @packagingQuantity)"
            //};

            //MySqlCommand mySqlCommand1 = new MySqlCommand
            //{
            //     CommandText = "SELECT `receipt_number` FROM `receipts` ORDER BY `id_receipt` DESC LIMIT 1"
            //};

            //int? receiptNumber = Convert.ToInt32(DbConnection.getValue(mySqlCommand1));

            //if (receiptNumber == null)
            //{
            //    receiptNumber = 0;
            //}
            //receiptNumber += 1;

            //mySqlCommand1.CommandText = "INSERT INTO `receipts` (`fk_client_id`, `receipt_number`) VALUES (@clientId, @receiptNumber); SELECT LAST_INSERT_ID()";

            //mySqlCommand1.Parameters.AddWithValue("@clientId", _selectedClientId);
            //mySqlCommand1.Parameters.AddWithValue("@receiptNumber", receiptNumber);

            //int receiptId = Convert.ToInt32(DbConnection.getValue(mySqlCommand1));

            //mySqlCommand1.Parameters.Clear();

            //mySqlCommand1.CommandText = "INSERT INTO `items_receipt` (`fk_receipt_id`, `fk_article_id`, `quantity`, `price`) VALUES (@receiptId, @articleId, @articleQuantity, @articlePrice)";

            //decimal totalPrice = 0;

            //foreach (DataGridViewRow row in rentedPackagesDataGridView.Rows)
            //{ 
            //    int packagingId = Convert.ToInt32(row.Cells["packagingId"].Value);
            //    int packagingQuantity = Convert.ToInt32(row.Cells["packagingQuantity"].Value);
            //    string packagingOwnership = row.Cells["packagingOwnership"].Value.ToString();


            //    mySqlCommand.Parameters.AddWithValue("@packagingId", packagingId);
            //    mySqlCommand.Parameters.AddWithValue("@clientId", _selectedClientId);
            //    mySqlCommand.Parameters.AddWithValue("@packagingOwnership", packagingOwnership);
            //    mySqlCommand.Parameters.AddWithValue("@packagingQuantity", packagingQuantity);

            //    DbConnection.executeQuery(mySqlCommand);

            //    mySqlCommand.Parameters.Clear();

            //    decimal articleId = Convert.ToInt32(row.Cells["articleId"].Value);
            //    decimal articleQuantity = Convert.ToDecimal(row.Cells["articleQuantity"].Value);
            //    decimal articlePrice = Convert.ToDecimal(row.Cells["articlePrice"].Value);

            //    totalPrice += articlePrice;

            //    mySqlCommand1.Parameters.AddWithValue("@receiptId", receiptId);
            //    mySqlCommand1.Parameters.AddWithValue("@articleId", articleId);
            //    mySqlCommand1.Parameters.AddWithValue("@articleQuantity", articleQuantity);
            //    mySqlCommand1.Parameters.AddWithValue("@articlePrice", articlePrice);

            //    DbConnection.executeQuery(mySqlCommand1);

            //    mySqlCommand1.Parameters.Clear();
            //}
            
            //mySqlCommand1.CommandText = "UPDATE `receipts` SET `total_price` = @totalPrice WHERE `id_receipt` = @receiptId";
            //mySqlCommand1.Parameters.AddWithValue("@totalPrice", totalPrice);
            //mySqlCommand1.Parameters.AddWithValue("@receiptId", receiptId);

            //DbConnection.executeQuery(mySqlCommand1);

            //rentedPackagesDataGridView.Rows.Clear();
        }

        private void insertedArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 10)
            //{
            //    //_selectedArticleName = insertedArticlesDataGridView.Rows[e.RowIndex].Cells["articleName"].Value.ToString();
            //    //_selectedArticleSort = insertedArticlesDataGridView.Rows[e.RowIndex].Cells["articleSort"].Value.ToString();
            //    //_selectedArticleOrganic = insertedArticlesDataGridView.Rows[e.RowIndex].Cells["articleOrganic"].Value.ToString();
            //    //_selectedArticleCategory = insertedArticlesDataGridView.Rows[e.RowIndex].Cells["articleCategory"].Value.ToString();
            //    //_selectedArticlePrice = Convert.ToDecimal(insertedArticlesDataGridView.Rows[e.RowIndex].Cells["articlePrice"].Value);

            //    DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ovaj artikal iz unosa?"); //\n{_selectedArticleName}/{_selectedArticleSort}/{_selectedArticleOrganic}\nKlasa: {_selectedArticleCategory}\nCena: {_selectedArticlePrice}");
            //    if (result == DialogResult.No || result == DialogResult.Cancel)
            //    {
            //        return;
            //    }

            //    DataGridViewRow _selectedRow = rentedPackagesDataGridView.CurrentRow;
            //    rentedPackagesDataGridView.Rows.Remove(_selectedRow);
            //}
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
    }
}
