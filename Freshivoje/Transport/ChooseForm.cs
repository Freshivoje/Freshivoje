using System;
using System.Windows.Forms;

namespace Freshivoje.Transport
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void repurchaseBtn_Click(object sender, EventArgs e)
        {
            using ChooseClientForm chooseClientForm = new ChooseClientForm("TransportForm");
            chooseClientForm.ShowDialog(this);
        }

        private void storegeOfGoodsBtn_Click(object sender, EventArgs e)
        {
            TransportRecordForm transportRecordForm = new TransportRecordForm();
            transportRecordForm.ShowDialog(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
