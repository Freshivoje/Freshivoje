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
    public partial class Palleting : Form
    {
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

        private void mainFormTblLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertFormTblLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void PalletingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
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
