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
    public partial class StorageForm : Form
    {
        string _fillTextBox = "SELECT articles.id_article as quantityArticleId, `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`, SUM(`items_receipt`.`quantity`) as quantityArts, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON `articles`.`id_article` = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() GROUP BY `articles`.`id_article`";
        string _query1 = "SELECT articles.id_article as QuantityStorageArticleId, SUM(`storage_record_items`.`article_quantity`) as quantityStorageArticle, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`=5 GROUP BY articles.id_article";
        string _fillTextBox1 = "SELECT `packaging`.`id_packaging` as QuantityPackagingId, `packaging`.`capacity`, `packaging`.`category`, `packaging`.`state`, SUM(`packaging_record_items`.`quantity`) as `quantityPackg`, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM `packaging_records` JOIN `packaging_record_items` ON `packaging_record_items`.`fk_packaging_records_id` = `packaging_records`.`id_packaging_record` JOIN `packaging` ON `packaging`.`id_packaging` = `packaging_record_items`.`fk_packaging_id` WHERE `packaging_records`.`type` = 1 AND `packaging_records`.`date` >= CURDATE() GROUP BY `packaging`.`id_packaging`";
        string _query2 = "SELECT  `packaging`.`id_packaging` as QuantityStoragePackagingId, SUM(`storage_record_items`.`package_quantity`) as quantityStoragePackaging, DATE_FORMAT(`date`, ' %d.%m.%Y. ') as date FROM storage_record_items JOIN packaging ON packaging.id_packaging = storage_record_items.fk_packaging_id WHERE `date` >= CURDATE() AND `storage_record_items`.`fk_storage_id`=5 GROUP BY packaging.id_packaging";
        string _a1Query = "SELECT (COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 1 AND storage_record_items.status = 'neaktivna'))as StoragePackagingQuantity,(COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 1 AND storage_record_items.status = 'neaktivna')) as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 1 AND storage_record_items.status = 'aktivna'";
        string _a2Query = "SELECT (COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 2 AND storage_record_items.status = 'neaktivna'))as StoragePackagingQuantity,(COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 2 AND storage_record_items.status = 'neaktivna')) as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 2 AND storage_record_items.status = 'aktivna'";
        string _b1Query = "SELECT (COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 3 AND storage_record_items.status = 'neaktivna'))as StoragePackagingQuantity,(COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 3 AND storage_record_items.status = 'neaktivna')) as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 3 AND storage_record_items.status = 'aktivna'";
        string _b2Query = "SELECT (COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 4 AND storage_record_items.status = 'neaktivna'))as StoragePackagingQuantity,(COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 4 AND storage_record_items.status = 'neaktivna')) as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 4 AND storage_record_items.status = 'aktivna'";
        string _outQuery = "SELECT (COALESCE(SUM(storage_record_items.package_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.package_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 8 AND storage_record_items.status = 'neaktivna'))as StoragePackagingQuantity,(COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity),0) FROM storage_record_items WHERE storage_record_items.fk_storage_id = 8 AND storage_record_items.status = 'neaktivna')) as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity, storage.package_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 8 AND storage_record_items.status = 'aktivna'";

        public StorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            tunnelLbl.Text = "";
            articlequantityLbl.Text = "";
            packagingQuantityLbl.Text = "";
            packagingTunnelLbl.Text = "";
            DbConnection.fillBtnText(a1Btn, _a1Query, "id_storage" ,"storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(a2Btn, _a2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(b1Btn, _b1Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(b2Btn, _b2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(outputBtn, _outQuery, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.tunnel(tunnelLbl, _fillTextBox, _query1, articlequantityLbl, "quantityArticleId", "QuantityStorageArticleId", "article_name", "sort", "organic", "category", "quantityArts", "quantityStorageArticle");
            DbConnection.tunnel(packagingTunnelLbl,  _fillTextBox1, _query2, packagingQuantityLbl, "QuantityPackagingId", "QuantityStoragePackagingId", "capacity",  "state", "category", "quantityPackg", "quantityStoragePackaging", "QuantityPackagingId", "QuantityStoragePackagingId");
           
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
        private void StorageForm_Activated(object sender, EventArgs e)
        {
           
            WindowState = FormWindowState.Maximized;
            tunnelLbl.Text = "";
            articlequantityLbl.Text = "";
            packagingQuantityLbl.Text = "";
            packagingTunnelLbl.Text = "";
            DbConnection.fillBtnText(a1Btn, _a1Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(a2Btn, _a2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(b1Btn, _b1Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(b2Btn, _b2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity", "StoragePackagingQuantity", "package_quantity");
            DbConnection.fillBtnText(outputBtn, _outQuery, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.tunnel(tunnelLbl, _fillTextBox, _query1, articlequantityLbl, "quantityArticleId", "QuantityStorageArticleId", "article_name", "sort", "organic", "category", "quantityArts", "quantityStorageArticle");
            DbConnection.tunnel(packagingTunnelLbl, _fillTextBox1, _query2, packagingQuantityLbl, "QuantityPackagingId", "QuantityStoragePackagingId", "capacity", "state", "category", "quantityPackg", "quantityStoragePackaging", "QuantityPackagingId", "QuantityStoragePackagingId");
          
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b1Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void ButtonsStorageOnClick(object sender)
        {
            Button btn = sender as Button;
            int storage_id = Convert.ToInt32(btn.Tag.ToString());
            if(storage_id == 8)
            {
                ChooseOutStorageForm chooseOutStorageForm = new ChooseOutStorageForm(storage_id);
                chooseOutStorageForm.ShowDialog(this);
                Show();
                return;
            }
            ChooseStorageMethodForm chooseStorageMethodForm = new ChooseStorageMethodForm(storage_id);
            chooseStorageMethodForm.ShowDialog(this);
            Show();
        }

        private void a1Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void a2Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void b2Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
            
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using RecordStorageForm recordStorageForm = new RecordStorageForm(5);
            recordStorageForm.ShowDialog(this);
            Show();
        }
    }
}
