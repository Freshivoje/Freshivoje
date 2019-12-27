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
        private readonly string _fillDGVQuery = "SELECT * FROM `packaging`";
        private string _selectedPackageCategory, _selectedPackageProducer, _selectedPackageStatus;
        private decimal _selectedPackagePrice;
        private int _selectedPackageId, _selectedPackageCapacity, _selectedPackageQuantity, _selectedPackageWeight;
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

            _selectedPackageId = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["idPackaging"].Value);
            _selectedPackageCapacity = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["capacity"].Value);
            _selectedPackagePrice = Convert.ToDecimal(packagesDataGridView.Rows[e.RowIndex].Cells["price"].Value);
            _selectedPackageQuantity = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["quantity"].Value);
            _selectedPackageCategory = packagesDataGridView.Rows[e.RowIndex].Cells["category"].Value.ToString();
            _selectedPackageWeight = Convert.ToInt32(packagesDataGridView.Rows[e.RowIndex].Cells["weight"].Value); //baca gresku
            _selectedPackageProducer = packagesDataGridView.Rows[e.RowIndex].Cells["producer"].Value.ToString();
            _selectedPackageStatus = packagesDataGridView.Rows[e.RowIndex].Cells["status"].Value.ToString();


            if (e.ColumnIndex == 8)
            {
                Package package = new Package(
                     _selectedPackageId,
                     _selectedPackageCapacity,
                     _selectedPackagePrice,
                     _selectedPackageCategory,
                     _selectedPackageQuantity,
                     _selectedPackageWeight,
                     _selectedPackageProducer,
                     _selectedPackageStatus
                     );
                using EditPackageForm editPackage = new EditPackageForm(package);
                editPackage.ShowDialog(this);
            }
           

            if (e.ColumnIndex == 9)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete ambalažu?\nNosivost: {_selectedPackageCapacity} grama\nKoličina: {_selectedPackageQuantity}\nKategorija: {_selectedPackageCategory}\nCena: {_selectedPackagePrice} RSD\nTežina: {_selectedPackageWeight}grama\nProizvođač: {_selectedPackageProducer}\nStatus: {_selectedPackageStatus}");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                DbConnection.deleteFromDB("packaging", "id_packaging", _selectedPackageId);
                DbConnection.fillDGV(packagesDataGridView, _fillDGVQuery);
            }
        }

        private void createPackageBtn_Click(object sender, EventArgs e)
        {
            using CreatePackageForm createPackageForm = new CreatePackageForm();
            createPackageForm.ShowDialog(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchPackageTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchPackagesTxtBox.Text.Replace('\'', (char)0x2019); // &rsquo; 
            (packagesDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`capacity`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR Convert(`price`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `category` LIKE '%{searchValue}%' 
                                                                                    OR Convert(`quantity`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR Convert(`weight`, 'System.String') LIKE '%{searchValue}%'
                                                                                    OR `producer` LIKE '%{searchValue}%'
                                                                                    OR `status` LIKE '%{searchValue}%'";

        }

    }
}
