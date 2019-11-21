using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Freshivoje.Storage
{
    public partial class ChooseStorageMethodForm : Form
    {
        int storageId;
        public ChooseStorageMethodForm(int _storageId)
        {
            storageId = _storageId;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM storage WHERE id_storage ='"+_storageId+"'";
            dynamic storageData = DbConnection.getStorageData(cmd, _storageId);
            InitializeComponent();
            titleLbl.Text = "KOMORA " + storageData.getName();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
