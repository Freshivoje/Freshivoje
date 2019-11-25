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
    public partial class InsertStorageForm : Form
    {
        string _fillCmbBox = "SELECT `articles`.`id_article`, `articles`.`article_name`, `articles`.`sort`, `articles`.`organic`, `articles`.`category`, DATE_FORMAT(`date`, ' % d.% m.% Y. ') as date FROM `receipts` JOIN `items_receipt` ON `items_receipt`.`fk_receipt_id` = `receipts`.`id_receipt` JOIN `articles` ON `articles`.`id_article` = `items_receipt`.`fk_article_id` WHERE `date` >= CURDATE() GROUP BY `articles`.`id_article`";
        public InsertStorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DbConnection.FillCmbBoxQuery(articlesCmbBox, _fillCmbBox, "id_article", "article_name", "sort", "organic", "category");
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

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
