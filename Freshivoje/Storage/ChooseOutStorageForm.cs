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
    public partial class ChooseOutStorageForm : Form
    {
        int _storageId;
        public ChooseOutStorageForm(int storageId)
        {
            _storageId = storageId;
            InitializeComponent();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
