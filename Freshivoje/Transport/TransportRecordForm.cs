using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshivoje.Transport
{
    public partial class TransportRecordForm : Form
    {
        private int _selectedTransportId;
        private readonly string _fillDGVQuery = "SELECT " +
            "CONCAT(`clients`.`first_name`,' ',`clients`.`last_name`) as client, `clients`.`id_client` as fk_client_id,`transport`.`id_transport`, `transport`.`transport_date`" +
            "FROM `transport` INNER JOIN `clients` ON `clients`.`id_client` = `transport`.`fk_client_id`  WHERE `transport`.`transport_status` = '1' AND `transport`.`transport_year` = '" + DateTime.Today.ToString("yyyy") + "'";

        public TransportRecordForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TransportDataGridView.AutoGenerateColumns = false;
            DbConnection.fillDGV(TransportDataGridView, _fillDGVQuery);
        }

        private void crudArticlesFormTblLayout_Paint(object sender, PaintEventArgs e)
        {

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
        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            _selectedTransportId = Convert.ToInt32(TransportDataGridView.Rows[e.RowIndex].Cells["transportId"].Value);

            if (e.ColumnIndex == 8)
            {
                using TransportForm transportForm = new TransportForm(_selectedTransportId);
                transportForm.ShowDialog(this);
            }
        }
        private void searchTransportxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchTransportTxtBox.Text;
            (TransportDataGridView.DataSource as DataTable).DefaultView.RowFilter = @$"Convert(`transport_date`, 'System.String') LIKE '%{searchValue}%' 
                                                                                    OR `client` LIKE '%{searchValue}%'";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
