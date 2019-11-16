namespace Freshivoje
{
    partial class RentPackagesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentPackagesForm));
            this.rentPackagesFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rentedPackagesDataGridView = new System.Windows.Forms.DataGridView();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.cratesCmbBox = new System.Windows.Forms.ComboBox();
            this.cratesTypeLbl = new System.Windows.Forms.Label();
            this.availablePackages = new System.Windows.Forms.Label();
            this.availablePackagesLbl = new System.Windows.Forms.Label();
            this.packagingPriceLbl = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.crateQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.crateQuantityLbl = new System.Windows.Forms.Label();
            this.finishRentPackagesBtn = new System.Windows.Forms.Button();
            this.rentPackagesBtn = new System.Windows.Forms.Button();
            this.packagingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPackagesFormTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedPackagesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rentPackagesFormTblLayout
            // 
            this.rentPackagesFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.rentPackagesFormTblLayout.ColumnCount = 9;
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.53982F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46018F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.rentPackagesFormTblLayout.Controls.Add(this.rentedPackagesDataGridView, 0, 6);
            this.rentPackagesFormTblLayout.Controls.Add(this.minimizeBtn, 7, 0);
            this.rentPackagesFormTblLayout.Controls.Add(this.exitBtn, 8, 0);
            this.rentPackagesFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.rentPackagesFormTblLayout.Controls.Add(this.backBtn, 6, 0);
            this.rentPackagesFormTblLayout.Controls.Add(this.cratesCmbBox, 1, 2);
            this.rentPackagesFormTblLayout.Controls.Add(this.cratesTypeLbl, 1, 1);
            this.rentPackagesFormTblLayout.Controls.Add(this.availablePackages, 4, 2);
            this.rentPackagesFormTblLayout.Controls.Add(this.availablePackagesLbl, 4, 1);
            this.rentPackagesFormTblLayout.Controls.Add(this.packagingPriceLbl, 5, 1);
            this.rentPackagesFormTblLayout.Controls.Add(this.price, 5, 2);
            this.rentPackagesFormTblLayout.Controls.Add(this.crateQuantityTxtBox, 2, 4);
            this.rentPackagesFormTblLayout.Controls.Add(this.crateQuantityLbl, 2, 3);
            this.rentPackagesFormTblLayout.Controls.Add(this.finishRentPackagesBtn, 2, 14);
            this.rentPackagesFormTblLayout.Controls.Add(this.rentPackagesBtn, 2, 5);
            this.rentPackagesFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentPackagesFormTblLayout.Location = new System.Drawing.Point(5, 5);
            this.rentPackagesFormTblLayout.Name = "rentPackagesFormTblLayout";
            this.rentPackagesFormTblLayout.RowCount = 15;
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rentPackagesFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rentPackagesFormTblLayout.Size = new System.Drawing.Size(1433, 873);
            this.rentPackagesFormTblLayout.TabIndex = 1;
            // 
            // rentedPackagesDataGridView
            // 
            this.rentedPackagesDataGridView.AllowUserToAddRows = false;
            this.rentedPackagesDataGridView.AllowUserToDeleteRows = false;
            this.rentedPackagesDataGridView.AllowUserToResizeColumns = false;
            this.rentedPackagesDataGridView.AllowUserToResizeRows = false;
            this.rentedPackagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.rentedPackagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentedPackagesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentedPackagesDataGridView.ColumnHeadersHeight = 40;
            this.rentedPackagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rentedPackagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packagingId,
            this.capacity,
            this.category,
            this.weight,
            this.producer,
            this.state,
            this.quantity,
            this.available,
            this.totalCost,
            this.deleteArticle});
            this.rentPackagesFormTblLayout.SetColumnSpan(this.rentedPackagesDataGridView, 9);
            this.rentedPackagesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rentedPackagesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.rentedPackagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentedPackagesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rentedPackagesDataGridView.Location = new System.Drawing.Point(3, 303);
            this.rentedPackagesDataGridView.MultiSelect = false;
            this.rentedPackagesDataGridView.Name = "rentedPackagesDataGridView";
            this.rentedPackagesDataGridView.ReadOnly = true;
            this.rentedPackagesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rentedPackagesDataGridView.RowHeadersWidth = 40;
            this.rentedPackagesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rentPackagesFormTblLayout.SetRowSpan(this.rentedPackagesDataGridView, 8);
            this.rentedPackagesDataGridView.RowTemplate.Height = 30;
            this.rentedPackagesDataGridView.Size = new System.Drawing.Size(1427, 506);
            this.rentedPackagesDataGridView.TabIndex = 34;
            this.rentedPackagesDataGridView.TabStop = false;
            this.rentedPackagesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.insertedArticlesDataGridView_CellContentClick);
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
            this.minimizeBtn.Location = new System.Drawing.Point(1327, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(44, 54);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
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
            this.exitBtn.Location = new System.Drawing.Point(1377, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(53, 54);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(407, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "IZNAJMLJIVANJE AMBALAŽA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.backBtn.Location = new System.Drawing.Point(1277, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 54);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cratesCmbBox
            // 
            this.rentPackagesFormTblLayout.SetColumnSpan(this.cratesCmbBox, 3);
            this.cratesCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cratesCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cratesCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cratesCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cratesCmbBox.FormattingEnabled = true;
            this.cratesCmbBox.Location = new System.Drawing.Point(153, 93);
            this.cratesCmbBox.Name = "cratesCmbBox";
            this.cratesCmbBox.Size = new System.Drawing.Size(708, 31);
            this.cratesCmbBox.TabIndex = 7;
            this.cratesCmbBox.TabStop = false;
            this.cratesCmbBox.SelectedIndexChanged += new System.EventHandler(this.cratesCmbBox_SelectedIndexChanged);
            // 
            // cratesTypeLbl
            // 
            this.cratesTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cratesTypeLbl.AutoSize = true;
            this.cratesTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.cratesTypeLbl, 3);
            this.cratesTypeLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cratesTypeLbl.ForeColor = System.Drawing.Color.White;
            this.cratesTypeLbl.Location = new System.Drawing.Point(172, 63);
            this.cratesTypeLbl.Name = "cratesTypeLbl";
            this.cratesTypeLbl.Size = new System.Drawing.Size(670, 27);
            this.cratesTypeLbl.TabIndex = 25;
            this.cratesTypeLbl.Text = "Nosivost (g) / Kategorija / Težina (g) / Proizvođač / Stanje";
            this.cratesTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availablePackages
            // 
            this.availablePackages.AutoSize = true;
            this.availablePackages.BackColor = System.Drawing.Color.Transparent;
            this.availablePackages.Dock = System.Windows.Forms.DockStyle.Top;
            this.availablePackages.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePackages.ForeColor = System.Drawing.Color.White;
            this.availablePackages.Location = new System.Drawing.Point(867, 90);
            this.availablePackages.Name = "availablePackages";
            this.availablePackages.Size = new System.Drawing.Size(179, 27);
            this.availablePackages.TabIndex = 42;
            this.availablePackages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availablePackagesLbl
            // 
            this.availablePackagesLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.availablePackagesLbl.AutoSize = true;
            this.availablePackagesLbl.BackColor = System.Drawing.Color.Transparent;
            this.availablePackagesLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablePackagesLbl.ForeColor = System.Drawing.Color.White;
            this.availablePackagesLbl.Location = new System.Drawing.Point(883, 63);
            this.availablePackagesLbl.Name = "availablePackagesLbl";
            this.availablePackagesLbl.Size = new System.Drawing.Size(147, 27);
            this.availablePackagesLbl.TabIndex = 41;
            this.availablePackagesLbl.Text = "Raspoloživo";
            this.availablePackagesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packagingPriceLbl
            // 
            this.packagingPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.packagingPriceLbl.AutoSize = true;
            this.packagingPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.packagingPriceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagingPriceLbl.ForeColor = System.Drawing.Color.White;
            this.packagingPriceLbl.Location = new System.Drawing.Point(1091, 63);
            this.packagingPriceLbl.Name = "packagingPriceLbl";
            this.packagingPriceLbl.Size = new System.Drawing.Size(140, 27);
            this.packagingPriceLbl.TabIndex = 43;
            this.packagingPriceLbl.Text = "Cena (RSD)";
            this.packagingPriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Dock = System.Windows.Forms.DockStyle.Top;
            this.price.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(1052, 90);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(219, 27);
            this.price.TabIndex = 44;
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crateQuantityTxtBox
            // 
            this.crateQuantityTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crateQuantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.crateQuantityTxtBox, 3);
            this.crateQuantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityTxtBox.Location = new System.Drawing.Point(568, 193);
            this.crateQuantityTxtBox.MaxLength = 8;
            this.crateQuantityTxtBox.Multiline = true;
            this.crateQuantityTxtBox.Name = "crateQuantityTxtBox";
            this.crateQuantityTxtBox.ShortcutsEnabled = false;
            this.crateQuantityTxtBox.Size = new System.Drawing.Size(287, 31);
            this.crateQuantityTxtBox.TabIndex = 0;
            this.crateQuantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // crateQuantityLbl
            // 
            this.crateQuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateQuantityLbl.AutoSize = true;
            this.crateQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.crateQuantityLbl, 3);
            this.crateQuantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.crateQuantityLbl.Location = new System.Drawing.Point(626, 163);
            this.crateQuantityLbl.Name = "crateQuantityLbl";
            this.crateQuantityLbl.Size = new System.Drawing.Size(171, 27);
            this.crateQuantityLbl.TabIndex = 24;
            this.crateQuantityLbl.Text = "Broj ambalaža";
            this.crateQuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishRentPackagesBtn
            // 
            this.finishRentPackagesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishRentPackagesBtn.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.finishRentPackagesBtn, 3);
            this.finishRentPackagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishRentPackagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishRentPackagesBtn.FlatAppearance.BorderSize = 5;
            this.finishRentPackagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishRentPackagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishRentPackagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishRentPackagesBtn.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.finishRentPackagesBtn.ForeColor = System.Drawing.Color.White;
            this.finishRentPackagesBtn.Location = new System.Drawing.Point(568, 817);
            this.finishRentPackagesBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishRentPackagesBtn.Name = "finishRentPackagesBtn";
            this.finishRentPackagesBtn.Size = new System.Drawing.Size(287, 50);
            this.finishRentPackagesBtn.TabIndex = 40;
            this.finishRentPackagesBtn.TabStop = false;
            this.finishRentPackagesBtn.Text = "Završi iznajmljivanje";
            this.finishRentPackagesBtn.UseVisualStyleBackColor = false;
            this.finishRentPackagesBtn.Click += new System.EventHandler(this.finishInsertBtn_Click);
            // 
            // rentPackagesBtn
            // 
            this.rentPackagesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rentPackagesBtn.BackColor = System.Drawing.Color.Transparent;
            this.rentPackagesFormTblLayout.SetColumnSpan(this.rentPackagesBtn, 3);
            this.rentPackagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentPackagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rentPackagesBtn.FlatAppearance.BorderSize = 5;
            this.rentPackagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rentPackagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rentPackagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentPackagesBtn.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.rentPackagesBtn.ForeColor = System.Drawing.Color.White;
            this.rentPackagesBtn.Location = new System.Drawing.Point(568, 245);
            this.rentPackagesBtn.Margin = new System.Windows.Forms.Padding(5);
            this.rentPackagesBtn.Name = "rentPackagesBtn";
            this.rentPackagesBtn.Size = new System.Drawing.Size(287, 50);
            this.rentPackagesBtn.TabIndex = 30;
            this.rentPackagesBtn.TabStop = false;
            this.rentPackagesBtn.Text = "Iznajmi ambalaže";
            this.rentPackagesBtn.UseVisualStyleBackColor = false;
            this.rentPackagesBtn.Click += new System.EventHandler(this.rentPackagesBtn_Click);
            // 
            // packagingId
            // 
            this.packagingId.HeaderText = "ID ambalaže";
            this.packagingId.Name = "packagingId";
            this.packagingId.ReadOnly = true;
            this.packagingId.Visible = false;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.HeaderText = "Nosivost (g)";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.HeaderText = "Kategorija";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weight.HeaderText = "Težina (g)";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // producer
            // 
            this.producer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producer.HeaderText = "Proizvođač";
            this.producer.Name = "producer";
            this.producer.ReadOnly = true;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.state.HeaderText = "Stanje";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "Količina";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // available
            // 
            this.available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.available.HeaderText = "Raspoloživo";
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.Width = 172;
            // 
            // totalCost
            // 
            this.totalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalCost.HeaderText = "Ukupna cena (RSD)";
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            this.totalCost.Width = 252;
            // 
            // deleteArticle
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "X";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteArticle.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteArticle.HeaderText = "";
            this.deleteArticle.Name = "deleteArticle";
            this.deleteArticle.ReadOnly = true;
            this.deleteArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteArticle.Width = 40;
            // 
            // RentPackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 883);
            this.Controls.Add(this.rentPackagesFormTblLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentPackagesForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNOS ARTIKALA";
            this.rentPackagesFormTblLayout.ResumeLayout(false);
            this.rentPackagesFormTblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedPackagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rentPackagesFormTblLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox crateQuantityTxtBox;
        private System.Windows.Forms.Label crateQuantityLbl;
        private System.Windows.Forms.Label cratesTypeLbl;
        private System.Windows.Forms.Button rentPackagesBtn;
        private System.Windows.Forms.ComboBox cratesCmbBox;
        private System.Windows.Forms.DataGridView rentedPackagesDataGridView;
        private System.Windows.Forms.Button finishRentPackagesBtn;
        private System.Windows.Forms.Label availablePackagesLbl;
        private System.Windows.Forms.Label availablePackages;
        private System.Windows.Forms.Label packagingPriceLbl;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DataGridViewTextBoxColumn packagingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn available;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteArticle;
    }
}