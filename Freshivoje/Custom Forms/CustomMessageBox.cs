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
    public partial class CustomMessageBox : Form
    {

        public static DialogResult ShowDialog(IWin32Window owner, string text)
        {
            using var customDialog = new CustomMessageBox(text);
            return customDialog.ShowDialog(owner);
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

        private CustomMessageBox(string text)
        {
            InitializeComponent();
            errorMsgLbl.Text = text;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
