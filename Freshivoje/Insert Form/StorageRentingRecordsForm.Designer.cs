namespace Freshivoje.Insert_Form
{
    partial class StorageRentingRecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageRentingRecordsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StorageRentingRecordFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StorageRentingDataGridView = new System.Windows.Forms.DataGridView();
            this.id_renting_storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_client_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuing_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renting_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previewTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchRentingTxtBox = new System.Windows.Forms.TextBox();
            this.StorageRentingRecordFormTblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageRentingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageRentingRecordFormTblLayout
            // 
            this.StorageRentingRecordFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.StorageRentingRecordFormTblLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StorageRentingRecordFormTblLayout.BackgroundImage")));
            this.StorageRentingRecordFormTblLayout.ColumnCount = 8;
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StorageRentingRecordFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.StorageRentingDataGridView, 0, 3);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.minimizeBtn, 6, 0);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.exitBtn, 7, 0);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.backBtn, 5, 0);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.searchLbl, 4, 1);
            this.StorageRentingRecordFormTblLayout.Controls.Add(this.searchRentingTxtBox, 4, 2);
            this.StorageRentingRecordFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageRentingRecordFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.StorageRentingRecordFormTblLayout.Name = "StorageRentingRecordFormTblLayout";
            this.StorageRentingRecordFormTblLayout.RowCount = 15;
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149926F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.273625F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.927262F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.149925F));
            this.StorageRentingRecordFormTblLayout.Size = new System.Drawing.Size(1672, 849);
            this.StorageRentingRecordFormTblLayout.TabIndex = 4;
            // 
            // StorageRentingDataGridView
            // 
            this.StorageRentingDataGridView.AllowUserToAddRows = false;
            this.StorageRentingDataGridView.AllowUserToDeleteRows = false;
            this.StorageRentingDataGridView.AllowUserToResizeColumns = false;
            this.StorageRentingDataGridView.AllowUserToResizeRows = false;
            this.StorageRentingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StorageRentingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StorageRentingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StorageRentingDataGridView.ColumnHeadersHeight = 40;
            this.StorageRentingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StorageRentingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_renting_storage,
            this.fk_client_id,
            this.client,
            this.issuing_date,
            this.renting_status,
            this.previewTransport,
            this.deleteStatus});
            this.StorageRentingRecordFormTblLayout.SetColumnSpan(this.StorageRentingDataGridView, 8);
            this.StorageRentingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StorageRentingDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.StorageRentingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageRentingDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StorageRentingDataGridView.Location = new System.Drawing.Point(3, 167);
            this.StorageRentingDataGridView.MultiSelect = false;
            this.StorageRentingDataGridView.Name = "StorageRentingDataGridView";
            this.StorageRentingDataGridView.ReadOnly = true;
            this.StorageRentingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StorageRentingDataGridView.RowHeadersWidth = 40;
            this.StorageRentingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageRentingRecordFormTblLayout.SetRowSpan(this.StorageRentingDataGridView, 12);
            this.StorageRentingDataGridView.RowTemplate.Height = 30;
            this.StorageRentingDataGridView.Size = new System.Drawing.Size(1666, 679);
            this.StorageRentingDataGridView.TabIndex = 42;
            this.StorageRentingDataGridView.TabStop = false;
            this.StorageRentingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StorageRentingDataGridView_CellContentClick_1);
            // 
            // id_renting_storage
            // 
            this.id_renting_storage.DataPropertyName = "id_renting_storage";
            this.id_renting_storage.HeaderText = "ID";
            this.id_renting_storage.Name = "id_renting_storage";
            this.id_renting_storage.ReadOnly = true;
            this.id_renting_storage.Visible = false;
            // 
            // fk_client_id
            // 
            this.fk_client_id.DataPropertyName = "fk_client_id";
            this.fk_client_id.HeaderText = "ID Klijenta";
            this.fk_client_id.Name = "fk_client_id";
            this.fk_client_id.ReadOnly = true;
            this.fk_client_id.Visible = false;
            // 
            // client
            // 
            this.client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.client.DataPropertyName = "client";
            this.client.HeaderText = "Klijent";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // issuing_date
            // 
            this.issuing_date.DataPropertyName = "issuing_date";
            this.issuing_date.HeaderText = "Datum";
            this.issuing_date.Name = "issuing_date";
            this.issuing_date.ReadOnly = true;
            // 
            // renting_status
            // 
            this.renting_status.DataPropertyName = "renting_status";
            this.renting_status.HeaderText = "Status";
            this.renting_status.Name = "renting_status";
            this.renting_status.ReadOnly = true;
            // 
            // previewTransport
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "🔎";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.previewTransport.DefaultCellStyle = dataGridViewCellStyle2;
            this.previewTransport.HeaderText = "";
            this.previewTransport.Name = "previewTransport";
            this.previewTransport.ReadOnly = true;
            this.previewTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.previewTransport.Width = 40;
            // 
            // deleteStatus
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "💰";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.deleteStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.deleteStatus.HeaderText = "";
            this.deleteStatus.Name = "deleteStatus";
            this.deleteStatus.ReadOnly = true;
            this.deleteStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteStatus.Width = 40;
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
            this.minimizeBtn.Location = new System.Drawing.Point(1568, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(44, 51);
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
            this.exitBtn.Location = new System.Drawing.Point(1618, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(51, 51);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.StorageRentingRecordFormTblLayout.SetColumnSpan(this.lblTitle, 3);
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(392, 57);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "EVIDENCIJA LAGEROVANJA";
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
            this.backBtn.Location = new System.Drawing.Point(1518, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 51);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.Transparent;
            this.searchLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.White;
            this.searchLbl.Location = new System.Drawing.Point(1083, 87);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(429, 27);
            this.searchLbl.TabIndex = 41;
            this.searchLbl.Text = "Pretraži ";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // searchRentingTxtBox
            // 
            this.searchRentingTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchRentingTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchRentingTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRentingTxtBox.Location = new System.Drawing.Point(1130, 117);
            this.searchRentingTxtBox.Multiline = true;
            this.searchRentingTxtBox.Name = "searchRentingTxtBox";
            this.searchRentingTxtBox.ShortcutsEnabled = false;
            this.searchRentingTxtBox.Size = new System.Drawing.Size(335, 31);
            this.searchRentingTxtBox.TabIndex = 5;
            this.searchRentingTxtBox.TextChanged += new System.EventHandler(this.searchRentingTxtBox_TextChanged);
            // 
            // StorageRentingRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 849);
            this.Controls.Add(this.StorageRentingRecordFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageRentingRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageRentingRecordsForm";
            this.StorageRentingRecordFormTblLayout.ResumeLayout(false);
            this.StorageRentingRecordFormTblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageRentingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StorageRentingRecordFormTblLayout;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchRentingTxtBox;
        private System.Windows.Forms.DataGridView StorageRentingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_renting_storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_client_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuing_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn renting_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn previewTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteStatus;
    }
}