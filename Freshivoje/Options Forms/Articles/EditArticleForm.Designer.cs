﻿namespace Freshivoje.Custom_Forms
{
    partial class EditArticleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditArticleForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updatePriceBtn = new System.Windows.Forms.Button();
            this.articleOrganicLbl = new System.Windows.Forms.Label();
            this.articleNameTxtBox = new System.Windows.Forms.TextBox();
            this.articleSortTxtBox = new System.Windows.Forms.TextBox();
            this.articleOrganicCmbBox = new System.Windows.Forms.ComboBox();
            this.articleSortLbl = new System.Windows.Forms.Label();
            this.articleNameLbl = new System.Windows.Forms.Label();
            this.articlePricesDataGridView = new System.Windows.Forms.DataGridView();
            this.id_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkArticleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editArticleFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.articleCategoryTxtBox = new System.Windows.Forms.TextBox();
            this.articlePriceTxtBox = new System.Windows.Forms.TextBox();
            this.articlePriceLbl = new System.Windows.Forms.Label();
            this.articleCategoryLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articlePricesDataGridView)).BeginInit();
            this.editArticleFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.cancelBtn, 2);
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 5;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(378, 489);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Name = "cancelBtn";
            this.editArticleFormTableLayoutPanel.SetRowSpan(this.cancelBtn, 2);
            this.cancelBtn.Size = new System.Drawing.Size(140, 78);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "NAZAD";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updatePriceBtn
            // 
            this.updatePriceBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatePriceBtn.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.updatePriceBtn, 2);
            this.updatePriceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePriceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatePriceBtn.FlatAppearance.BorderSize = 5;
            this.updatePriceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.updatePriceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.updatePriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePriceBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePriceBtn.ForeColor = System.Drawing.Color.White;
            this.updatePriceBtn.Location = new System.Drawing.Point(147, 489);
            this.updatePriceBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updatePriceBtn.Name = "updatePriceBtn";
            this.editArticleFormTableLayoutPanel.SetRowSpan(this.updatePriceBtn, 2);
            this.updatePriceBtn.Size = new System.Drawing.Size(154, 78);
            this.updatePriceBtn.TabIndex = 20;
            this.updatePriceBtn.TabStop = false;
            this.updatePriceBtn.Text = "DODAJ NOVU CENU";
            this.updatePriceBtn.UseVisualStyleBackColor = false;
            this.updatePriceBtn.Click += new System.EventHandler(this.updatePriceBtn_Click);
            // 
            // articleOrganicLbl
            // 
            this.articleOrganicLbl.AutoSize = true;
            this.articleOrganicLbl.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleOrganicLbl, 4);
            this.articleOrganicLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.articleOrganicLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleOrganicLbl.ForeColor = System.Drawing.Color.White;
            this.articleOrganicLbl.Location = new System.Drawing.Point(115, 193);
            this.articleOrganicLbl.Name = "articleOrganicLbl";
            this.articleOrganicLbl.Size = new System.Drawing.Size(442, 27);
            this.articleOrganicLbl.TabIndex = 19;
            this.articleOrganicLbl.Text = "Kontrolisana proizvodnja";
            this.articleOrganicLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articleNameTxtBox
            // 
            this.articleNameTxtBox.BackColor = System.Drawing.Color.White;
            this.articleNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleNameTxtBox, 4);
            this.articleNameTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleNameTxtBox.Enabled = false;
            this.articleNameTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleNameTxtBox.Location = new System.Drawing.Point(115, 47);
            this.articleNameTxtBox.Multiline = true;
            this.articleNameTxtBox.Name = "articleNameTxtBox";
            this.articleNameTxtBox.ReadOnly = true;
            this.articleNameTxtBox.ShortcutsEnabled = false;
            this.articleNameTxtBox.Size = new System.Drawing.Size(442, 31);
            this.articleNameTxtBox.TabIndex = 0;
            this.articleNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // articleSortTxtBox
            // 
            this.articleSortTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleSortTxtBox, 4);
            this.articleSortTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleSortTxtBox.Enabled = false;
            this.articleSortTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleSortTxtBox.Location = new System.Drawing.Point(115, 135);
            this.articleSortTxtBox.Multiline = true;
            this.articleSortTxtBox.Name = "articleSortTxtBox";
            this.articleSortTxtBox.ShortcutsEnabled = false;
            this.articleSortTxtBox.Size = new System.Drawing.Size(442, 31);
            this.articleSortTxtBox.TabIndex = 1;
            this.articleSortTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // articleOrganicCmbBox
            // 
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleOrganicCmbBox, 4);
            this.articleOrganicCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleOrganicCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleOrganicCmbBox.Enabled = false;
            this.articleOrganicCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.articleOrganicCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleOrganicCmbBox.FormattingEnabled = true;
            this.articleOrganicCmbBox.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.articleOrganicCmbBox.Location = new System.Drawing.Point(115, 223);
            this.articleOrganicCmbBox.Name = "articleOrganicCmbBox";
            this.articleOrganicCmbBox.Size = new System.Drawing.Size(442, 31);
            this.articleOrganicCmbBox.TabIndex = 3;
            // 
            // articleSortLbl
            // 
            this.articleSortLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.articleSortLbl.AutoSize = true;
            this.articleSortLbl.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleSortLbl, 2);
            this.articleSortLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleSortLbl.ForeColor = System.Drawing.Color.White;
            this.articleSortLbl.Location = new System.Drawing.Point(301, 105);
            this.articleSortLbl.Name = "articleSortLbl";
            this.articleSortLbl.Size = new System.Drawing.Size(72, 27);
            this.articleSortLbl.TabIndex = 12;
            this.articleSortLbl.Text = "Sorta";
            this.articleSortLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articleNameLbl
            // 
            this.articleNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.articleNameLbl.AutoSize = true;
            this.articleNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleNameLbl, 2);
            this.articleNameLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleNameLbl.ForeColor = System.Drawing.Color.White;
            this.articleNameLbl.Location = new System.Drawing.Point(270, 17);
            this.articleNameLbl.Name = "articleNameLbl";
            this.articleNameLbl.Size = new System.Drawing.Size(135, 27);
            this.articleNameLbl.TabIndex = 10;
            this.articleNameLbl.Text = "Ime artikla";
            this.articleNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articlePricesDataGridView
            // 
            this.articlePricesDataGridView.AllowUserToAddRows = false;
            this.articlePricesDataGridView.AllowUserToDeleteRows = false;
            this.articlePricesDataGridView.AllowUserToResizeColumns = false;
            this.articlePricesDataGridView.AllowUserToResizeRows = false;
            this.articlePricesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.articlePricesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articlePricesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articlePricesDataGridView.ColumnHeadersHeight = 40;
            this.articlePricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.articlePricesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_price,
            this.fkArticleId,
            this.priceValue,
            this.priceDate,
            this.status});
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articlePricesDataGridView, 4);
            this.articlePricesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articlePricesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.articlePricesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlePricesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.articlePricesDataGridView.Location = new System.Drawing.Point(675, 47);
            this.articlePricesDataGridView.MultiSelect = false;
            this.articlePricesDataGridView.Name = "articlePricesDataGridView";
            this.articlePricesDataGridView.RowHeadersWidth = 40;
            this.articlePricesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.editArticleFormTableLayoutPanel.SetRowSpan(this.articlePricesDataGridView, 13);
            this.articlePricesDataGridView.RowTemplate.Height = 30;
            this.articlePricesDataGridView.Size = new System.Drawing.Size(630, 572);
            this.articlePricesDataGridView.TabIndex = 61;
            this.articlePricesDataGridView.TabStop = false;
            // 
            // id_price
            // 
            this.id_price.DataPropertyName = "id_price";
            this.id_price.HeaderText = "ID Cene";
            this.id_price.Name = "id_price";
            this.id_price.Visible = false;
            // 
            // fkArticleId
            // 
            this.fkArticleId.DataPropertyName = "fk_article_id";
            this.fkArticleId.HeaderText = "ID Artikla";
            this.fkArticleId.Name = "fkArticleId";
            this.fkArticleId.ReadOnly = true;
            this.fkArticleId.Visible = false;
            // 
            // priceValue
            // 
            this.priceValue.DataPropertyName = "value";
            this.priceValue.HeaderText = "Cena";
            this.priceValue.Name = "priceValue";
            // 
            // priceDate
            // 
            this.priceDate.DataPropertyName = "date";
            this.priceDate.HeaderText = "Datum kreiranja cene";
            this.priceDate.Name = "priceDate";
            this.priceDate.Width = 300;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.DefaultCellStyle = dataGridViewCellStyle2;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // editArticleFormTableLayoutPanel
            // 
            this.editArticleFormTableLayoutPanel.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.editArticleFormTableLayoutPanel.ColumnCount = 11;
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.66536F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.66536F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.66536F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.8125F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.404891F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.66536F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80157F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80157F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80157F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80157F));
            this.editArticleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80157F));
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleCategoryTxtBox, 1, 7);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articlePriceTxtBox, 1, 9);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articlePricesDataGridView, 6, 1);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleNameLbl, 2, 0);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleSortLbl, 2, 2);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleOrganicCmbBox, 1, 5);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleSortTxtBox, 1, 3);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleNameTxtBox, 1, 1);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleOrganicLbl, 1, 4);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.updatePriceBtn, 1, 11);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.cancelBtn, 3, 11);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articlePriceLbl, 1, 8);
            this.editArticleFormTableLayoutPanel.Controls.Add(this.articleCategoryLbl, 2, 6);
            this.editArticleFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editArticleFormTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.editArticleFormTableLayoutPanel.Name = "editArticleFormTableLayoutPanel";
            this.editArticleFormTableLayoutPanel.RowCount = 15;
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.editArticleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142859F));
            this.editArticleFormTableLayoutPanel.Size = new System.Drawing.Size(1472, 668);
            this.editArticleFormTableLayoutPanel.TabIndex = 1;
            // 
            // articleCategoryTxtBox
            // 
            this.articleCategoryTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleCategoryTxtBox, 4);
            this.articleCategoryTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleCategoryTxtBox.Enabled = false;
            this.articleCategoryTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleCategoryTxtBox.Location = new System.Drawing.Point(115, 311);
            this.articleCategoryTxtBox.MaxLength = 8;
            this.articleCategoryTxtBox.Multiline = true;
            this.articleCategoryTxtBox.Name = "articleCategoryTxtBox";
            this.articleCategoryTxtBox.ShortcutsEnabled = false;
            this.articleCategoryTxtBox.Size = new System.Drawing.Size(442, 31);
            this.articleCategoryTxtBox.TabIndex = 67;
            // 
            // articlePriceTxtBox
            // 
            this.articlePriceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articlePriceTxtBox, 4);
            this.articlePriceTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.articlePriceTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlePriceTxtBox.Location = new System.Drawing.Point(115, 399);
            this.articlePriceTxtBox.MaxLength = 8;
            this.articlePriceTxtBox.Multiline = true;
            this.articlePriceTxtBox.Name = "articlePriceTxtBox";
            this.articlePriceTxtBox.ShortcutsEnabled = false;
            this.articlePriceTxtBox.Size = new System.Drawing.Size(442, 31);
            this.articlePriceTxtBox.TabIndex = 64;
            this.articlePriceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // articlePriceLbl
            // 
            this.articlePriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.articlePriceLbl.AutoSize = true;
            this.articlePriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articlePriceLbl, 4);
            this.articlePriceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlePriceLbl.ForeColor = System.Drawing.Color.White;
            this.articlePriceLbl.Location = new System.Drawing.Point(266, 369);
            this.articlePriceLbl.Name = "articlePriceLbl";
            this.articlePriceLbl.Size = new System.Drawing.Size(140, 27);
            this.articlePriceLbl.TabIndex = 65;
            this.articlePriceLbl.Text = "Cena (RSD)";
            this.articlePriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articleCategoryLbl
            // 
            this.articleCategoryLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.articleCategoryLbl.AutoSize = true;
            this.articleCategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.editArticleFormTableLayoutPanel.SetColumnSpan(this.articleCategoryLbl, 2);
            this.articleCategoryLbl.Enabled = false;
            this.articleCategoryLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleCategoryLbl.ForeColor = System.Drawing.Color.White;
            this.articleCategoryLbl.Location = new System.Drawing.Point(301, 281);
            this.articleCategoryLbl.Name = "articleCategoryLbl";
            this.articleCategoryLbl.Size = new System.Drawing.Size(72, 27);
            this.articleCategoryLbl.TabIndex = 66;
            this.articleCategoryLbl.Text = "Sorta";
            this.articleCategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 678);
            this.Controls.Add(this.editArticleFormTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditArticleForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikal";
            ((System.ComponentModel.ISupportInitialize)(this.articlePricesDataGridView)).EndInit();
            this.editArticleFormTableLayoutPanel.ResumeLayout(false);
            this.editArticleFormTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel editArticleFormTableLayoutPanel;
        private System.Windows.Forms.DataGridView articlePricesDataGridView;
        private System.Windows.Forms.Label articleNameLbl;
        private System.Windows.Forms.Label articleSortLbl;
        private System.Windows.Forms.ComboBox articleOrganicCmbBox;
        private System.Windows.Forms.TextBox articleSortTxtBox;
        private System.Windows.Forms.TextBox articleNameTxtBox;
        private System.Windows.Forms.Label articleOrganicLbl;
        private System.Windows.Forms.Button updatePriceBtn;
        private System.Windows.Forms.Label articlePriceLbl;
        private System.Windows.Forms.TextBox articlePriceTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkArticleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox articleCategoryTxtBox;
        private System.Windows.Forms.Label articleCategoryLbl;
    }
}