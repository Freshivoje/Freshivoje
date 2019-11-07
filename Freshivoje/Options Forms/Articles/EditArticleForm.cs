using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;

namespace Freshivoje.Custom_Forms
{
    public partial class EditArticleForm : Form
    {
        private int _articleId;
        public EditArticleForm(Article article)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _articleId = article._id;
            articleNameTxtBox.Text = article._name;
            articleSortTxtBox.Text = article._sort;
            articleOrganicCmbBox.SelectedIndex = article._organic == "Da" ? 0 : 1;
            articleCategoryCmbBox.SelectedIndex = 0;
            fillPrice();
            fillDGV();
        }

        private void fillDGV()
        {
            string _fillDGVquery = $"SELECT * FROM prices WHERE `fk_article_id` = {_articleId} AND `fk_category_id` = {articleCategoryCmbBox.SelectedIndex + 1} ORDER BY `date` DESC";
            DbConnection.fillDGV(articlePricesDataGridView, _fillDGVquery);
        }

        private void fillPrice()
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = $"SELECT `value` FROM `prices` WHERE `fk_article_id` = {_articleId} AND `fk_category_id` = {articleCategoryCmbBox.SelectedIndex + 1} AND `status` = 'aktivna'"
            };
            decimal price = DbConnection.getValue(mySqlCommand);
            articlePriceTxtBox.Text = price.ToString();
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articleNameTxtBox.Text) || string.IsNullOrWhiteSpace(articleSortTxtBox.Text)
               || string.IsNullOrWhiteSpace(articlePriceTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }
            
            Article article = new Article(_articleId, articleNameTxtBox.Text, articleSortTxtBox.Text, articleOrganicCmbBox.Text);

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da izmenite artikal\nIme: {article._name}\nSorta: {article._sort}\nKontrolisana proizvodnja: {article._organic}");

            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "UPDATE `articles` SET `article_name` = @articleName, `sort` = @articleSort, `organic` = @articleOrganic WHERE `id_article` = @articleId"
            };
            mySqlCommand.Parameters.AddWithValue("@articleName", article._name);
            mySqlCommand.Parameters.AddWithValue("@articleSort", article._sort);
            mySqlCommand.Parameters.AddWithValue("@articleOrganic", article._organic);

            mySqlCommand.Parameters.AddWithValue("@articleId", article._id);

            DbConnection.executeQuery(mySqlCommand);
       
            mySqlCommand.CommandText = $"SELECT `value` FROM `prices` WHERE `fk_article_id` = {_articleId} AND `status` = 'aktivna' AND fk_category_id = {articleCategoryCmbBox.SelectedIndex + 1}";
            decimal lastPrice = DbConnection.getValue(mySqlCommand);

            if (lastPrice == (Convert.ToDecimal(articlePriceTxtBox.Text)))
            {
                //CustomMessageBox.ShowDialog(this, $"Cena {articleCategoryCmbBox.Text} klase {articlePriceTxtBox.Text} RSD za ovaj artikal je već aktivna.");
                return;
            }
           
            mySqlCommand.CommandText = "UPDATE `prices` SET `status` = 'neaktivna' WHERE `fk_article_id` = @articleId AND `fk_category_id` = @fkCategoryId";
            mySqlCommand.Parameters.AddWithValue("@fkCategoryId", articleCategoryCmbBox.SelectedIndex + 1);

            DbConnection.executeQuery(mySqlCommand);

            mySqlCommand.CommandText = "INSERT INTO `prices` (`value`, `fk_article_id`, `fk_category_id`) VALUES (@articlePrice, @articleId, @fkCategoryId)";
            mySqlCommand.Parameters.AddWithValue("@articlePrice", articlePriceTxtBox.Text);
            DbConnection.executeQuery(mySqlCommand);
            
            fillDGV();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void articleCategoryCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPrice();
            fillDGV();
        }
    }
}
