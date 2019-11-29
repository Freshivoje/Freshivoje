using Freshivoje.Custom_Forms;
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
    public partial class InsertStorageForm : Form
    {
        int _packagingId;
        int _articleId;
        string _fillCmbBox = "SELECT `articles`.`id_article`, `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON `articles`.`id_article` = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() GROUP BY `articles`.`id_article`;";
        string _fillCmbBox1 = "SELECT `packaging`.`id_packaging`, `packaging`.`capacity`, `packaging`.`category`, `packaging`.`weight`, `packaging`.`producer`, `packaging`.`state`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_record_items`.`id_record_item` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `date` >= CURDATE() GROUP BY `packaging`.`id_packaging`;";
        
        public InsertStorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DbConnection.FillCmbBoxQuery(articlesCmbBox, _fillCmbBox, "id_article", "article_name", "sort", "organic", "category");
            DbConnection.FillCmbBoxQuery(packagingCmbBox, _fillCmbBox1, "id_packaging", "capacity", "category", "weight", "producer", "state");
            articlesCmbBox.SelectedIndex = 0;
            packagingCmbBox.SelectedIndex = 0;
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

        private void getQuantity(int id)
        {
            string _artilceQuantity = $"SELECT articles.id_article as quantityArticleId, `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`, SUM(`items_receipt`.`quantity`) as quantityArts, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON `articles`.`id_article` = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() AND quantityArts = {_articleId} GROUP BY `articles`.`id_article`";
            string _articleStorageQuantity = $"SELECT articles.id_article as QuantityStorageArticleId, SUM(`storage_record_items`.`article_quantity`) as quantityStorageArticle, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`=5 AND QuantityStorageArticleId = {_articleId} GROUP BY articles.id_article";
            string _packagingQuantity = $"SELECT `packaging`.`id_packaging` as QuantityPackagingId, `packaging`.`capacity`, `packaging`.`category`, `packaging`.`state`, SUM(`packaging_record_items`.`quantity`) as `quantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() AND QuantityPackagingId = {_packagingId}GROUP BY `packaging`.`id_packaging`";
            string _packagingStorageQuantity = $"SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as quantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`= 5 GROUP BY packaging.id_packaging";
            DbConnection.tunnel(label2, _artilceQuantity, _articleStorageQuantity,  articleLbl, "quantityArticleId", "QuantityStorageArticleId", "article_name", "sort", "organic", "category", "quantityArts", "quantityStorageArticle");
            DbConnection.tunnel(label2, _packagingQuantity, _packagingStorageQuantity, packagingLbl, "QuantityPackagingId", "QuantityStoragePackagingId", "capacity", "state", "category", "quantityPackg", "quantityStoragePackaging", "QuantityPackagingId", "QuantityStoragePackagingId");
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {

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

            if (packagingCmbBox.SelectedIndex < 1)
            {
                packagingLbl.Text = string.Empty;
                return;
            }
            _packagingId = ((ComboBoxItem)packagingCmbBox.SelectedItem).Value;
            getQuantity(_packagingId);
           
        }

        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (articlesCmbBox.SelectedIndex < 1)
            {
                articleLbl.Text = string.Empty;
                return;
            }
            _articleId = ((ComboBoxItem)articlesCmbBox.SelectedItem).Value;
            getQuantity(_articleId);
        }
    }
}
