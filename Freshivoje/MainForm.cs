using Freshivoje.Records_Forms;
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
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseInsertMethodForm insertMethodForm = new ChooseInsertMethodForm();
            insertMethodForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void packagesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChoosePackagesMethodForm choosePackagesMethodForm = new ChoosePackagesMethodForm();
            choosePackagesMethodForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void transportBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseForm chooseForm = new ChooseForm();
            chooseForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using RecordsForm recordsForm = new RecordsForm();
            recordsForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }
    }
}
