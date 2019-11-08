namespace Freshivoje
{
    partial class InsertForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.insertFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.articlesDataGridView = new System.Windows.Forms.DataGridView();
            this.articleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleOrganic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articlePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.articlesCmbBox = new System.Windows.Forms.ComboBox();
            this.articleCategoryCmbBox = new System.Windows.Forms.ComboBox();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.insertedArticlesLbl = new System.Windows.Forms.Label();
            this.finishInsertBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.articleLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.articlePriceLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.crateOwnerCmbBox = new System.Windows.Forms.ComboBox();
            this.crateOwnerLbl = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.packageTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.crateTypeLbl = new System.Windows.Forms.Label();
            this.crateQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.crateQuantityLbl = new System.Windows.Forms.Label();
            this.cratesLbl = new System.Windows.Forms.Label();
            this.insertFormTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertFormTblLayout
            // 
            this.insertFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.insertFormTblLayout.ColumnCount = 8;
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.insertFormTblLayout.Controls.Add(this.articlesDataGridView, 1, 10);
            this.insertFormTblLayout.Controls.Add(this.minimizeBtn, 6, 0);
            this.insertFormTblLayout.Controls.Add(this.exitBtn, 7, 0);
            this.insertFormTblLayout.Controls.Add(this.articlesCmbBox, 1, 2);
            this.insertFormTblLayout.Controls.Add(this.articleCategoryCmbBox, 4, 2);
            this.insertFormTblLayout.Controls.Add(this.quantityTxtBox, 2, 4);
            this.insertFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.insertFormTblLayout.Controls.Add(this.insertedArticlesLbl, 2, 9);
            this.insertFormTblLayout.Controls.Add(this.finishInsertBtn, 2, 13);
            this.insertFormTblLayout.Controls.Add(this.backBtn, 5, 0);
            this.insertFormTblLayout.Controls.Add(this.categoryLbl, 4, 1);
            this.insertFormTblLayout.Controls.Add(this.articleLbl, 1, 1);
            this.insertFormTblLayout.Controls.Add(this.priceLbl, 1, 3);
            this.insertFormTblLayout.Controls.Add(this.articlePriceLbl, 1, 4);
            this.insertFormTblLayout.Controls.Add(this.quantityLbl, 2, 3);
            this.insertFormTblLayout.Controls.Add(this.crateOwnerCmbBox, 1, 8);
            this.insertFormTblLayout.Controls.Add(this.crateOwnerLbl, 1, 7);
            this.insertFormTblLayout.Controls.Add(this.insertBtn, 1, 9);
            this.insertFormTblLayout.Controls.Add(this.packageTypeCmbBox, 2, 8);
            this.insertFormTblLayout.Controls.Add(this.crateTypeLbl, 2, 7);
            this.insertFormTblLayout.Controls.Add(this.crateQuantityTxtBox, 4, 8);
            this.insertFormTblLayout.Controls.Add(this.crateQuantityLbl, 4, 7);
            this.insertFormTblLayout.Controls.Add(this.cratesLbl, 2, 6);
            this.insertFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertFormTblLayout.Location = new System.Drawing.Point(5, 5);
            this.insertFormTblLayout.Name = "insertFormTblLayout";
            this.insertFormTblLayout.RowCount = 15;
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.461607F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.101947F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.185567F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.680773F));
            this.insertFormTblLayout.Size = new System.Drawing.Size(1433, 873);
            this.insertFormTblLayout.TabIndex = 1;
            // 
            // articlesDataGridView
            // 
            this.articlesDataGridView.AllowUserToAddRows = false;
            this.articlesDataGridView.AllowUserToDeleteRows = false;
            this.articlesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.articlesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articlesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articlesDataGridView.ColumnHeadersHeight = 40;
            this.articlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articlesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleId,
            this.idCategory,
            this.fkCategoryId,
            this.articleName,
            this.articleSort,
            this.articleCategory,
            this.articleOrganic,
            this.articlePrice,
            this.updateArticle,
            this.deleteArticle});
            this.insertFormTblLayout.SetColumnSpan(this.articlesDataGridView, 4);
            this.articlesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articlesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.articlesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.articlesDataGridView.Location = new System.Drawing.Point(153, 581);
            this.articlesDataGridView.MultiSelect = false;
            this.articlesDataGridView.Name = "articlesDataGridView";
            this.articlesDataGridView.ReadOnly = true;
            this.articlesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.articlesDataGridView.RowHeadersWidth = 40;
            this.articlesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.insertFormTblLayout.SetRowSpan(this.articlesDataGridView, 3);
            this.articlesDataGridView.RowTemplate.Height = 30;
            this.articlesDataGridView.Size = new System.Drawing.Size(1122, 168);
            this.articlesDataGridView.TabIndex = 34;
            this.articlesDataGridView.TabStop = false;
            // 
            // articleId
            // 
            this.articleId.DataPropertyName = "id_article";
            this.articleId.HeaderText = "ID";
            this.articleId.Name = "articleId";
            this.articleId.ReadOnly = true;
            this.articleId.Visible = false;
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "id_category";
            this.idCategory.HeaderText = "ID Kategorije";
            this.idCategory.Name = "idCategory";
            this.idCategory.ReadOnly = true;
            this.idCategory.Visible = false;
            // 
            // fkCategoryId
            // 
            this.fkCategoryId.DataPropertyName = "fk_category_id";
            this.fkCategoryId.HeaderText = "FK ID Kategorije";
            this.fkCategoryId.Name = "fkCategoryId";
            this.fkCategoryId.ReadOnly = true;
            this.fkCategoryId.Visible = false;
            // 
            // articleName
            // 
            this.articleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articleName.DataPropertyName = "article_name";
            this.articleName.HeaderText = "Ime";
            this.articleName.Name = "articleName";
            this.articleName.ReadOnly = true;
            // 
            // articleSort
            // 
            this.articleSort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articleSort.DataPropertyName = "sort";
            this.articleSort.HeaderText = "Sorta";
            this.articleSort.Name = "articleSort";
            this.articleSort.ReadOnly = true;
            // 
            // articleCategory
            // 
            this.articleCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articleCategory.DataPropertyName = "category_name";
            this.articleCategory.HeaderText = "Kategorija";
            this.articleCategory.Name = "articleCategory";
            this.articleCategory.ReadOnly = true;
            // 
            // articleOrganic
            // 
            this.articleOrganic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.articleOrganic.DataPropertyName = "organic";
            this.articleOrganic.HeaderText = "Kontrolisana proizvodnja";
            this.articleOrganic.Name = "articleOrganic";
            this.articleOrganic.ReadOnly = true;
            this.articleOrganic.Width = 317;
            // 
            // articlePrice
            // 
            this.articlePrice.DataPropertyName = "value";
            this.articlePrice.HeaderText = "Cena";
            this.articlePrice.Name = "articlePrice";
            this.articlePrice.ReadOnly = true;
            // 
            // updateArticle
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "✎";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.updateArticle.DefaultCellStyle = dataGridViewCellStyle2;
            this.updateArticle.HeaderText = "";
            this.updateArticle.Name = "updateArticle";
            this.updateArticle.ReadOnly = true;
            this.updateArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.updateArticle.Width = 40;
            // 
            // deleteArticle
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "X";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteArticle.DefaultCellStyle = dataGridViewCellStyle3;
            this.deleteArticle.HeaderText = "";
            this.deleteArticle.Name = "deleteArticle";
            this.deleteArticle.ReadOnly = true;
            this.deleteArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteArticle.Width = 40;
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
            this.minimizeBtn.Location = new System.Drawing.Point(1331, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(44, 52);
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
            this.exitBtn.Location = new System.Drawing.Point(1381, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(49, 52);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // articlesCmbBox
            // 
            this.articlesCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.insertFormTblLayout.SetColumnSpan(this.articlesCmbBox, 3);
            this.articlesCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articlesCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.articlesCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlesCmbBox.FormattingEnabled = true;
            this.articlesCmbBox.Location = new System.Drawing.Point(153, 119);
            this.articlesCmbBox.Name = "articlesCmbBox";
            this.articlesCmbBox.Size = new System.Drawing.Size(840, 31);
            this.articlesCmbBox.TabIndex = 1;
            this.articlesCmbBox.SelectedIndexChanged += new System.EventHandler(this.articlesCmbBox_SelectedIndexChanged);
            // 
            // articleCategoryCmbBox
            // 
            this.articleCategoryCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.articleCategoryCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleCategoryCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.articleCategoryCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleCategoryCmbBox.FormattingEnabled = true;
            this.articleCategoryCmbBox.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.articleCategoryCmbBox.Location = new System.Drawing.Point(999, 119);
            this.articleCategoryCmbBox.Name = "articleCategoryCmbBox";
            this.articleCategoryCmbBox.Size = new System.Drawing.Size(276, 31);
            this.articleCategoryCmbBox.TabIndex = 3;
            this.articleCategoryCmbBox.SelectedIndexChanged += new System.EventHandler(this.articlesCmbBox_SelectedIndexChanged);
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtBox.Location = new System.Drawing.Point(435, 235);
            this.quantityTxtBox.Multiline = true;
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.ShortcutsEnabled = false;
            this.quantityTxtBox.Size = new System.Drawing.Size(276, 31);
            this.quantityTxtBox.TabIndex = 5;
            this.quantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
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
            this.lblTitle.Size = new System.Drawing.Size(240, 58);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "UNOS ARTIKALA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertedArticlesLbl
            // 
            this.insertedArticlesLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertedArticlesLbl.AutoSize = true;
            this.insertedArticlesLbl.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.insertedArticlesLbl, 2);
            this.insertedArticlesLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertedArticlesLbl.ForeColor = System.Drawing.Color.White;
            this.insertedArticlesLbl.Location = new System.Drawing.Point(924, 551);
            this.insertedArticlesLbl.Name = "insertedArticlesLbl";
            this.insertedArticlesLbl.Size = new System.Drawing.Size(143, 27);
            this.insertedArticlesLbl.TabIndex = 29;
            this.insertedArticlesLbl.Text = "Uneti artikli";
            this.insertedArticlesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishInsertBtn
            // 
            this.finishInsertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.finishInsertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.finishInsertBtn, 2);
            this.finishInsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishInsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishInsertBtn.FlatAppearance.BorderSize = 5;
            this.finishInsertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInsertBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishInsertBtn.ForeColor = System.Drawing.Color.White;
            this.finishInsertBtn.Location = new System.Drawing.Point(615, 757);
            this.finishInsertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishInsertBtn.Name = "finishInsertBtn";
            this.finishInsertBtn.Size = new System.Drawing.Size(198, 48);
            this.finishInsertBtn.TabIndex = 31;
            this.finishInsertBtn.TabStop = false;
            this.finishInsertBtn.Text = "Završi unos";
            this.finishInsertBtn.UseVisualStyleBackColor = false;
            this.finishInsertBtn.Click += new System.EventHandler(this.finishInsertBtn_Click);
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
            this.backBtn.Location = new System.Drawing.Point(1281, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 52);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.White;
            this.categoryLbl.Location = new System.Drawing.Point(1073, 89);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(128, 27);
            this.categoryLbl.TabIndex = 12;
            this.categoryLbl.Text = "Kategorija";
            this.categoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articleLbl
            // 
            this.articleLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.articleLbl.AutoSize = true;
            this.articleLbl.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.articleLbl, 3);
            this.articleLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleLbl.ForeColor = System.Drawing.Color.White;
            this.articleLbl.Location = new System.Drawing.Point(335, 89);
            this.articleLbl.Name = "articleLbl";
            this.articleLbl.Size = new System.Drawing.Size(476, 27);
            this.articleLbl.TabIndex = 11;
            this.articleLbl.Text = "Artikal / Sorta / Kontrolisana proizvodnja";
            this.articleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(221, 205);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(140, 27);
            this.priceLbl.TabIndex = 16;
            this.priceLbl.Text = "Cena (RSD)";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articlePriceLbl
            // 
            this.articlePriceLbl.AutoSize = true;
            this.articlePriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.articlePriceLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlePriceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlePriceLbl.ForeColor = System.Drawing.Color.White;
            this.articlePriceLbl.Location = new System.Drawing.Point(153, 232);
            this.articlePriceLbl.Name = "articlePriceLbl";
            this.articlePriceLbl.Size = new System.Drawing.Size(276, 58);
            this.articlePriceLbl.TabIndex = 35;
            this.articlePriceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(496, 205);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(154, 27);
            this.quantityLbl.TabIndex = 17;
            this.quantityLbl.Text = "Količina (kg)";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crateOwnerCmbBox
            // 
            this.crateOwnerCmbBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crateOwnerCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crateOwnerCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crateOwnerCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateOwnerCmbBox.FormattingEnabled = true;
            this.crateOwnerCmbBox.Items.AddRange(new object[] {
            "Klijent",
            "Hladnjača"});
            this.crateOwnerCmbBox.Location = new System.Drawing.Point(159, 465);
            this.crateOwnerCmbBox.Name = "crateOwnerCmbBox";
            this.crateOwnerCmbBox.Size = new System.Drawing.Size(264, 31);
            this.crateOwnerCmbBox.TabIndex = 8;
            this.crateOwnerCmbBox.SelectedIndexChanged += new System.EventHandler(this.onChangeOwener);
            // 
            // crateOwnerLbl
            // 
            this.crateOwnerLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateOwnerLbl.AutoSize = true;
            this.crateOwnerLbl.BackColor = System.Drawing.Color.Transparent;
            this.crateOwnerLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateOwnerLbl.ForeColor = System.Drawing.Color.White;
            this.crateOwnerLbl.Location = new System.Drawing.Point(228, 435);
            this.crateOwnerLbl.Name = "crateOwnerLbl";
            this.crateOwnerLbl.Size = new System.Drawing.Size(126, 27);
            this.crateOwnerLbl.TabIndex = 26;
            this.crateOwnerLbl.Text = "Vlasništvo";
            this.crateOwnerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.insertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.insertBtn, 2);
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 5;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(404, 529);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(56, 44);
            this.insertBtn.TabIndex = 30;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "+";
            this.insertBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // packageTypeCmbBox
            // 
            this.packageTypeCmbBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insertFormTblLayout.SetColumnSpan(this.packageTypeCmbBox, 2);
            this.packageTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageTypeCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageTypeCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageTypeCmbBox.FormattingEnabled = true;
            this.packageTypeCmbBox.Location = new System.Drawing.Point(582, 465);
            this.packageTypeCmbBox.Name = "packageTypeCmbBox";
            this.packageTypeCmbBox.Size = new System.Drawing.Size(264, 31);
            this.packageTypeCmbBox.TabIndex = 7;
            this.packageTypeCmbBox.Visible = false;
            // 
            // crateTypeLbl
            // 
            this.crateTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateTypeLbl.AutoSize = true;
            this.crateTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.crateTypeLbl, 2);
            this.crateTypeLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateTypeLbl.ForeColor = System.Drawing.Color.White;
            this.crateTypeLbl.Location = new System.Drawing.Point(679, 435);
            this.crateTypeLbl.Name = "crateTypeLbl";
            this.crateTypeLbl.Size = new System.Drawing.Size(70, 27);
            this.crateTypeLbl.TabIndex = 25;
            this.crateTypeLbl.Text = "Vrsta";
            this.crateTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crateTypeLbl.Visible = false;
            // 
            // crateQuantityTxtBox
            // 
            this.crateQuantityTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crateQuantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crateQuantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityTxtBox.Location = new System.Drawing.Point(1005, 465);
            this.crateQuantityTxtBox.Multiline = true;
            this.crateQuantityTxtBox.Name = "crateQuantityTxtBox";
            this.crateQuantityTxtBox.ShortcutsEnabled = false;
            this.crateQuantityTxtBox.Size = new System.Drawing.Size(264, 31);
            this.crateQuantityTxtBox.TabIndex = 6;
            this.crateQuantityTxtBox.Visible = false;
            this.crateQuantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // crateQuantityLbl
            // 
            this.crateQuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateQuantityLbl.AutoSize = true;
            this.crateQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.crateQuantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.crateQuantityLbl.Location = new System.Drawing.Point(1107, 435);
            this.crateQuantityLbl.Name = "crateQuantityLbl";
            this.crateQuantityLbl.Size = new System.Drawing.Size(59, 27);
            this.crateQuantityLbl.TabIndex = 24;
            this.crateQuantityLbl.Text = "Broj";
            this.crateQuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crateQuantityLbl.Visible = false;
            // 
            // cratesLbl
            // 
            this.cratesLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cratesLbl.AutoSize = true;
            this.cratesLbl.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.cratesLbl, 2);
            this.cratesLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cratesLbl.ForeColor = System.Drawing.Color.White;
            this.cratesLbl.Location = new System.Drawing.Point(647, 379);
            this.cratesLbl.Name = "cratesLbl";
            this.cratesLbl.Size = new System.Drawing.Size(133, 27);
            this.cratesLbl.TabIndex = 18;
            this.cratesLbl.Text = "AMBALAŽE";
            this.cratesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 883);
            this.Controls.Add(this.insertFormTblLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.insertFormTblLayout.ResumeLayout(false);
            this.insertFormTblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel insertFormTblLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label articleLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox articlesCmbBox;
        private System.Windows.Forms.ComboBox articleCategoryCmbBox;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label cratesLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.TextBox crateQuantityTxtBox;
        private System.Windows.Forms.Label crateQuantityLbl;
        private System.Windows.Forms.Label crateTypeLbl;
        private System.Windows.Forms.Label crateOwnerLbl;
        private System.Windows.Forms.Label insertedArticlesLbl;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button finishInsertBtn;
        private System.Windows.Forms.ComboBox packageTypeCmbBox;
        private System.Windows.Forms.ComboBox crateOwnerCmbBox;
        private System.Windows.Forms.DataGridView articlesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleOrganic;
        private System.Windows.Forms.DataGridViewTextBoxColumn articlePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteArticle;
        private System.Windows.Forms.Label articlePriceLbl;
    }
}