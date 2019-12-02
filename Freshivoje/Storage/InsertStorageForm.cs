using Freshivoje.Custom_Forms;
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
using Freshivoje.Models;

namespace Freshivoje.Storage
{
    public partial class InsertStorageForm : Form
    {
        public List<Article> articles = new List<Article>();
        int _articleId;
        int storageId;
        string _fillCmbBox = "SELECT `articles`.`id_article`, `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON `articles`.`id_article` = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() GROUP BY `articles`.`id_article`;";
        //string _fillCmbBox1 = "SELECT `packaging`.`id_packaging` , `packaging`.`capacity`, `packaging`.`category`, `packaging`.`state`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() GROUP BY `packaging`.`id_packaging`;";
        string _fillLbl = "SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) as StorageArticleQuantity, COALESCE(SUM(storage_record_items.package_quantity), 0) as StoragePackagingQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 1";
        
        public InsertStorageForm(int _storageId)
        {
            InitializeComponent();
            storageId = _storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            WindowState = FormWindowState.Maximized;
            DbConnection.FillCmbBoxQuery(articlesCmbBox, _fillCmbBox, "id_article", "article_name", "sort", "organic", "category");
            // DbConnection.FillCmbBoxQuery(packagingCmbBox, _fillCmbBox1, "id_packaging", "capacity", "category", "state");
            string _fillLbl = $"SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) as StorageArticleQuantity, COALESCE(SUM(storage_record_items.package_quantity), 0) as StoragePackagingQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = {storageId}";
            lblTitle.Text = "UNOS ARTIKALA U KOMORU " + storageData.getName();
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
            if (string.IsNullOrWhiteSpace(articleQuantityLbl.Text) || articlesCmbBox.SelectedIndex < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }
            decimal freeStorage = Convert.ToDecimal(freeStorageLbl.Text);
            decimal articleStorageQuantity = Convert.ToDecimal(articleLbl.Text);
            decimal articleQuantity = Convert.ToDecimal(articleQuantityTxtBox.Text);
            decimal sum, suma;
            if (freeStorage > articleQuantity && articleStorageQuantity > articleQuantity)
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
                        suma = articleStorageQuantity - sumQuantity;
                        freeStorageLbl.Text = sum.ToString();
                        articleLbl.Text = suma.ToString();
                        articleQuantityTxtBox.ResetText();
                        articlesCmbBox.SelectedItem = 0;
                        return;
                    }
                }
                ArticlesDataGridView.Rows.Add(article._id, article._name, article._sort, article._category, article._organic, article._quantity);
                sum = freeStorage - article._quantity;
                suma = articleStorageQuantity - article._quantity;
                freeStorageLbl.Text = sum.ToString();
                articleLbl.Text = suma.ToString();
                articleQuantityTxtBox.ResetText();
                articlesCmbBox.SelectedItem = 0;
            }
            else
            {
                CustomMessageBox.ShowDialog(this, "Sa količinom nešto nije uredu !!!");
                return;
            }
            
        }

       

       

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void packagingCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (packagingCmbBox.SelectedIndex < 1)
            //{
            //    packagingLbl.Text = string.Empty;
            //    return;
            //}
            //string _packagingQuantity = $"SELECT `packaging`.`id_packaging` as QuantityPackagingId, SUM(`packaging_record_items`.`quantity`) as `QuantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() AND `packaging`.`id_packaging` = {_packagingId} GROUP BY `packaging`.`id_packaging`";
            //string _packagingStorageQuantity = $"SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as QuantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`= 5 AND packaging.id_packaging = {_packagingId} GROUP BY packaging.id_packaging";
            //_packagingId = ((ComboBoxItem)packagingCmbBox.SelectedItem).Value;
            //DbConnection.fillLbl(packagingLbl, _packagingQuantity, _packagingStorageQuantity, "QuantityPackagingId", "QuantityPackg", "QuantityStoragePackagingId", "QuantityStoragePackaging");
        }

        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articlesCmbBox.SelectedIndex < 1)
            {
                articleLbl.Text = string.Empty;
                return;
            }
            _articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;
            string _artilceQuantity = $"SELECT articles.id_article as QuantityArticleId, SUM(`items_receipt`.`quantity`) as QuantityArts, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON articles.id_article = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() AND articles.id_article = {_articleId} GROUP BY `articles`.`id_article`";
            string _articleStorageQuantity = $"SELECT articles.id_article as QuantityStorageArticleId, SUM(`storage_record_items`.`article_quantity`) as QuantityStorageArticle, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`=5 AND articles.id_article = {_articleId} GROUP BY articles.id_article";
            DbConnection.fillLbl(articleLbl, _artilceQuantity, _articleStorageQuantity, "QuantityArticleId", "QuantityArts", "QuantityStorageArticleId", "QuantityStorageArticle");
        }

        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ovaj artikal iz unosa?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                decimal sum, suma;
                decimal freeStorage = Convert.ToDecimal(freeStorageLbl.Text);
                decimal articleStorageQuantity = Convert.ToDecimal(articleLbl.Text);
                DataGridViewRow _selectedRow = ArticlesDataGridView.CurrentRow;
                decimal sumsa = Convert.ToDecimal(_selectedRow.Cells["articleQuantity"].Value);
                ArticlesDataGridView.Rows.Remove(_selectedRow);
                sum = freeStorage + sumsa;
                suma = articleStorageQuantity + sumsa;
                freeStorageLbl.Text = sum.ToString();
                articleLbl.Text = suma.ToString();
            }
        }
    }
}
