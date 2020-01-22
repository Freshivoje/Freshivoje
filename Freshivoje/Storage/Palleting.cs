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
    public partial class Palleting : Form
    {
        public List<PalletingItem> palletings = new List<PalletingItem>();
        public decimal totalQuanrity = 0;
        public Boolean chackedStatus = false;
        readonly string _fillDGVQuery = "SELECT receipts.fk_client_id, clients.first_name, clients.last_name, items_receipt.fk_receipt_id, items_receipt.fk_article_id, items_receipt.quantity, items_receipt.status, articles.article_name, articles.sort, articles.organic, articles.category FROM receipts INNER JOIN clients ON receipts.fk_client_id = clients.id_client INNER JOIN items_receipt ON items_receipt.fk_receipt_id = receipts.id_receipt INNER JOIN articles ON articles.id_article = items_receipt.fk_article_id WHERE items_receipt.status = 'aktivna'";
        public Palleting()
        {
            InitializeComponent();
            palletingDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(palletingDataGridView, _fillDGVQuery);
            palletingDataGridView.DefaultCellStyle.ForeColor = Color.Black;
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

        private void chkItems_CheckedChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in palletingDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[12];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                    int selectedRowIndex = row.Index;
                    decimal quantity = Convert.ToDecimal(palletingDataGridView.Rows[selectedRowIndex].Cells["quantity"].Value);
                    totalQuanrity = totalQuanrity + quantity;
                    palleteQuantitylbl.Text = totalQuanrity.ToString();
                }
                else
                {
                    chk.Value = chk.FalseValue;
                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    totalQuanrity = totalQuanrity + quantity;
                    palleteQuantitylbl.Text = totalQuanrity.ToString();
                }

            }
            palletingDataGridView.EndEdit();
        }

        private void mainFormTblLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertFormTblLayout_Paint(object sender, PaintEventArgs e)
         {

        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in palletingDataGridView.Rows)
            {
                if (row.Cells[12].Value != null && row.Cells[12].Value.Equals(true)) //3 is the column number of checkbox
                {
                    row.Selected = true;
                   
                    
                    int fk_client_id = Convert.ToInt32(row.Cells["fk_client_id"].Value);
                    string first_name = Convert.ToString(row.Cells["first_name"].Value);
                    string last_name = Convert.ToString(row.Cells["last_name"].Value);
                    int fk_receipte_id = Convert.ToInt32(row.Cells["fk_receipt_id"].Value);
                    int fk_article_id = Convert.ToInt32(row.Cells["fk_arcticle_id"].Value);
                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    string status = Convert.ToString(row.Cells["status"].Value);
                    string article_name = Convert.ToString(row.Cells["article_name"].Value);
                    string sort = Convert.ToString(row.Cells["sort"].Value);
                    string organic = Convert.ToString(row.Cells["organic"].Value);
                    string category = Convert.ToString(row.Cells["category"].Value);

                    PalletingItem item = new PalletingItem(fk_client_id, first_name, last_name, fk_receipte_id, fk_article_id, quantity,
                        status, article_name, sort, organic, category);
                    palletings.Add(item);
                 }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void PalletingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if( e.ColumnIndex == 12)
            {
                
                foreach (DataGridViewRow row in palletingDataGridView.Rows) {
                    int selectedRowIndex = palletingDataGridView.CurrentRow.Index;
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)palletingDataGridView.Rows[selectedRowIndex].Cells[12];
                    
                    if (Convert.ToInt32(chk.Value) == 0 || chk.Value == null )
                    {
                        chk.Value = 1;
                        decimal quantity = Convert.ToDecimal(palletingDataGridView.Rows[selectedRowIndex].Cells["quantity"].Value);
                            totalQuanrity = totalQuanrity + quantity;
                            palleteQuantitylbl.Text = totalQuanrity.ToString();
                            return; 
                    }
                    else
                    {
                        chk.Value = 0;
                        decimal quantity = Convert.ToDecimal(palletingDataGridView.Rows[selectedRowIndex].Cells["quantity"].Value);
                            totalQuanrity = totalQuanrity - quantity;
                            palleteQuantitylbl.Text = totalQuanrity.ToString();
                            return;
                    }

                }
                palletingDataGridView.EndEdit();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
