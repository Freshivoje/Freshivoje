﻿using System;
using System.Windows.Forms;
using Freshivoje;
using Freshivoje.Shared_Forms;


namespace Freshivoje
{
    public partial class ChooseInsertMethodForm : Form
    {
        public ChooseInsertMethodForm()
        {
            InitializeComponent();
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
        private void repurchaseBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseClientForm chooseClientForm = new ChooseClientForm("InsertForm");
            chooseClientForm.ShowDialog(this);
            if (!IsDisposed)
            {
                Show();
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void storageRentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            using ChooseStorageRentingMethodForm chooseStorageRentingMethodForm = new ChooseStorageRentingMethodForm();
            chooseStorageRentingMethodForm.ShowDialog(this);
            if (!IsDisposed) 
            { 
                Show();
            }
        }
    }
}
