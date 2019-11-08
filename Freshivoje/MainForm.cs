using System;
using System.Windows.Forms;

namespace Freshivoje
{
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm;
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
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
            using InsertMethodForm chooseInsertMethodForm = new InsertMethodForm();
            chooseInsertMethodForm.ShowDialog(this);
        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {
            using PaymentsForm insertForm = new PaymentsForm();
            insertForm.ShowDialog(this);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog(this);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            using OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        private void packagesBtn_Click(object sender, EventArgs e)
        {
            using PackagesForm packagesForm = new PackagesForm();
            packagesForm.ShowDialog(this);
        }

        private void transportBtn_Click(object sender, EventArgs e)
        {
            using Transport.ChooseClientTransportForm transportForm = new Transport.ChooseClientTransportForm();
            transportForm.ShowDialog(this);
        }
    }
}
