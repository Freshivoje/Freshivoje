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
    public partial class ChooseStorageMethodForm : Form
    {
        int storageId;
        public ChooseStorageMethodForm(int _storageId)
        {
            storageId = _storageId;
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
