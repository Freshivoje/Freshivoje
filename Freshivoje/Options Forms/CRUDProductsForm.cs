using System;
using System.Data;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;

namespace Freshivoje.Options_Forms
{
    public partial class CRUDProductsForm : Form
    {
        private readonly string _fillDGVQuery = "SELECT * FROM `products`";
        private string _selectedProductName, _selectedProductType;
        private int _selectedProductId;
        public CRUDProductsForm()
        {
            InitializeComponent();
            productsDataGridView.AutoGenerateColumns = false;         
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

        private void CRUDProductsForm_Activated(object sender, EventArgs e)
        {
            DbConnection.fillDGV(productsDataGridView, _fillDGVQuery);
        }
        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
    
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void packagingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            _selectedProductId = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells["idProduct"].Value);
            _selectedProductName = productsDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
            _selectedProductType = productsDataGridView.Rows[e.RowIndex].Cells["type"].Value.ToString();


            if (e.ColumnIndex == 3)
            {
                Product product = new Product(_selectedProductId, _selectedProductName, _selectedProductType);
                using EditProductForm editproduct = new EditProductForm(product);
                editproduct.ShowDialog(this);
            }
           

            if (e.ColumnIndex == 4)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete proizvod?\nIme: {_selectedProductName}\nVrsta: {_selectedProductType}");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DbConnection.deleteFromDB("products", "id_product", _selectedProductId);
                DbConnection.fillDGV(productsDataGridView, _fillDGVQuery);
            }
        }

        private void createPackageBtn_Click(object sender, EventArgs e)
        {
            using CreateProductForm createPackageForm = new CreateProductForm();
            createPackageForm.ShowDialog(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTxtBox.Text.Replace('\'', (char)0x2019); // &rsquo; 
            (productsDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`name`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR Convert(`type`, 'System.String') LIKE '%{searchValue}%'";

        }

    }
}
