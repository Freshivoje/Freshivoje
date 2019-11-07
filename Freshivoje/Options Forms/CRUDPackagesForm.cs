using System;
using System.Data;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;

namespace Freshivoje.Options_Forms
{
    public partial class CRUDPackagesForm : Form
    {
        private readonly string _fillDGVQuery = "SELECT * FROM `packaging` JOIN `categories` ON `packaging`.`fk_category_id` = `categories`.`id_category`";
        private string   _selectedPackageCategory;
        private decimal _selectedPackagePrice;
        private int _selectedPackageId, _selectedPackageCategoryId, _selectedPackageCapacity, _selectedPackageQuantity;
        public CRUDPackagesForm()
        {
            InitializeComponent();
            packagesDataGridView.AutoGenerateColumns = false;         
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

        private void CRUDPackagesForm_Activated(object sender, EventArgs e)
        {
            DbConnection.fillDGV(packagesDataGridView, _fillDGVQuery);
        }
        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
        private void onlyNumerics(object sender, KeyPressEventArgs e)
        {
            // Limit input to numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void packagingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            _selectedPackageId = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["idPackaging"].Value);
            _selectedPackageCapacity = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["capacity"].Value);
            _selectedPackagePrice = Convert.ToDecimal(packagesDataGridView.Rows[e.RowIndex].Cells["price"].Value);
            _selectedPackageQuantity = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["quantity"].Value);
            _selectedPackageCategory = packagesDataGridView.Rows[e.RowIndex].Cells["category"].Value.ToString();
            _selectedPackageCategoryId = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["idCategory"].Value);

            if (e.ColumnIndex == 7)
            {
                Package package = new Package(
                     _selectedPackageId,
                     _selectedPackageCapacity,
                     _selectedPackagePrice,
                     _selectedPackageCategoryId,
                     _selectedPackageQuantity
                     );
                //EditPackageForm editPackage = new EditPackageForm(package);
                //editPackage.ShowDialog(this);
            }
           

            if (e.ColumnIndex == 8)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ambalažu?\nNosivost: {_selectedPackageCapacity} grama\nKoličina: {_selectedPackageQuantity}\nKategorija: {_selectedPackageCategory}\nCena: {_selectedPackagePrice} RSD");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                // JA SAM KRALJ
                DbConnection.deleteFromDB("packaging", "id_packaging", _selectedPackageId);
                DbConnection.fillDGV(packagesDataGridView, _fillDGVQuery);
            }
        }
        //1+1
        private void insertPackageBtn_Click(object sender, EventArgs e)
        {
            //using CreatePackageForm createPackageForm = new CreatePackageForm();
            //createPackageForm.ShowDialog(this);
         
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchPackageTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchPackagesTxtBox.Text;
            (packagesDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Convert(`capacity`, 'System.String') LIKE '%{searchValue}%' OR Convert(`price`, 'System.String') LIKE '%{searchValue}%' OR `category_name` LIKE '%{searchValue}%'";
        }

    }
}
