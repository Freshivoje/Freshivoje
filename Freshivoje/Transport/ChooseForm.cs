using Freshivoje.Shared_Forms;
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
            Hide();
            using ChooseClientForm chooseClientForm = new ChooseClientForm("TransportForm");
            chooseClientForm.ShowDialog(this);
            Show();
        }

        private void storegeOfGoodsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            TransportRecordForm transportRecordForm = new TransportRecordForm();
            transportRecordForm.ShowDialog(this);
            Show();
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
