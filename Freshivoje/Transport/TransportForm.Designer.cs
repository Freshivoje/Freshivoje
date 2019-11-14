namespace Freshivoje.Transport
{
    partial class TransportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crateQuantityLbl = new System.Windows.Forms.Label();
            this.travelTxtBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.finishInsertBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.insertedArticlesLbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.transportDataGridView = new System.Windows.Forms.DataGridView();
            this.insertFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).BeginInit();
            this.insertFormTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // crateQuantityLbl
            // 
            this.crateQuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateQuantityLbl.AutoSize = true;
            this.crateQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.crateQuantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.crateQuantityLbl.Location = new System.Drawing.Point(1615, 193);
            this.crateQuantityLbl.Name = "crateQuantityLbl";
            this.crateQuantityLbl.Size = new System.Drawing.Size(115, 27);
            this.crateQuantityLbl.TabIndex = 24;
            this.crateQuantityLbl.Text = "Kilometri";
            this.crateQuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // travelTxtBox
            // 
            this.travelTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.travelTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.travelTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelTxtBox.Location = new System.Drawing.Point(1371, 223);
            this.travelTxtBox.Multiline = true;
            this.travelTxtBox.Name = "travelTxtBox";
            this.travelTxtBox.ShortcutsEnabled = false;
            this.travelTxtBox.Size = new System.Drawing.Size(603, 31);
            this.travelTxtBox.TabIndex = 6;
            this.travelTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
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
            this.backBtn.Location = new System.Drawing.Point(1980, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 49);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // finishInsertBtn
            // 
            this.finishInsertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.finishInsertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.finishInsertBtn, 3);
            this.finishInsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishInsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishInsertBtn.FlatAppearance.BorderSize = 5;
            this.finishInsertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInsertBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishInsertBtn.ForeColor = System.Drawing.Color.White;
            this.finishInsertBtn.Location = new System.Drawing.Point(964, 717);
            this.finishInsertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishInsertBtn.Name = "finishInsertBtn";
            this.finishInsertBtn.Size = new System.Drawing.Size(198, 45);
            this.finishInsertBtn.TabIndex = 31;
            this.finishInsertBtn.TabStop = false;
            this.finishInsertBtn.Text = "Završi unos";
            this.finishInsertBtn.UseVisualStyleBackColor = false;
            this.finishInsertBtn.Click += new System.EventHandler(this.finishInsertBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.insertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.insertBtn, 3);
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 5;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(1035, 280);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(56, 45);
            this.insertBtn.TabIndex = 30;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "+";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // insertedArticlesLbl
            // 
            this.insertedArticlesLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertedArticlesLbl.AutoSize = true;
            this.insertedArticlesLbl.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.insertedArticlesLbl, 3);
            this.insertedArticlesLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertedArticlesLbl.ForeColor = System.Drawing.Color.White;
            this.insertedArticlesLbl.Location = new System.Drawing.Point(1025, 358);
            this.insertedArticlesLbl.Name = "insertedArticlesLbl";
            this.insertedArticlesLbl.Size = new System.Drawing.Size(77, 27);
            this.insertedArticlesLbl.TabIndex = 29;
            this.insertedArticlesLbl.Text = "Uneti ";
            this.insertedArticlesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(575, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PLAĆANJE NADOKNADE ZA TRANSPORTA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtBox.Location = new System.Drawing.Point(762, 223);
            this.quantityTxtBox.Multiline = true;
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.ShortcutsEnabled = false;
            this.quantityTxtBox.Size = new System.Drawing.Size(603, 31);
            this.quantityTxtBox.TabIndex = 5;
            this.quantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(153, 223);
            this.priceTxtBox.Multiline = true;
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.ShortcutsEnabled = false;
            this.priceTxtBox.Size = new System.Drawing.Size(603, 31);
            this.priceTxtBox.TabIndex = 4;
            this.priceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(986, 193);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(154, 27);
            this.quantityLbl.TabIndex = 17;
            this.quantityLbl.Text = "Količina (kg)";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(301, 193);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(306, 27);
            this.priceLbl.TabIndex = 16;
            this.priceLbl.Text = "Cena (dinari) po kilometru";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.exitBtn.Location = new System.Drawing.Point(2080, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(50, 49);
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
            this.minimizeBtn.Location = new System.Drawing.Point(2030, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(44, 49);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // transportDataGridView
            // 
            this.transportDataGridView.AllowUserToAddRows = false;
            this.transportDataGridView.AllowUserToDeleteRows = false;
            this.transportDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.transportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transportDataGridView.ColumnHeadersHeight = 40;
            this.transportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.price,
            this.Količina,
            this.Kilometri,
            this.UkupnaCena});
            this.insertFormTblLayout.SetColumnSpan(this.transportDataGridView, 3);
            this.transportDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.transportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transportDataGridView.Location = new System.Drawing.Point(153, 441);
            this.transportDataGridView.MultiSelect = false;
            this.transportDataGridView.Name = "transportDataGridView";
            this.transportDataGridView.ReadOnly = true;
            this.transportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transportDataGridView.RowHeadersWidth = 40;
            this.transportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.insertFormTblLayout.SetRowSpan(this.transportDataGridView, 4);
            this.transportDataGridView.RowTemplate.Height = 30;
            this.transportDataGridView.Size = new System.Drawing.Size(1821, 213);
            this.transportDataGridView.TabIndex = 34;
            this.transportDataGridView.TabStop = false;
            this.transportDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transportDataGridView_CellContentClick);
            // 
            // insertFormTblLayout
            // 
            this.insertFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.insertFormTblLayout.ColumnCount = 7;
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.insertFormTblLayout.Controls.Add(this.transportDataGridView, 1, 8);
            this.insertFormTblLayout.Controls.Add(this.minimizeBtn, 5, 0);
            this.insertFormTblLayout.Controls.Add(this.exitBtn, 6, 0);
            this.insertFormTblLayout.Controls.Add(this.priceLbl, 1, 3);
            this.insertFormTblLayout.Controls.Add(this.quantityLbl, 2, 3);
            this.insertFormTblLayout.Controls.Add(this.priceTxtBox, 1, 4);
            this.insertFormTblLayout.Controls.Add(this.quantityTxtBox, 2, 4);
            this.insertFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.insertFormTblLayout.Controls.Add(this.backBtn, 4, 0);
            this.insertFormTblLayout.Controls.Add(this.travelTxtBox, 3, 4);
            this.insertFormTblLayout.Controls.Add(this.crateQuantityLbl, 3, 3);
            this.insertFormTblLayout.Controls.Add(this.insertBtn, 1, 5);
            this.insertFormTblLayout.Controls.Add(this.insertedArticlesLbl, 1, 6);
            this.insertFormTblLayout.Controls.Add(this.finishInsertBtn, 1, 13);
            this.insertFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.insertFormTblLayout.Name = "insertFormTblLayout";
            this.insertFormTblLayout.RowCount = 15;
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.466885F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.107748F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.190619F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68623F));
            this.insertFormTblLayout.Size = new System.Drawing.Size(2133, 830);
            this.insertFormTblLayout.TabIndex = 2;
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "ID";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Visible = false;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "_price";
            this.price.HeaderText = "Jedinična Cena";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Količina.DataPropertyName = "_quantity";
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // Kilometri
            // 
            this.Kilometri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kilometri.DataPropertyName = "_traveled";
            this.Kilometri.HeaderText = "Kilometri";
            this.Kilometri.Name = "Kilometri";
            this.Kilometri.ReadOnly = true;
            // 
            // UkupnaCena
            // 
            this.UkupnaCena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupnaCena.DataPropertyName = "_totalPrice";
            this.UkupnaCena.HeaderText = "Ukupna Cena";
            this.UkupnaCena.Name = "UkupnaCena";
            this.UkupnaCena.ReadOnly = true;
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 830);
            this.Controls.Add(this.insertFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportForm";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).EndInit();
            this.insertFormTblLayout.ResumeLayout(false);
            this.insertFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label crateQuantityLbl;
        private System.Windows.Forms.TextBox travelTxtBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button finishInsertBtn;
        private System.Windows.Forms.TableLayoutPanel insertFormTblLayout;
        private System.Windows.Forms.DataGridView transportDataGridView;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label insertedArticlesLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometri;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCena;
    }
}