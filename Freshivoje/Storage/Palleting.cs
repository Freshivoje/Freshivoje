using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Models;

namespace Freshivoje.Storage
{
    public partial class Palleting : Form
    {
        public List<PalletingItem> palletings = new List<PalletingItem>();
        public decimal totalQuanrity = 0;
        public Boolean chackedStatus = false;
        readonly string _fillDGVQuery = "SELECT receipts.fk_client_id, clients.first_name, clients.last_name, items_receipt.fk_receipt_id, items_receipt.fk_article_id, items_receipt.id_items_receipt, items_receipt.quantity, items_receipt.status, articles.article_name, articles.sort, articles.organic, articles.category FROM receipts INNER JOIN clients ON receipts.fk_client_id = clients.id_client INNER JOIN items_receipt ON items_receipt.fk_receipt_id = receipts.id_receipt INNER JOIN articles ON articles.id_article = items_receipt.fk_article_id WHERE items_receipt.status = 'aktivna'";
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

        private void palletingDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex == 13 && e.RowIndex == palletingDataGridView.NewRowIndex)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;
            }
        }

        private void insertFormTblLayout_Paint(object sender, PaintEventArgs e)
         {

        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            if (palletingDataGridView.Rows.Count < 1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyDGVMsg);
                return;
            }

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da kreirate paletu ?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            foreach (DataGridViewRow row in palletingDataGridView.Rows)
            {
                if (row.Cells[13].Value != null && row.Cells[13].Value.Equals(true)) 
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
                    int fk_item_receipt_id = Convert.ToInt32(row.Cells["id_items_receipt"].Value);


                    PalletingItem item = new PalletingItem(fk_client_id, first_name, last_name, fk_receipte_id, fk_article_id, quantity,
                        status, article_name, sort, organic, category, fk_item_receipt_id);
                    palletings.Add(item);
                 }
                else
                {
                    row.Selected = false;
                }
            }

            DbConnection.executePalletingQuery(palletings);
            Close();
        }

        private void PalletingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if( e.ColumnIndex == 13)
            {

                foreach (DataGridViewRow row in palletingDataGridView.Rows) {
                    int selectedRowIndex = palletingDataGridView.CurrentRow.Index;
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)palletingDataGridView.Rows[selectedRowIndex].Cells[13];
                    
                    if (Convert.ToInt32(chk.Value) == 0 || chk.Value == null )
                    {
                        chk.Value = 1;
                        decimal quantity = Convert.ToDecimal(palletingDataGridView.Rows[selectedRowIndex].Cells["quantity"].Value);
                            totalQuanrity = totalQuanrity + quantity;
                            if(totalQuanrity >= 500)
                            {
                                palleteQuantitylbl.ForeColor = System.Drawing.Color.Red;
                                finishInsertBtn.Enabled = false;
                            }
                            if(totalQuanrity < 500)
                            {
                                palleteQuantitylbl.ForeColor = System.Drawing.Color.White;
                                finishInsertBtn.Enabled = true;
                            } 
                            palleteQuantitylbl.Text = totalQuanrity.ToString();
                            return; 
                    }
                    else
                    {
                        chk.Value = 0;
                        decimal quantity = Convert.ToDecimal(palletingDataGridView.Rows[selectedRowIndex].Cells["quantity"].Value);
                            totalQuanrity = totalQuanrity - quantity;
                            if (totalQuanrity >= 500)
                            {
                                palleteQuantitylbl.ForeColor = System.Drawing.Color.Red;
                            }
                            if (totalQuanrity < 500)
                            {
                                palleteQuantitylbl.ForeColor = System.Drawing.Color.White;
                            }
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

        private void palletingDataGridView_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.RowIndex == palletingDataGridView.NewRowIndex)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Handled = true;
            }
        }
    }
}
