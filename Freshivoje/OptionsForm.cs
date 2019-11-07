using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshivoje.Options_Forms;

namespace Freshivoje
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            using CRUDArticlesForm CRUDArticlesForm = new CRUDArticlesForm();
            CRUDArticlesForm.ShowDialog(this);
        }

        private void packagesBtn_Click(object sender, EventArgs e)
        {
            using CRUDPackagesForm CRUDPackagesForm = new CRUDPackagesForm();
            CRUDPackagesForm.ShowDialog(this);
        }


        private void clientsBtn_Click(object sender, EventArgs e)
        {
            using CRUDClientsForm CRUDClientsForm = new CRUDClientsForm();
            CRUDClientsForm.ShowDialog(this);
        }
    }
}
