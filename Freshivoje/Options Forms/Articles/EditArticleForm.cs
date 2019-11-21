using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;

namespace Freshivoje.Custom_Forms
{
    public partial class EditArticleForm : Form
    {
        private readonly int _articleId;
        private readonly string _articleCategory;
        public EditArticleForm(Article article)
        {
            InitializeComponent();
            _articleId = article._id;
            articleNameTxtBox.Text = article._name;
            articleSortTxtBox.Text = article._sort;
            articleCategoryTxtBox.Text = article._category;
            articleOrganicCmbBox.SelectedIndex = article._organic == "Da" ? 0 : 1;
            fillPrice();
            fillDGV();
        }

        private void fillDGV()
        {
            // ORDER BY ID jer kolona `date` ne hvata sate pri sortiranju
            string _fillDGVquery = @$"SELECT `prices`.`id_price`, `value`,  DATE_FORMAT(`date`, '%d.%m.%Y') as `date`, `status` FROM `prices` 
                                    JOIN `articles` ON `prices`.`fk_article_id` = `articles`.`id_article`
                                    WHERE `fk_article_id` = {_articleId}
                                    ORDER BY `prices`.`id_price` DESC";
            DbConnection.fillDGV(articlePricesDataGridView, _fillDGVquery);
        }

        private void fillPrice()
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = @$"SELECT `value` FROM `prices` 
                                JOIN `articles` ON `prices`.`fk_article_id` = `articles`.`id_article` 
                                WHERE `fk_article_id` = {_articleId} AND `status` = 'aktivna'"
            };
            decimal price = Convert.ToDecimal(DbConnection.getValue(mySqlCommand));
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

        private void updatePriceBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articlePriceTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da \nunesete novu cenu za ovaj artikal?\n\nNova cena: {articlePriceTxtBox.Text} RSD");

            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = @$"SELECT `value` FROM `prices` 
                                JOIN `articles` ON `prices`.`fk_article_id` = `articles`.`id_article` 
                                WHERE `fk_article_id` = @fkArticleId AND `status` = 'aktivna'"
            };

            mySqlCommand.Parameters.AddWithValue("@fkArticleId", _articleId);

            decimal lastPrice = Convert.ToDecimal(DbConnection.getValue(mySqlCommand));

            if (lastPrice == (Convert.ToDecimal(articlePriceTxtBox.Text)))
            {
                CustomMessageBox.ShowDialog(this, $"Cena {lastPrice.ToString()} RSD je već aktivna!");
                return;
            }
           
            mySqlCommand.CommandText = "UPDATE `prices` SET `status` = 'neaktivna' WHERE `fk_article_id` = @fkArticleId";

            DbConnection.executeQuery(mySqlCommand);

            mySqlCommand.CommandText = "INSERT INTO `prices` (`value`, `fk_article_id`) VALUES (@articlePrice, @fkArticleId)";
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
