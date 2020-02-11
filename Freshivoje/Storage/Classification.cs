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

namespace Freshivoje.Storage
{
    public partial class Classification : Form
    {
        public Classification()
        {
            InitializeComponent();
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

        private void sumQuantity()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in classiDataGridView.Rows)
            {
                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    sum = sum + quantity;
            }

            noClassificationLbl.Text = sum.ToString();
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

        private void Classification_Load(object sender, EventArgs e)
        {

        }

        private void insertFormTblLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string palletNuber = "";
            palletNuber = palletNumberTxt.Text;
            string query1 = "SELECT receipts.fk_client_id, clients.first_name, clients.last_name, items_receipt.fk_article_id, items_receipt.id_items_receipt, items_receipt.quantity, articles.article_name, articles.sort, articles.organic, articles.category, item_pallete.fk_id_pallete, pallete.pallet_number FROM receipts INNER JOIN clients ON receipts.fk_client_id = clients.id_client INNER JOIN items_receipt ON items_receipt.fk_receipt_id = receipts.id_receipt INNER JOIN articles ON articles.id_article = items_receipt.fk_article_id INNER JOIN item_pallete ON items_receipt.id_items_receipt = item_pallete.fk_id_item_recepit INNER JOIN pallete on pallete.id_pallete = item_pallete.fk_id_pallete WHERE pallete.pallet_number = " + palletNuber + " AND pallete.classification = 'no' ";
            DbConnection.fillDGV(classiDataGridView, query1);
            if(classiDataGridView.RowCount == 0)
            {
                CustomMessageBox.ShowDialog(this, "Paleta sa ovim brojem ne postoji !");
                return;
            }
            sumQuantity();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            decimal class1 = Convert.ToDecimal(class1TxtBox.Text);
            decimal class2 = Convert.ToDecimal(class2TxtBox.Text);
            decimal class3 = Convert.ToDecimal(class3TxtBox.Text);
            decimal class4 = Convert.ToDecimal(class4TxtBox.Text);
            decimal Sumclass = Convert.ToDecimal(noClassificationLbl.Text);
            int pallet_id = 1;
            foreach (DataGridViewRow row in classiDataGridView.Rows)
            {
               pallet_id = Convert.ToInt32(row.Cells["fk_id_pallete"].Value);
            }
            string date = DateTime.Now.ToString("yyyy-MM-dd");



            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = @"INSERT INTO `classificaiton` ( `fk_pallet_id`, `sum_quantity`, `first_class`, `sec_class`, `third_class`, `fourth_class`, `class_date`, `class_year`) VALUES( @pallet_id, @Sumclass ,@class1, @class2, @class3, @class4, @date, '2020')"
            };

            mySqlCommand.Parameters.AddWithValue("@class1", class1);
            mySqlCommand.Parameters.AddWithValue("@class2", class2);
            mySqlCommand.Parameters.AddWithValue("@class3", class3);
            mySqlCommand.Parameters.AddWithValue("@class4", class4);
            mySqlCommand.Parameters.AddWithValue("@Sumclass", Sumclass);
            mySqlCommand.Parameters.AddWithValue("@pallet_id", pallet_id);
            mySqlCommand.Parameters.AddWithValue("@date", date);

            DbConnection.executeQuery(mySqlCommand);
            MySqlCommand mySqlCommand1 = new MySqlCommand
            {
                CommandText = @"UPDATE pallete SET classification = 'DA' WHERE id_pallete = @pallet_id"
            };
            mySqlCommand1.Parameters.AddWithValue("@pallet_id", pallet_id);
            DbConnection.executeQuery(mySqlCommand1);

            Close();           

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void palletNumberTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
