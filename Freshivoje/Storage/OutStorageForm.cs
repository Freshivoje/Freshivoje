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
    public partial class OutStorageForm : Form
    {
        public Dictionary<Int32, Decimal> MapOfArticles = new Dictionary<int, decimal>();
        public Dictionary<Int32, Decimal> MapOfArticles1 = new Dictionary<int, decimal>();
        public Dictionary<Int32, Decimal> MapOfArticles2 = new Dictionary<int, decimal>();
        int _articleId;
        int _storageId;
        bool state1;
        public OutStorageForm(int storageId)
        {
            _storageId = storageId;
            state1 = true;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            string _fillLbl = $"SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = {_storageId} AND storage_record_items.status = 'neaktivna') as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = {_storageId} AND storage_record_items.status = 'aktivna'";
            string _fillCmbBox = $"SELECT articles.id_article, articles.article_name, articles.sort, articles.organic, articles.category FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} GROUP BY articles.id_article;";
            lblTitle.Text = "UNOS ARTIKALA U KOMORU " + storageData.getName();
            DbConnection.FillCmbBoxQuery(articlesCmbBox, _fillCmbBox, "id_article", "article_name", "sort", "organic", "category");
            DbConnection.Storage(freeStorageLbl, _fillLbl, "StorageArticleQuantity", "article_quantity");
            articlesCmbBox.SelectedIndex = 0;
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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            decimal freeStorage = Convert.ToDecimal(freeStorageLbl.Text);
            decimal articleStorageQuantity = Convert.ToDecimal(articleLbl.Text);
            decimal articleQuantity = Convert.ToDecimal(articleQuantityTxtBox.Text);


            if (string.IsNullOrWhiteSpace(articleQuantityLbl.Text) || articlesCmbBox.SelectedIndex < 1 || articleStorageQuantity - articleQuantity < 0)
            {
                CustomMessageBox.ShowDialog(this, "Količina koju ste uneli nije validna !");
                return;
            }
       
            decimal sum, suma;
            if (freeStorage > articleQuantity)
            {
                int articleId = (articlesCmbBox.SelectedItem as ComboBoxItem).Value;
                string[] articleFields = articlesCmbBox.Text.Split('/');
                Article article = new Article(articleId, articleFields[0], articleFields[1], articleFields[2], articleFields[3], 0, 0, 0, articleQuantity);

                foreach (DataGridViewRow row in ArticlesDataGridView.Rows)
                {

                    if (Convert.ToInt32(row.Cells["articleId"].Value) == article._id)
                    {
                        decimal sumQuantity = Convert.ToDecimal(row.Cells["articleQuantity"].Value) + article._quantity;
                        row.Cells["articleQuantity"].Value = sumQuantity;
                        sum = freeStorage - sumQuantity;
                        suma = articleStorageQuantity - article._quantity;


                        articlesCmbBox.SelectedItem = 0;
                        MapOfArticles2 = MapOfArticles;

                        foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                        {

                            if (item.Key == article._id)
                            {
                                MapOfArticles1[item.Key] = suma;
                            }

                        }
                        foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                        {
                            foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticles1)
                            {
                                if (item.Key == item1.Key)
                                {
                                    int key = item.Key;
                                    decimal value = MapOfArticles1[item1.Key];
                                    MapOfArticles2[key] = value;
                                    MapOfArticles = MapOfArticles2;
                                    freeStorageLbl.Text = sum.ToString();
                                    articleLbl.Text = suma.ToString();
                                    articleQuantityTxtBox.ResetText();
                                    return;
                                }

                            }
                        }


                    }
                }
                MapOfArticles2 = MapOfArticles;
                suma = articleStorageQuantity - article._quantity;
                foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                {

                    if (item.Key == article._id)
                    {
                        MapOfArticles1[item.Key] = suma;
                    }

                }
                foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                {
                    foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticles1)
                    {
                        if (item.Key == article._id)
                        {
                            int key = item.Key;
                            decimal value = MapOfArticles1[item1.Key];
                            MapOfArticles2[key] = value;
                            MapOfArticles = MapOfArticles2;
                            articleLbl.Text = value.ToString();
                            ArticlesDataGridView.Rows.Add(article._id, article._name, article._sort, article._category, article._organic, articleQuantity);
                            articleQuantityTxtBox.ResetText();
                            return;
                        }

                    }
                }
                ArticlesDataGridView.Rows.Add(article._id, article._name, article._sort, article._category, article._organic, article._quantity);
                state1 = false;
                sum = freeStorage - article._quantity;
                suma = articleStorageQuantity - articleQuantity;
                MapOfArticles.Add(article._id, suma);
                freeStorageLbl.Text = sum.ToString();
                articleLbl.Text = suma.ToString();
                articleQuantityTxtBox.ResetText();
                articlesCmbBox.SelectedItem = 0;
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

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            if (ArticlesDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, "Niste uneli nijedan artikl");
                return;
            }
            DialogResult result = CustomDialog.ShowDialog(this, "Da li ste sigurni da želite da prodate ove artikle ?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }


            foreach (DataGridViewRow row in ArticlesDataGridView.Rows)
            {
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    CommandText = $"INSERT INTO `storage_record_items` (`fk_storage_id`, `fk_article_id`,  `article_quantity`, `date`, `type_of_storage_action`, `status`) VALUES ( 8, @articleId, @articleQuantity, current_timestamp(), 'ulaz', 'neaktivna');"
                };
      
                mySqlCommand.Parameters.AddWithValue("@articleId", row.Cells["articleId"].Value);
                mySqlCommand.Parameters.AddWithValue("@articleQuantity", row.Cells["articleQuantity"].Value);
              
                DbConnection.executeQuery(mySqlCommand);

            }

            ArticlesDataGridView.Rows.Clear();
            Close();
        }

        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articlesCmbBox.SelectedIndex < 1)
            {
                articleLbl.Text = string.Empty;
                return;
            }
            _articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;
            if (ArticlesDataGridView.RowCount == 0)
            {
                string _artilceQuantity = $"SELECT articles.id_article as QuantityArticleId, SUM(`storage_record_items`.`article_quantity`) as QuantityArts FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} AND articles.id_article = {_articleId} GROUP BY articles.id_article";
                DbConnection.fillLbl(articleLbl, _artilceQuantity, "", "QuantityArticleId", "QuantityArts", "QuantityStorageArticleId", "QuantityStorageArticle");

            }
            foreach (DataGridViewRow row in ArticlesDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["articleId"].Value) == _articleId)
                {
                    foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                    {
                        if (item.Key == _articleId)
                        {
                            articleLbl.Text = MapOfArticles[item.Key].ToString();
                            return;
                        }
                    }

                }

            }
            foreach (DataGridViewRow row in ArticlesDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["articleId"].Value) != _articleId)
                {
                    string _artilceQuantity = $"SELECT articles.id_article, articles.article_name, articles.sort, articles.organic, articles.category FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} AND articles.id_article = {_articleId} GROUP BY articles.id_article";  
                    DbConnection.fillLbl(articleLbl, _artilceQuantity, "", "QuantityArticleId", "QuantityArts", "QuantityStorageArticleId", "QuantityStorageArticle");

                }

            }
        }

        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                decimal sum, suma;
                decimal freeStorage = Convert.ToDecimal(freeStorageLbl.Text);
                decimal articleStorageQuantity = Convert.ToDecimal(articleLbl.Text);
                DataGridViewRow _selectedRow = ArticlesDataGridView.CurrentRow;
                decimal sumsa = Convert.ToDecimal(_selectedRow.Cells["articleQuantity"].Value);
                int _selectedArticleId = Convert.ToInt32(_selectedRow.Cells["articleId"].Value);

                if ((articlesCmbBox.SelectedItem as ComboBoxItem).Value == _selectedArticleId)
                {
                    DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ovaj artikal iz unosa?");
                    if (result == DialogResult.No || result == DialogResult.Cancel)
                    {
                        return;
                    }

                    sumsa = Convert.ToDecimal(_selectedRow.Cells["articleQuantity"].Value);
                    sum = freeStorage + sumsa;
                    MapOfArticles2 = MapOfArticles;
                    foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                    {
                        if (item.Key == _selectedArticleId)
                        {
                            suma = articleStorageQuantity + sumsa;
                            MapOfArticles1[item.Key] = suma;
                        }

                    }
                    foreach (KeyValuePair<Int32, Decimal> item in MapOfArticles)
                    {
                        foreach (KeyValuePair<Int32, Decimal> item1 in MapOfArticles1)
                        {
                            if (item.Key == _selectedArticleId)
                            {
                                int key = item.Key;
                                decimal value = MapOfArticles1[item.Key];
                                MapOfArticles2[key] = value;
                                MapOfArticles = MapOfArticles2;

                                freeStorageLbl.Text = sum.ToString();
                                articleLbl.Text = value.ToString();
                                articleQuantityTxtBox.ResetText();
                                ArticlesDataGridView.Rows.Remove(_selectedRow);
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
