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
       
        string _a1Query = "SELECT * FROM storage WHERE storage.id_storage = 1;";
        string _a2Query = "SELECT * FROM storage WHERE storage.id_storage = 2;";
        string _b1Query = "SELECT * FROM storage WHERE storage.id_storage = 3;";
        string _b2Query = "SELECT * FROM storage WHERE storage.id_storage = 4;";
        string _outQuery = "SELECT * FROM storage WHERE storage.id_storage = 8;";

        public StorageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
          
            DbConnection.fillBtnText(a1Btn, _a1Query, "id_storage" ,"storage_position", "status");
            DbConnection.fillBtnText(a2Btn, _a2Query, "id_storage", "storage_position", "status");
            DbConnection.fillBtnText(b1Btn, _b1Query, "id_storage", "storage_position", "status");
            DbConnection.fillBtnText(b2Btn, _b2Query, "id_storage", "storage_position", "status");
            DbConnection.fillBtnText(outputBtn, _outQuery, "id_storage", "storage_position", "status");
                
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
        private void StorageForm_Activated(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;

            DbConnection.fillBtnText(a1Btn, _a1Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.fillBtnText(a2Btn, _a2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.fillBtnText(b1Btn, _b1Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.fillBtnText(b2Btn, _b2Query, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
            DbConnection.fillBtnText(outputBtn, _outQuery, "id_storage", "storage_position", "StorageArticleQuantity", "article_quantity");
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
            ButtonsStorageOnClick(sender);
        }

        private void ButtonsStorageOnClick(object sender)
        {
            Button btn = sender as Button;
            int storage_id = Convert.ToInt32(btn.Tag.ToString());
            ChooseStorageMethodForm chooseStorageMethodForm = new ChooseStorageMethodForm(storage_id);
            chooseStorageMethodForm.ShowDialog(this);
            Show();
        }

        private void a1Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void a2Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void b2Btn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
            
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            ButtonsStorageOnClick(sender);
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using RecordStorageForm recordStorageForm = new RecordStorageForm(5);
            recordStorageForm.ShowDialog(this);
            Show();
        }

        private void palletizingBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using Palleting palleting = new Palleting();
            palleting.ShowDialog(this);
            Show();
        }

        private void classificationBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using Classification classification= new Classification();
            classification.ShowDialog(this);
             Show();
        }

        private void tunnelBtn_Click(object sender, EventArgs e)
        {
            using ChooseOutStorageForm chooseOutStorageForm = new ChooseOutStorageForm(9);
            chooseOutStorageForm.ShowDialog(this);
            Show();
        }
    }
}
