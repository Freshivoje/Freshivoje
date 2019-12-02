using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshivoje.Storage
{
    public partial class InsertPackagingStorageForm : Form
    {
        int _storageId;
        public InsertPackagingStorageForm(int storageId)
        {
            InitializeComponent();
            _storageId = storageId;
        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
