using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshivoje.Custom_Forms
{
    public partial class CustomDialog : Form
    {

        public static DialogResult ShowDialog(IWin32Window owner, string text)
        {
            using var customDialog = new CustomDialog(text);
            return customDialog.ShowDialog(owner);
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
        private CustomDialog(string text)
        {
            InitializeComponent();
            dialogMsgLbl.Text = text;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
