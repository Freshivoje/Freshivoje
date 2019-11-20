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
        public StorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DbConnection.fillBtnText(a1Btn, "storage", "A1", "id_storage", "storage_position", "article_quantity",  "package_quantity");
            DbConnection.fillBtnText(a2Btn, "storage", "A2", "id_storage", "storage_position", "article_quantity", "package_quantity");
            DbConnection.fillBtnText(b1Btn, "storage", "B1", "id_storage", "storage_position", "article_quantity", "package_quantity");
            DbConnection.fillBtnText(b2Btn, "storage", "B2", "id_storage", "storage_position", "article_quantity", "package_quantity");
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

        }
    }
}
