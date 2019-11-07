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
        public PurchaseArticles pArticles = new PurchaseArticles();
        public InsertForm(int clientId)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        //    DbConnection.fillCustomCmbBox(articlesCmbBox, "articles", "id_article","article_name", "sort", "organic");
          //  crateOwnerCmbBox.SelectedIndex = 0;
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

     

        private void onChangeArticle(object sender, EventArgs e)
        {
            DbConnection.fillCmbBox(categoryCmbBox, "categories", "id_category", "category_name");
            categoryCmbBox.Enabled = true;
        }

        private void onChangeOwener(object sender, EventArgs e)
        {
            int owneryIndex = crateOwnerCmbBox.SelectedIndex;
            if(owneryIndex == 1)
            {
                packageTypeCmbBox.Visible = true;
                crateTypeLbl.Visible = true;
                crateQuantityTxtBox.Visible = true;
                crateQuantityLbl.Visible = true;
            }
          
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            int articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;


            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "SELECT article_name, sort, organic FROM articles WHERE id_article =" + articleId 
            };

            dynamic arts = DbConnection.getQueryValues(mySqlCommand);
            var chars = new char[1];
            chars[0] = ',';
            string[] articles = arts.Split(chars);


            MySqlCommand mySqlCommand1 = new MySqlCommand
            {
                CommandText = "SELECT category_name FROM categories WHERE id_category =" + ((ComboBoxItem)categoryCmbBox.SelectedItem).Value
            };

            dynamic category = DbConnection.getValue(mySqlCommand1);

            //Article art = new Article(
            //    articleId,
            //    articles[0],
            //    articles[1],
            //   ((ComboBoxItem)categoryCmbBox.SelectedItem).Value,
            //   articles[2],
            //   Decimal.Parse(priceTxtBox.Text)         
            //);

            string owener = crateOwnerCmbBox.Text;
            string packageId = null;
            string packagedNumber = null;
            if(owener == "1")
            {
                packageId = ((ComboBoxItem)packageTypeCmbBox.SelectedItem).Value.ToString();
                packagedNumber = crateQuantityTxtBox.Text;
            }

            //Item item = new Item(
            //    art,
            //    Convert.ToInt32(quantityTxtBox.Text),
            //    owener,
            //    packageId,
            //    packagedNumber,
            //    category
            //);

            //pArticles.setArticle(item);
            clearAllText();
            // refresh richTextBox
            
            for (int i =0; i < pArticles.articles.Count; i++)
            {
                Article article = pArticles.articles[i]._art;
              //  articlesDataGridView.Rows.Add(article._id, article._fkCategoryId, article._fkCategoryId, article._name, article._sort, pArticles.articles[i]._category, article._organic, article._price);
            }

        }

        public void clearAllText()
        {
            ((ComboBoxItem)articlesCmbBox.SelectedItem).Value = 0;
            ((ComboBoxItem)categoryCmbBox.SelectedItem).Value = 0;
            priceTxtBox.Text = "";
            crateOwnerCmbBox.Text  = "";
            packageTypeCmbBox.Text = "";
            crateQuantityTxtBox.Text = "";
        }
    }
}
