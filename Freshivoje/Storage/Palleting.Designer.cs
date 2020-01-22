namespace Freshivoje.Storage
{
    partial class Palleting
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.insertFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.palletingDataGridView = new System.Windows.Forms.DataGridView();
            this.fk_client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_receipt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_arcticle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finishInsertBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.palleteQuantitylbl = new System.Windows.Forms.Label();
            this.insertFormTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palletingDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(203, 75);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PALETIRANJE";
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
            this.exitBtn.Location = new System.Drawing.Point(1759, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(51, 69);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // insertFormTblLayout
            // 
            this.insertFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.insertFormTblLayout.ColumnCount = 12;
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.259261F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25926F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.insertFormTblLayout.Controls.Add(this.backBtn, 10, 0);
            this.insertFormTblLayout.Controls.Add(this.palletingDataGridView, 0, 2);
            this.insertFormTblLayout.Controls.Add(this.exitBtn, 11, 0);
            this.insertFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.insertFormTblLayout.Controls.Add(this.label2, 8, 9);
            this.insertFormTblLayout.Controls.Add(this.palleteQuantitylbl, 9, 9);
            this.insertFormTblLayout.Controls.Add(this.finishInsertBtn, 4, 10);
            this.insertFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.insertFormTblLayout.Name = "insertFormTblLayout";
            this.insertFormTblLayout.RowCount = 12;
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333331F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.insertFormTblLayout.Size = new System.Drawing.Size(1813, 907);
            this.insertFormTblLayout.TabIndex = 3;
            this.insertFormTblLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.insertFormTblLayout_Paint);
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
            this.backBtn.Location = new System.Drawing.Point(1709, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 69);
            this.backBtn.TabIndex = 44;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // palletingDataGridView
            // 
            this.palletingDataGridView.AllowDrop = true;
            this.palletingDataGridView.AllowUserToDeleteRows = false;
            this.palletingDataGridView.AllowUserToResizeColumns = false;
            this.palletingDataGridView.AllowUserToResizeRows = false;
            this.palletingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.palletingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.palletingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.palletingDataGridView.ColumnHeadersHeight = 40;
            this.palletingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.palletingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fk_client_id,
            this.fk_receipt_id,
            this.fk_arcticle_id,
            this.first_name,
            this.last_name,
            this.quantity,
            this.price,
            this.status,
            this.article_name,
            this.sort,
            this.organic,
            this.category,
            this.chk});
            this.insertFormTblLayout.SetColumnSpan(this.palletingDataGridView, 12);
            this.palletingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.palletingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.palletingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palletingDataGridView.Location = new System.Drawing.Point(3, 153);
            this.palletingDataGridView.Name = "palletingDataGridView";
            this.palletingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.palletingDataGridView.RowHeadersWidth = 40;
            this.palletingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.insertFormTblLayout.SetRowSpan(this.palletingDataGridView, 7);
            this.palletingDataGridView.RowTemplate.Height = 30;
            this.palletingDataGridView.Size = new System.Drawing.Size(1807, 519);
            this.palletingDataGridView.TabIndex = 35;
            this.palletingDataGridView.TabStop = false;
            this.palletingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PalletingDataGridView_CellContentClick);
            // 
            // fk_client_id
            // 
            this.fk_client_id.DataPropertyName = "fk_client_id";
            this.fk_client_id.HeaderText = "ID palete";
            this.fk_client_id.Name = "fk_client_id";
            this.fk_client_id.Visible = false;
            // 
            // fk_receipt_id
            // 
            this.fk_receipt_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fk_receipt_id.DataPropertyName = "fk_receipt_id";
            this.fk_receipt_id.HeaderText = "fk_recepit_id";
            this.fk_receipt_id.Name = "fk_receipt_id";
            this.fk_receipt_id.Visible = false;
            // 
            // fk_arcticle_id
            // 
            this.fk_arcticle_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fk_arcticle_id.DataPropertyName = "fk_arcticle_id";
            this.fk_arcticle_id.HeaderText = "fk_arcticle_id";
            this.fk_arcticle_id.Name = "fk_arcticle_id";
            this.fk_arcticle_id.Visible = false;
            this.fk_arcticle_id.Width = 190;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "Ime klijenta";
            this.first_name.Name = "first_name";
            this.first_name.Width = 140;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Prezime klijenta";
            this.last_name.MinimumWidth = 140;
            this.last_name.Name = "last_name";
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Količina";
            this.quantity.MinimumWidth = 140;
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Cena";
            this.price.MinimumWidth = 140;
            this.price.Name = "price";
            this.price.Visible = false;
            this.price.Width = 140;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 140;
            this.status.Name = "status";
            this.status.Width = 140;
            // 
            // article_name
            // 
            this.article_name.DataPropertyName = "article_name";
            this.article_name.HeaderText = "Ime artikla";
            this.article_name.MinimumWidth = 250;
            this.article_name.Name = "article_name";
            this.article_name.Width = 250;
            // 
            // sort
            // 
            this.sort.DataPropertyName = "sort";
            this.sort.HeaderText = "Sorta";
            this.sort.MinimumWidth = 140;
            this.sort.Name = "sort";
            this.sort.Width = 140;
            // 
            // organic
            // 
            this.organic.DataPropertyName = "organic";
            this.organic.HeaderText = "Kontrolisana proizvodnja";
            this.organic.MinimumWidth = 350;
            this.organic.Name = "organic";
            this.organic.Width = 350;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Kategorija";
            this.category.MinimumWidth = 200;
            this.category.Name = "category";
            this.category.Width = 200;
            // 
            // chk
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.chk.DefaultCellStyle = dataGridViewCellStyle2;
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.Width = 40;
            // 
            // finishInsertBtn
            // 
            this.finishInsertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finishInsertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.SetColumnSpan(this.finishInsertBtn, 3);
            this.finishInsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishInsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishInsertBtn.FlatAppearance.BorderSize = 5;
            this.finishInsertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInsertBtn.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.finishInsertBtn.ForeColor = System.Drawing.Color.White;
            this.finishInsertBtn.Location = new System.Drawing.Point(741, 762);
            this.finishInsertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishInsertBtn.Name = "finishInsertBtn";
            this.finishInsertBtn.Size = new System.Drawing.Size(255, 50);
            this.finishInsertBtn.TabIndex = 41;
            this.finishInsertBtn.TabStop = false;
            this.finishInsertBtn.Text = "Završi ";
            this.finishInsertBtn.UseVisualStyleBackColor = false;
            this.finishInsertBtn.Click += new System.EventHandler(this.finishInsertBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1315, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "UKUPNO:";
            // 
            // palleteQuantitylbl
            // 
            this.palleteQuantitylbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.palleteQuantitylbl.AutoSize = true;
            this.palleteQuantitylbl.BackColor = System.Drawing.Color.Transparent;
            this.palleteQuantitylbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palleteQuantitylbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.palleteQuantitylbl.Location = new System.Drawing.Point(1425, 700);
            this.palleteQuantitylbl.Name = "palleteQuantitylbl";
            this.palleteQuantitylbl.Size = new System.Drawing.Size(85, 24);
            this.palleteQuantitylbl.TabIndex = 42;
            this.palleteQuantitylbl.Text = "LABEL1";
            // 
            // Palleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 907);
            this.ControlBox = false;
            this.Controls.Add(this.insertFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Palleting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palleting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.insertFormTblLayout.ResumeLayout(false);
            this.insertFormTblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palletingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel insertFormTblLayout;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView palletingDataGridView;
        private System.Windows.Forms.Button finishInsertBtn;
        private System.Windows.Forms.Label palleteQuantitylbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_receipt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_arcticle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn organic;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}