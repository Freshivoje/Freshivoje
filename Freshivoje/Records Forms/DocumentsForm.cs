using Freshivoje.Custom_Forms;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Freshivoje.Records_Forms
{
    public partial class DocumentsForm : Form
    {
        // STAVITI DA BUDE RELATIVNA PUTANJA UNUTAR PROJEKTA
        private readonly string _folderPath = "C:\\PDF\\";
        private string _file = string.Empty;
        private readonly DataTable _table = new DataTable();

        public DocumentsForm()
        {
            InitializeComponent();
            _table.Columns.Add("file_path", typeof(string));
            _table.Columns.Add("file_name", typeof(string));

            string[] files = Directory.GetFiles(_folderPath);

            foreach (string file in files)
            {
                _table.Rows.Add(file, Path.GetFileNameWithoutExtension(file));
            }

            documentsDataGridView.AutoGenerateColumns = false;
            documentsDataGridView.DataSource = _table;
       
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

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void searchTransportxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTxtBox.Text;
            (documentsDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"`file_name` LIKE '%{searchValue}%'";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _table.Dispose();
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            _table.Dispose();
            Application.Exit();
        }

        private void documentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) 
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li želite da otvorite ovaj dokument?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                _file = documentsDataGridView.Rows[e.RowIndex].Cells["filePath"].Value.ToString();

                Process.Start(_file);
            }
        }
    }
}
