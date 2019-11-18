using Freshivoje.Insert_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshivoje
{
    public partial class ChooseStorageRentingMethodForm : Form
    {
        public ChooseStorageRentingMethodForm()
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
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newStorageRentingBtn_Click(object sender, EventArgs e)
        {
            ChooseClientForRentingForm chooseClientForRentingForm = new ChooseClientForRentingForm();
            chooseClientForRentingForm.ShowDialog(this);
        }

        private void storageRentBtn_Click(object sender, EventArgs e)
        {
            StorageRentingRecordsForm storageRentingRecordsForm = new StorageRentingRecordsForm();
            storageRentingRecordsForm.Show(this);
        }
    }
}
