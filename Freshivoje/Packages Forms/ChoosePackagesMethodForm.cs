using Freshivoje.Packages;
using Freshivoje.Shared_Forms;
using System;
using System.Windows.Forms;


namespace Freshivoje
{
    public partial class ChoosePackagesMethodForm : Form
    {
        public ChoosePackagesMethodForm()
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
        private void repurchaseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseClientForm chooseClientForm = new ChooseClientForm("RentPackagesForm");
            chooseClientForm.ShowDialog(this);
            Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void packagesRecordBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using PackagesRecordForm packagesRecordForm = new PackagesRecordForm();
            packagesRecordForm.ShowDialog(this);
            if (!IsDisposed) 
            { 
                Show(); 
            }
        }
    }
}
