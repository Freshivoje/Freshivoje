using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshivoje.Models;

namespace Freshivoje.Custom_Forms
{
    public partial class CreateArticleForm : Form
    {
        public CreateArticleForm()
        {
            InitializeComponent();
          
            articleOrganicCmbBox.SelectedIndex = 0;
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

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articleNameTxtBox.Text) || string.IsNullOrWhiteSpace(articleSortTxtBox.Text)
                || string.IsNullOrWhiteSpace(articlePriceITxtBox.Text) || string.IsNullOrWhiteSpace(articleOrganicCmbBox.Text)
                || string.IsNullOrWhiteSpace(articlePriceIITxtBox.Text) || string.IsNullOrWhiteSpace(articlePriceIIITxtBox.Text) 
                )
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            Article article = new Article(0, articleNameTxtBox.Text, articleSortTxtBox.Text,  articleOrganicCmbBox.Text, Convert.ToDecimal(articlePriceITxtBox.Text), Convert.ToDecimal(articlePriceIITxtBox.Text), Convert.ToDecimal(articlePriceIIITxtBox.Text));

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da kreirate artikal\nIme: {article._name}\nSorta: {article._sort}\nKontrolisana proizvodnja: {article._organic}\nCena I klase: {article._priceI} RSD\nCena II klase: {article._priceII} RSD\nCena III klase: {article._priceIII} RSD\n");
             if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }


            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "INSERT INTO `articles` (`article_name`, `sort`, `organic`) VALUES (@articleName, @articleSort, @articleOrganic); SELECT LAST_INSERT_ID()"
            };
            mySqlCommand.Parameters.AddWithValue("@articleName", article._name);
            mySqlCommand.Parameters.AddWithValue("@articleSort", article._sort);
            mySqlCommand.Parameters.AddWithValue("@articleOrganic", article._organic);
            

            int articleId = (int) DbConnection.getValue(mySqlCommand);
            article.setId(articleId);
         
            if (article._id < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.errorMsg);
                return;
            }

            mySqlCommand.CommandText = @"INSERT INTO `prices` (`value`, `fk_article_id`, `fk_category_id`) VALUES (@articlePriceI, @insertedArticleId, @categoryIdI);
                                         INSERT INTO `prices` (`value`, `fk_article_id`, `fk_category_id`) VALUES (@articlePriceII, @insertedArticleId, @categoryIdII);
                                         INSERT INTO `prices` (`value`, `fk_article_id`, `fk_category_id`) VALUES (@articlePriceIII, @insertedArticleId, @categoryIdIII);";

            mySqlCommand.Parameters.AddWithValue("@insertedArticleId", article._id);

            mySqlCommand.Parameters.AddWithValue("@articlePriceI", article._priceI);
            mySqlCommand.Parameters.AddWithValue("@categoryIdI", 1);

            mySqlCommand.Parameters.AddWithValue("@articlePriceII", article._priceII);
            mySqlCommand.Parameters.AddWithValue("@categoryIdII", 2);

            mySqlCommand.Parameters.AddWithValue("@articlePriceIII", article._priceIII);
            mySqlCommand.Parameters.AddWithValue("@categoryIdIII", 3);

            DbConnection.executeQuery(mySqlCommand);

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
