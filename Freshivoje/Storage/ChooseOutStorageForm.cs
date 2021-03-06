﻿using System;
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
            if(_storageId == 9)
            {
                titleLbl.Text = "TUNEL";
                insertBtn.Text = "PRODAJA";
            }
            else
            {
                insertBtn.Text = "IZLAZ";
                titleLbl.Text = "PRODAJA";
            }
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

        private void recordBtn_Click(object sender, EventArgs e)
        {
            if (_storageId == 9)
            {
                Hide();
                using InsertStorageForm insertStorageForm = new InsertStorageForm(_storageId);
                insertStorageForm.ShowDialog(this);
                Show();
            }
            else
            {
                Hide();
                using OutStorageForm outStorageForm = new OutStorageForm(_storageId);
                outStorageForm.ShowDialog(this);
                Show();
            }
         
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using RecordStorageForm recordStorageForm = new RecordStorageForm(_storageId);
            recordStorageForm.ShowDialog(this);
            Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
