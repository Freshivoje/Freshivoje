using Freshivoje.Custom_Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Freshivoje.Models;

namespace Freshivoje.Options_Forms
{
    public partial class CRUDArticlesForm : Form
    {
        private readonly string _fillDGVQuery = "SELECT * FROM `articles`";
        private int _selectedArticleId;
        private string _selectedArticleName = string.Empty,
                        _selectedArticleSort = string.Empty,
                        _selectedArticleOrganic = string.Empty;
  
        public CRUDArticlesForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            articlesDataGridView.AutoGenerateColumns = false;
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

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        private void searchArticlesTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchArticlesTxtBox.Text;
            (articlesDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"`article_name` LIKE '%{searchValue}%' OR `sort` LIKE '%{searchValue}%' OR `organic` LIKE '%{searchValue}%'";
        }

        private void insertArticleBtn_Click(object sender, EventArgs e)
        {
            using CreateArticleForm createArticleForm = new CreateArticleForm();
            createArticleForm.ShowDialog(this);
        }

        private void articlesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUDArticlesForm_Activated(object sender, EventArgs e)
        {
            DbConnection.fillDGV(articlesDataGridView, _fillDGVQuery);
        }

        private void articlesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            _selectedArticleId = Convert.ToInt32(articlesDataGridView.Rows[e.RowIndex].Cells["articleId"].Value);
            _selectedArticleName = articlesDataGridView.Rows[e.RowIndex].Cells["articleName"].Value.ToString();
            _selectedArticleSort = articlesDataGridView.Rows[e.RowIndex].Cells["articleSort"].Value.ToString();
            _selectedArticleOrganic = articlesDataGridView.Rows[e.RowIndex].Cells["articleOrganic"].Value.ToString();


            if (e.ColumnIndex == 4)
            {
                Article article = new Article(
                    _selectedArticleId,
                    _selectedArticleName,
                    _selectedArticleSort,
                    _selectedArticleOrganic
                    );

                EditArticleForm editArticle = new EditArticleForm(article);
                editArticle.ShowDialog(this);
            }

            if (e.ColumnIndex == 5)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete artikal?\nIme: {_selectedArticleName}\nSorta: {_selectedArticleSort}\nKontrolisana proizvodnja: {_selectedArticleOrganic}");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DbConnection.deleteFromDB("articles", "id_article", _selectedArticleId);
                DbConnection.fillDGV(articlesDataGridView, _fillDGVQuery);
            }
        }
    }
}
