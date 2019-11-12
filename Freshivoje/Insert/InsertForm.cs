using System;
using System.IO;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Freshivoje.Models;
using Freshivoje.Custom_Forms;

namespace Freshivoje
{
    public partial class InsertForm : Form
    {
        private int _articleId, _articleCategoryId, _packagingId;
        decimal _palletWeight = 1M, _packagingWeight;
        public InsertForm(int clientId)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;  
            DbConnection.fillCmbBox(articlesCmbBox, "articles", "id_article", "article_name", "sort", "organic");
            DbConnection.fillCmbBox(cratesCmbBox, "packaging", "id_packaging", "capacity", "category", "weight", "producer");

            palletCmbBox.SelectedIndex = 1;
            articleCategoryCmbBox.SelectedIndex = 0;
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

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            //Document doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream("D:/CreatePdf.pdf", FileMode.Create));
            //doc.Open();
            //Paragraph p1 = new Paragraph("FAKTURA ZA IZADAVANJE!");
            //doc.Add(p1);
            //doc.Close();
            //MessageBox.Show("PDF JE NAPRAVLJEN!");
        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
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

            int brutoWeight = Convert.ToInt32(articleQuantityTxtBox.Text);
            decimal articlePrice = Convert.ToDecimal(articlePriceLbl.Text);

            decimal crateWeight = _packagingWeight;
            int numOfCrates = Convert.ToInt32(crateQuantityTxtBox.Text);

            decimal nonArticleWeight = crateWeight * numOfCrates + _palletWeight;

            decimal netoWeight = brutoWeight - nonArticleWeight;

            decimal price = Math.Round(netoWeight * articlePrice, 2);
            
            string[] articleFields = articlesCmbBox.Text.Split('/');
            string articleCategory = articleCategoryCmbBox.Text;

            insertedArticlesDataGridView.Rows.Add(articleFields[0], articleFields[1], articleFields[2], articleCategory, price);
        }

        public void getArticlePrice()
        {
            if(articlesCmbBox.SelectedIndex < 0)
            {
                return;
            }
            _articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;
            _articleCategoryId = articleCategoryCmbBox.SelectedIndex + 1;
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = $"SELECT `value` FROM `prices` WHERE `fk_article_id` = {_articleId} AND `status` = 'aktivna' AND fk_category_id = {_articleCategoryId}"
            };

            decimal lastPrice = DbConnection.getValue(mySqlCommand);
            articlePriceLbl.Text = lastPrice.ToString();
        }

        private void cratesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _packagingId = (cratesCmbBox.SelectedItem as ComboBoxItem).Value;
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = $"SELECT `weight` FROM `packaging` WHERE `id_packaging` = {_packagingId}"
            };
            _packagingWeight = (decimal) DbConnection.getValue(mySqlCommand) / 1000;
        }

        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getArticlePrice();
        }

        private void palletCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox).SelectedIndex == 0)
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
