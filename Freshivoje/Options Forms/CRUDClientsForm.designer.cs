namespace Freshivoje.Options_Forms
{
    partial class CRUDClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDClientsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchClientsLbl = new System.Windows.Forms.Label();
            this.searchClientsTxtBox = new System.Windows.Forms.TextBox();
            this.insertClientBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.crudClientsFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.crudClientsFormTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToResizeColumns = false;
            this.clientsDataGridView.AllowUserToResizeRows = false;
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.ColumnHeadersHeight = 60;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientId,
            this.clientFirstName,
            this.clientLastName,
            this.clientAddress,
            this.clientType,
            this.clientCompanyName,
            this.clientJMBG,
            this.clientPIB,
            this.clientBPG,
            this.clientSPO,
            this.clientZipCode,
            this.clientBankAccount,
            this.clientPhone,
            this.editClient,
            this.deleteClient});
            this.crudClientsFormTblLayout.SetColumnSpan(this.clientsDataGridView, 6);
            this.clientsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientsDataGridView.Location = new System.Drawing.Point(153, 255);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.clientsDataGridView.RowHeadersWidth = 40;
            this.clientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.crudClientsFormTblLayout.SetRowSpan(this.clientsDataGridView, 10);
            this.clientsDataGridView.RowTemplate.Height = 40;
            this.clientsDataGridView.Size = new System.Drawing.Size(1770, 623);
            this.clientsDataGridView.TabIndex = 58;
            this.clientsDataGridView.TabStop = false;
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // searchClientsLbl
            // 
            this.searchClientsLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchClientsLbl.AutoSize = true;
            this.searchClientsLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchClientsLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientsLbl.ForeColor = System.Drawing.Color.White;
            this.searchClientsLbl.Location = new System.Drawing.Point(1672, 162);
            this.searchClientsLbl.Name = "searchClientsLbl";
            this.searchClientsLbl.Size = new System.Drawing.Size(211, 27);
            this.searchClientsLbl.TabIndex = 57;
            this.searchClientsLbl.Text = "Pretraga klijenata";
            this.searchClientsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchClientsTxtBox
            // 
            this.searchClientsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchClientsTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchClientsTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientsTxtBox.Location = new System.Drawing.Point(1633, 192);
            this.searchClientsTxtBox.Multiline = true;
            this.searchClientsTxtBox.Name = "searchClientsTxtBox";
            this.searchClientsTxtBox.ShortcutsEnabled = false;
            this.searchClientsTxtBox.Size = new System.Drawing.Size(290, 31);
            this.searchClientsTxtBox.TabIndex = 11;
            this.searchClientsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            this.searchClientsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchClientsTxtBox_KeyPress);
            // 
            // insertClientBtn
            // 
            this.insertClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.insertClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertClientBtn.FlatAppearance.BorderSize = 5;
            this.insertClientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertClientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertClientBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertClientBtn.ForeColor = System.Drawing.Color.White;
            this.insertClientBtn.Location = new System.Drawing.Point(191, 192);
            this.insertClientBtn.Name = "insertClientBtn";
            this.insertClientBtn.Size = new System.Drawing.Size(213, 57);
            this.insertClientBtn.TabIndex = 37;
            this.insertClientBtn.TabStop = false;
            this.insertClientBtn.Text = "Kreiraj klijenta";
            this.insertClientBtn.UseVisualStyleBackColor = false;
            this.insertClientBtn.Click += new System.EventHandler(this.insertClientBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = global::Freshivoje.Properties.Resources.left_arrow;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1929, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 57);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.crudClientsFormTblLayout.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(276, 63);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "OPCIJE KLIJENATA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = global::Freshivoje.Properties.Resources.x;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(2029, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(49, 57);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BackgroundImage = global::Freshivoje.Properties.Resources.minimize;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(1979, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(44, 57);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // crudClientsFormTblLayout
            // 
            this.crudClientsFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.crudClientsFormTblLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("crudClientsFormTblLayout.BackgroundImage")));
            this.crudClientsFormTblLayout.ColumnCount = 10;
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.crudClientsFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.crudClientsFormTblLayout.Controls.Add(this.minimizeBtn, 8, 0);
            this.crudClientsFormTblLayout.Controls.Add(this.exitBtn, 9, 0);
            this.crudClientsFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.crudClientsFormTblLayout.Controls.Add(this.backBtn, 7, 0);
            this.crudClientsFormTblLayout.Controls.Add(this.searchClientsTxtBox, 6, 3);
            this.crudClientsFormTblLayout.Controls.Add(this.clientsDataGridView, 1, 4);
            this.crudClientsFormTblLayout.Controls.Add(this.searchClientsLbl, 6, 2);
            this.crudClientsFormTblLayout.Controls.Add(this.insertClientBtn, 1, 3);
            this.crudClientsFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudClientsFormTblLayout.ForeColor = System.Drawing.Color.White;
            this.crudClientsFormTblLayout.Location = new System.Drawing.Point(5, 5);
            this.crudClientsFormTblLayout.Name = "crudClientsFormTblLayout";
            this.crudClientsFormTblLayout.RowCount = 17;
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.243339F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.437748F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.887928F));
            this.crudClientsFormTblLayout.Size = new System.Drawing.Size(2081, 1074);
            this.crudClientsFormTblLayout.TabIndex = 3;
            // 
            // clientId
            // 
            this.clientId.DataPropertyName = "id_client";
            this.clientId.HeaderText = "ID";
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            this.clientId.Visible = false;
            // 
            // clientFirstName
            // 
            this.clientFirstName.DataPropertyName = "first_name";
            this.clientFirstName.HeaderText = "Ime";
            this.clientFirstName.Name = "clientFirstName";
            this.clientFirstName.ReadOnly = true;
            // 
            // clientLastName
            // 
            this.clientLastName.DataPropertyName = "last_name";
            this.clientLastName.HeaderText = "Prezime";
            this.clientLastName.Name = "clientLastName";
            this.clientLastName.ReadOnly = true;
            // 
            // clientAddress
            // 
            this.clientAddress.DataPropertyName = "address";
            this.clientAddress.HeaderText = "Adresa";
            this.clientAddress.Name = "clientAddress";
            this.clientAddress.ReadOnly = true;
            // 
            // clientType
            // 
            this.clientType.DataPropertyName = "type";
            this.clientType.HeaderText = "Tip";
            this.clientType.Name = "clientType";
            this.clientType.ReadOnly = true;
            // 
            // clientCompanyName
            // 
            this.clientCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clientCompanyName.DataPropertyName = "company_name";
            this.clientCompanyName.HeaderText = "Naziv firme";
            this.clientCompanyName.Name = "clientCompanyName";
            this.clientCompanyName.ReadOnly = true;
            this.clientCompanyName.Width = 142;
            // 
            // clientJMBG
            // 
            this.clientJMBG.DataPropertyName = "JMBG";
            this.clientJMBG.HeaderText = "JMBG";
            this.clientJMBG.Name = "clientJMBG";
            this.clientJMBG.ReadOnly = true;
            // 
            // clientPIB
            // 
            this.clientPIB.DataPropertyName = "PIB";
            this.clientPIB.HeaderText = "PIB";
            this.clientPIB.Name = "clientPIB";
            this.clientPIB.ReadOnly = true;
            // 
            // clientBPG
            // 
            this.clientBPG.DataPropertyName = "BPG";
            this.clientBPG.HeaderText = "BPG";
            this.clientBPG.Name = "clientBPG";
            this.clientBPG.ReadOnly = true;
            // 
            // clientSPO
            // 
            this.clientSPO.DataPropertyName = "SPO";
            this.clientSPO.HeaderText = "ŠPO";
            this.clientSPO.Name = "clientSPO";
            this.clientSPO.ReadOnly = true;
            // 
            // clientZipCode
            // 
            this.clientZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clientZipCode.DataPropertyName = "zip_code";
            this.clientZipCode.HeaderText = "Poštanski broj";
            this.clientZipCode.Name = "clientZipCode";
            this.clientZipCode.ReadOnly = true;
            this.clientZipCode.Width = 172;
            // 
            // clientBankAccount
            // 
            this.clientBankAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clientBankAccount.DataPropertyName = "bank_account";
            this.clientBankAccount.HeaderText = "Bankovni račun";
            this.clientBankAccount.Name = "clientBankAccount";
            this.clientBankAccount.ReadOnly = true;
            this.clientBankAccount.Width = 181;
            // 
            // clientPhone
            // 
            this.clientPhone.DataPropertyName = "phone";
            this.clientPhone.HeaderText = "Telefon";
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.ReadOnly = true;
            // 
            // editClient
            // 
            this.editClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "✎";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.editClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.editClient.HeaderText = "";
            this.editClient.Name = "editClient";
            this.editClient.ReadOnly = true;
            this.editClient.Width = 40;
            // 
            // deleteClient
            // 
            this.deleteClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "X";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.deleteClient.HeaderText = "";
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.ReadOnly = true;
            this.deleteClient.Width = 40;
            // 
            // CRUDClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2091, 1084);
            this.Controls.Add(this.crudClientsFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDClientsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcije klijenata";
            this.Activated += new System.EventHandler(this.CRUDClientsForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.crudClientsFormTblLayout.ResumeLayout(false);
            this.crudClientsFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.TableLayoutPanel crudClientsFormTblLayout;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchClientsTxtBox;
        private System.Windows.Forms.Label searchClientsLbl;
        private System.Windows.Forms.Button insertClientBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn editClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteClient;
    }
}