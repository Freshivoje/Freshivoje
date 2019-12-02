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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {   
            using ChooseInsertStorageMethodForm chooseInsertStorageMethodForm = new ChooseInsertStorageMethodForm(storageId);
            chooseInsertStorageMethodForm.ShowDialog(this);
            Show();
        }

     

        private void recordBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using RecordStorageForm recordStorageForm = new RecordStorageForm();
            recordStorageForm.ShowDialog(this);
            Show();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using OutStorageForm outStorageForm = new OutStorageForm();
            outStorageForm.ShowDialog(this);
            Show();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
