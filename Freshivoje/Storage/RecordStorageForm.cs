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
            ;
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            lblTitle.Text = "EVIDENCIJA KOMORE " + storageData.getName();
            state1 = true;
             
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
       
            
        }

        private void searchRecordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void searchRecordTxtBox_TextChanged(object sender, EventArgs e)
        {
                searchValue = searchRecordTxtBox.Text.Replace('\'', (char)0x2019); // &rsquo; 
            (RecordsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"`category` LIKE '%{searchValue}%' OR `article_name` LIKE '%{searchValue}%' OR `sort` LIKE '%{searchValue}%' OR `organic` LIKE '%{searchValue}%'"; 
        }
    }
}
