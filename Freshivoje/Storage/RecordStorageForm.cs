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
    public partial class RecordStorageForm : Form
    {
        int _storageId;
        string _packagingQuery;
        string _articleQuery;
        bool state1;
        string searchValue;
        public RecordStorageForm(int storageId)
        {
            _storageId = storageId;
            InitializeComponent();
            _storageId = storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='" + _storageId + "'";
            WindowState = FormWindowState.Maximized;
            RecordsDataGridView.AutoGenerateColumns = false;
            searchRecordTypeComboBox.SelectedIndex = 0;
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            lblTitle.Text = "EVIDENCIJA KOMORE " + storageData.getName();
            state1 = true;
             //_packagingQuery = $"SELECT packaging.capacity, packaging.category as packagingName, packaging.state, SUM(storage_record_items.package_quantity) as quantity FROM `storage_record_items` INNER JOIN packaging ON storage_record_items.fk_packaging_id = packaging.id_packaging INNER JOIN storage ON storage_record_items.fk_storage_id = storage.id_storage WHERE fk_storage_id = {_storageId} GROUP BY packaging.id_packaging";
             //_articleQuery = $"SELECT articles.article_name, articles.sort, articles.organic, articles.category, SUM(storage_record_items.article_quantity) as quantity FROM `storage_record_items` INNER JOIN articles ON storage_record_items.fk_article_id = articles.id_article INNER JOIN storage ON storage_record_items.fk_storage_id = storage.id_storage WHERE fk_storage_id = {_storageId} GROUP BY articles.id_article";

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
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void packagesRecordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) { };
            
        }

        private void searchRecordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _packagingQuery = $"SELECT packaging.capacity, packaging.category as packagingName, packaging.state, SUM(storage_record_items.package_quantity) as quantity FROM `storage_record_items` INNER JOIN packaging ON storage_record_items.fk_packaging_id = packaging.id_packaging INNER JOIN storage ON storage_record_items.fk_storage_id = storage.id_storage WHERE fk_storage_id = {_storageId} GROUP BY packaging.id_packaging";
            _articleQuery = $"SELECT articles.article_name, articles.sort, articles.organic, articles.category, SUM(storage_record_items.article_quantity) as quantity FROM `storage_record_items` INNER JOIN articles ON storage_record_items.fk_article_id = articles.id_article INNER JOIN storage ON storage_record_items.fk_storage_id = storage.id_storage WHERE fk_storage_id = {_storageId} GROUP BY articles.id_article";
            if (searchRecordTypeComboBox.SelectedIndex == 0)
            {
                state1 = true;
                DbConnection.fillDGV(RecordsDataGridView, _articleQuery);
                RecordsDataGridView.Columns[1].Visible = true;
                RecordsDataGridView.Columns[2].Visible = true;
                RecordsDataGridView.Columns[3].Visible = true;
                RecordsDataGridView.Columns[0].Visible = true;
                RecordsDataGridView.Columns[4].Visible = false;
                RecordsDataGridView.Columns[5].Visible = false;
                RecordsDataGridView.Columns[6].Visible = false;
            }
            else if (searchRecordTypeComboBox.SelectedIndex == 1)
            {
                state1 = false;
                DbConnection.fillDGV(RecordsDataGridView, _packagingQuery);
                RecordsDataGridView.Columns[1].Visible = false;
                RecordsDataGridView.Columns[2].Visible = false;
                RecordsDataGridView.Columns[3].Visible = false;
                RecordsDataGridView.Columns[0].Visible = false;
                RecordsDataGridView.Columns[4].Visible = true;
                RecordsDataGridView.Columns[5].Visible = true;
                RecordsDataGridView.Columns[6].Visible = true;
            }
        }

        private void searchRecordTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(state1 == true)
            {
                searchValue = searchRecordTxtBox.Text;
                (RecordsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`category` LIKE '%{searchValue}%' OR `article_name` LIKE '%{searchValue}%' OR `sort` LIKE '%{searchValue}%' OR `organic` LIKE '%{searchValue}%'";


            }
            else
            {

            }
                searchValue = searchRecordTxtBox.Text;
                (RecordsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`capacity`, 'System.String') LIKE '%{searchValue}%' 
                                                                                        OR `category` LIKE '%{searchValue}%' `packagingName` LIKE '%{searchValue}%' 
                                                                                        OR `article_name` LIKE '%{searchValue}%'Convert(`quantity`, 'System.String') LIKE '%{searchValue}%' 
                                                                                        OR `sort` LIKE '%{searchValue}% `organic` LIKE '%{searchValue}%' 
                                                                                        OR `category` LIKE '%{searchValue}%'";
        }
    }
}
