namespace Freshivoje.Packaging
{
    partial class PackagesForRentForm
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
            this.insertFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cratesTypeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cratesCmbBox = new System.Windows.Forms.ComboBox();
            this.crateQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.transportDataGridView = new System.Windows.Forms.DataGridView();
            this.finishInsertBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertFormTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertFormTblLayout
            // 
            this.insertFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.insertFormTblLayout.ColumnCount = 6;
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.insertFormTblLayout.Controls.Add(this.transportDataGridView, 0, 3);
            this.insertFormTblLayout.Controls.Add(this.crateQuantityTxtBox, 3, 1);
            this.insertFormTblLayout.Controls.Add(this.cratesCmbBox, 1, 1);
            this.insertFormTblLayout.Controls.Add(this.cratesTypeLbl, 1, 0);
            this.insertFormTblLayout.Controls.Add(this.label1, 3, 0);
            this.insertFormTblLayout.Controls.Add(this.insertBtn, 2, 2);
            this.insertFormTblLayout.Controls.Add(this.finishInsertBtn, 2, 9);
            this.insertFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.insertFormTblLayout.Name = "insertFormTblLayout";
            this.insertFormTblLayout.RowCount = 10;
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.insertFormTblLayout.Size = new System.Drawing.Size(1292, 841);
            this.insertFormTblLayout.TabIndex = 4;
            // 
            // cratesTypeLbl
            // 
            this.cratesTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cratesTypeLbl.AutoSize = true;
            this.cratesTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.cratesTypeLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cratesTypeLbl.ForeColor = System.Drawing.Color.White;
            this.cratesTypeLbl.Location = new System.Drawing.Point(176, 30);
            this.cratesTypeLbl.Name = "cratesTypeLbl";
            this.cratesTypeLbl.Size = new System.Drawing.Size(365, 54);
            this.cratesTypeLbl.TabIndex = 37;
            this.cratesTypeLbl.Text = "Nosivost / Kategorija / Težina / Proizvođač";
            this.cratesTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(890, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Broj ambalaža";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cratesCmbBox
            // 
            this.cratesCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cratesCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cratesCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cratesCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cratesCmbBox.FormattingEnabled = true;
            this.cratesCmbBox.Location = new System.Drawing.Point(153, 87);
            this.cratesCmbBox.Name = "cratesCmbBox";
            this.cratesCmbBox.Size = new System.Drawing.Size(411, 31);
            this.cratesCmbBox.TabIndex = 39;
            this.cratesCmbBox.TabStop = false;
            // 
            // crateQuantityTxtBox
            // 
            this.crateQuantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crateQuantityTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.crateQuantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityTxtBox.Location = new System.Drawing.Point(770, 87);
            this.crateQuantityTxtBox.Multiline = true;
            this.crateQuantityTxtBox.Name = "crateQuantityTxtBox";
            this.crateQuantityTxtBox.ShortcutsEnabled = false;
            this.crateQuantityTxtBox.Size = new System.Drawing.Size(411, 31);
            this.crateQuantityTxtBox.TabIndex = 40;
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 5;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(639, 182);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(56, 56);
            this.insertBtn.TabIndex = 42;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "+";
            this.insertBtn.UseVisualStyleBackColor = false;
            // 
            // transportDataGridView
            // 
            this.transportDataGridView.AllowUserToAddRows = false;
            this.transportDataGridView.AllowUserToDeleteRows = false;
            this.transportDataGridView.AllowUserToResizeColumns = false;
            this.transportDataGridView.AllowUserToResizeRows = false;
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
            this.id,
            this.totalPrice,
            this.Količina,
            this.deleteArticle});
            this.insertFormTblLayout.SetColumnSpan(this.transportDataGridView, 7);
            this.transportDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transportDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.transportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transportDataGridView.Location = new System.Drawing.Point(3, 255);
            this.transportDataGridView.MultiSelect = false;
            this.transportDataGridView.Name = "transportDataGridView";
            this.transportDataGridView.ReadOnly = true;
            this.transportDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.transportDataGridView.RowHeadersWidth = 40;
            this.transportDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.insertFormTblLayout.SetRowSpan(this.transportDataGridView, 5);
            this.transportDataGridView.RowTemplate.Height = 30;
            this.transportDataGridView.Size = new System.Drawing.Size(1286, 414);
            this.transportDataGridView.TabIndex = 43;
            this.transportDataGridView.TabStop = false;
            // 
            // finishInsertBtn
            // 
            this.finishInsertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.finishInsertBtn.BackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishInsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishInsertBtn.FlatAppearance.BorderSize = 5;
            this.finishInsertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInsertBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishInsertBtn.ForeColor = System.Drawing.Color.White;
            this.finishInsertBtn.Location = new System.Drawing.Point(572, 761);
            this.finishInsertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishInsertBtn.Name = "finishInsertBtn";
            this.finishInsertBtn.Size = new System.Drawing.Size(190, 75);
            this.finishInsertBtn.TabIndex = 44;
            this.finishInsertBtn.TabStop = false;
            this.finishInsertBtn.Text = "Završi unos";
            this.finishInsertBtn.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.HeaderText = "Ambalaža";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
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
            // PackagesForRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 841);
            this.Controls.Add(this.insertFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PackagesForRentForm";
            this.Text = "packagesForRentForm";
            this.insertFormTblLayout.ResumeLayout(false);
            this.insertFormTblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel insertFormTblLayout;
        private System.Windows.Forms.Label cratesTypeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cratesCmbBox;
        private System.Windows.Forms.TextBox crateQuantityTxtBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.DataGridView transportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteArticle;
        private System.Windows.Forms.Button finishInsertBtn;
    }
}