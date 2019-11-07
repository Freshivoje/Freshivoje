using System.Windows.Forms;

namespace Freshivoje
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
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

        private void backBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }


        private void minimizeBtn_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
