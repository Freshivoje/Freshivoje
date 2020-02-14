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
            string _fillLbl = $"SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) - (SELECT COALESCE(SUM(storage_record_items.article_quantity), 0) FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 8 AND storage_record_items.status = 'neaktivna') as StorageArticleQuantity, storage.id_storage, storage.storage_position, storage.article_quantity FROM storage_record_items JOIN storage ON storage.id_storage = storage_record_items.fk_storage_id WHERE storage_record_items.fk_storage_id = 8 AND storage_record_items.status = 'aktivna'";
            string _fillCmbBox = $"SELECT articles.id_article, articles.article_name, articles.sort, articles.organic, articles.category FROM storage_record_items JOIN articles ON articles.id_article = storage_record_items.fk_article_id WHERE storage_record_items.status = 'aktivna' AND storage_record_items.fk_storage_id = {_storageId} GROUP BY articles.id_article;";
           
            if(_storageId == 8)
            {
                lblTitle.Text = "PRODAJA";
            }
            else
            {
                lblTitle.Text = "IZLAZ ARTIKALA IZ KOMORE " + storageData.getName();
            }
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
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
