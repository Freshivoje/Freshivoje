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
        int storageId;
       
        public InsertStorageForm(int _storageId)
        {
            InitializeComponent();
            storageId = _storageId;
            string query = "SELECT `pallete`.`pallet_number`, pallete.classification FROM `pallete_positioning` INNER JOIN `pallete` ON pallete_positioning.fk_pallete_id = pallete.id_pallete WHERE pallete_positioning.fk_storage_id = " + storageId;
            DbConnection.fillDGV(palletePositioningDataGridView, query);
            palletePositioningDataGridView.AutoGenerateColumns = false;
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
            Close();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }


        private void articlesCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArticlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

    }
}

