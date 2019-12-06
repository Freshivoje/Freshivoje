using System;
using System.Windows.Forms;

namespace Freshivoje.Records_Forms
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
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
 
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void documentRecordsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using DocumentsForm documentsForm = new DocumentsForm();
            documentsForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }

        private void articleRecordsBtn_Click_1(object sender, EventArgs e)
        {
            Hide();
            using ReceiptsForm insertForm = new ReceiptsForm();
            insertForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
            }
        }
    }
}
