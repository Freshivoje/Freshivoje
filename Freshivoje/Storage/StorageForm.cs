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
        public StorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            tunnelLbl.Text = "";
            articlequantityLbl.Text = "";
            packagingQuantityLbl.Text = "";
            packagingTunnelLbl.Text = "";
            DbConnection.fillBtnText(a1Btn, "storage", "A1", "id_storage", "storage_position", "article_quantity",  "package_quantity", "status");
            DbConnection.fillBtnText(a2Btn, "storage", "A2", "id_storage", "storage_position", "article_quantity", "package_quantity", "status");
            DbConnection.fillBtnText(b1Btn, "storage", "B1", "id_storage", "storage_position", "article_quantity", "package_quantity", "status");
            DbConnection.fillBtnText(b2Btn, "storage", "B2", "id_storage", "storage_position", "article_quantity", "package_quantity", "status");
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

        }
    }
}
