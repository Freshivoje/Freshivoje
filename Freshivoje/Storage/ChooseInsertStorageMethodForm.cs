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
    public partial class ChooseInsertStorageMethodForm : Form
    {
        int _storageId;
        string _btnText;
        public ChooseInsertStorageMethodForm(int storageId, string btnText)
        {
            _btnText = btnText;
            _storageId = storageId;
            InitializeComponent();
            if(_btnText == "ULAZ")
            {
                titleLbl.Text = "ULAZ";
            }
            else
            {
                titleLbl.Text = "IZLAZ";
            }
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void articleBtn_Click(object sender, EventArgs e)
        {
            if(titleLbl.Text == "ULAZ")
            {
                Hide();
                using InsertStorageForm insertStorageForm = new InsertStorageForm(_storageId);
                insertStorageForm.ShowDialog(this);
                Show();
            }
            else
            {

                Hide();
                using OutStorageForm outStorageForm = new OutStorageForm(_storageId);
                outStorageForm.ShowDialog(this);
                Show();
            }
         
        }

        private void ambalageBtn_Click(object sender, EventArgs e)
        {
            if (titleLbl.Text == "ULAZ")
            {
                Hide();
                using InsertPackagingStorageForm insertPackagingStorageForm = new InsertPackagingStorageForm(_storageId);
                insertPackagingStorageForm.ShowDialog(this);
                Show();
            }
            else
            {

            }
           
        }
    }
}
