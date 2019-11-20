using Freshivoje.Storage;
using Freshivoje.Transport;
using System;
using System.Windows.Forms;

namespace Freshivoje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            using LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);
            // titleLbl.Text += Properties.Settings.Default.currentUserId.ToString();
        }

        // Disables flickering on FormLoad
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseInsertMethodForm insertMethodForm = new ChooseInsertMethodForm();
            insertMethodForm.ShowDialog(this);
            Show();
        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using PaymentsForm insertForm = new PaymentsForm();
            insertForm.ShowDialog(this);
            Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);
            Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
            Show();
        }

        private void packagesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChoosePackagesMethodForm choosePackagesMethodForm = new ChoosePackagesMethodForm();
            choosePackagesMethodForm.ShowDialog(this);
            Show();
        }

        private void transportBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseForm chooseForm = new ChooseForm();
            chooseForm.ShowDialog(this);
            Show();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog(this);
            Show();
        }
    }
}
