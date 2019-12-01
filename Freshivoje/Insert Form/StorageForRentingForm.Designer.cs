namespace Freshivoje.Insert_Form
{
    partial class StorageForRentingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForRentingForm));
            this.insertFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.endDataOfRentPicker = new System.Windows.Forms.DateTimePicker();
            this.storagePositionCmbBox = new System.Windows.Forms.ComboBox();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.partLbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.pricelTxtBox = new System.Windows.Forms.TextBox();
            this.finishInsertBtn = new System.Windows.Forms.Button();
            this.rentingData = new System.Windows.Forms.Label();
            this.crateQuantityLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.Label();
            this.rentingDataPicker = new System.Windows.Forms.DateTimePicker();
            this.insertFormTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertFormTblLayout
            // 
            this.insertFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.insertFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.insertFormTblLayout.ColumnCount = 7;
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.insertFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.insertFormTblLayout.Controls.Add(this.endDataOfRentPicker, 3, 4);
            this.insertFormTblLayout.Controls.Add(this.storagePositionCmbBox, 1, 2);
            this.insertFormTblLayout.Controls.Add(this.minimizeBtn, 5, 0);
            this.insertFormTblLayout.Controls.Add(this.exitBtn, 6, 0);
            this.insertFormTblLayout.Controls.Add(this.partLbl, 1, 1);
            this.insertFormTblLayout.Controls.Add(this.lblTitle, 0, 0);
            this.insertFormTblLayout.Controls.Add(this.backBtn, 4, 0);
            this.insertFormTblLayout.Controls.Add(this.pricelTxtBox, 3, 2);
            this.insertFormTblLayout.Controls.Add(this.finishInsertBtn, 2, 7);
            this.insertFormTblLayout.Controls.Add(this.rentingData, 1, 3);
            this.insertFormTblLayout.Controls.Add(this.crateQuantityLbl, 3, 3);
            this.insertFormTblLayout.Controls.Add(this.priceTxt, 3, 1);
            this.insertFormTblLayout.Controls.Add(this.rentingDataPicker, 1, 4);
            this.insertFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insertFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.insertFormTblLayout.Name = "insertFormTblLayout";
            this.insertFormTblLayout.RowCount = 9;
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71062F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.77203F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07391F));
            this.insertFormTblLayout.Size = new System.Drawing.Size(1940, 879);
            this.insertFormTblLayout.TabIndex = 3;
            // 
            // endDataOfRentPicker
            // 
            this.endDataOfRentPicker.CustomFormat = " yyyy-MM-dd";
            this.endDataOfRentPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.endDataOfRentPicker.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDataOfRentPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDataOfRentPicker.Location = new System.Drawing.Point(1069, 391);
            this.endDataOfRentPicker.Name = "endDataOfRentPicker";
            this.endDataOfRentPicker.Size = new System.Drawing.Size(710, 30);
            this.endDataOfRentPicker.TabIndex = 36;
            // 
            // storagePositionCmbBox
            // 
            this.storagePositionCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.storagePositionCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storagePositionCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.storagePositionCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storagePositionCmbBox.FormattingEnabled = true;
            this.storagePositionCmbBox.Location = new System.Drawing.Point(153, 197);
            this.storagePositionCmbBox.Name = "storagePositionCmbBox";
            this.storagePositionCmbBox.Size = new System.Drawing.Size(710, 31);
            this.storagePositionCmbBox.TabIndex = 34;
            this.storagePositionCmbBox.TabStop = false;
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
            this.minimizeBtn.Location = new System.Drawing.Point(1835, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.minimizeBtn.Size = new System.Drawing.Size(50, 91);
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
            this.exitBtn.Location = new System.Drawing.Point(1891, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(46, 91);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // partLbl
            // 
            this.partLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.partLbl.AutoSize = true;
            this.partLbl.BackColor = System.Drawing.Color.Transparent;
            this.partLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLbl.ForeColor = System.Drawing.Color.White;
            this.partLbl.Location = new System.Drawing.Point(211, 167);
            this.partLbl.Name = "partLbl";
            this.partLbl.Size = new System.Drawing.Size(594, 27);
            this.partLbl.TabIndex = 16;
            this.partLbl.Text = "Ime odeljaka / Količina artikala(kg) / Broj ambalaža";
            this.partLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTitle.Size = new System.Drawing.Size(214, 97);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "LAGEROVANJE";
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
            this.backBtn.Location = new System.Drawing.Point(1785, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(44, 91);
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pricelTxtBox
            // 
            this.pricelTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pricelTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pricelTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelTxtBox.Location = new System.Drawing.Point(1069, 197);
            this.pricelTxtBox.Multiline = true;
            this.pricelTxtBox.Name = "pricelTxtBox";
            this.pricelTxtBox.ShortcutsEnabled = false;
            this.pricelTxtBox.Size = new System.Drawing.Size(710, 31);
            this.pricelTxtBox.TabIndex = 6;
            this.pricelTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // finishInsertBtn
            // 
            this.finishInsertBtn.BackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishInsertBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishInsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finishInsertBtn.FlatAppearance.BorderSize = 5;
            this.finishInsertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.finishInsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishInsertBtn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishInsertBtn.ForeColor = System.Drawing.Color.White;
            this.finishInsertBtn.Location = new System.Drawing.Point(871, 687);
            this.finishInsertBtn.Margin = new System.Windows.Forms.Padding(5);
            this.finishInsertBtn.Name = "finishInsertBtn";
            this.finishInsertBtn.Size = new System.Drawing.Size(190, 87);
            this.finishInsertBtn.TabIndex = 31;
            this.finishInsertBtn.TabStop = false;
            this.finishInsertBtn.Text = "Završi unos";
            this.finishInsertBtn.UseVisualStyleBackColor = false;
            this.finishInsertBtn.Click += new System.EventHandler(this.finishInsertBtn_Click);
            // 
            // rentingData
            // 
            this.rentingData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rentingData.AutoSize = true;
            this.rentingData.BackColor = System.Drawing.Color.Transparent;
            this.rentingData.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentingData.ForeColor = System.Drawing.Color.White;
            this.rentingData.Location = new System.Drawing.Point(336, 361);
            this.rentingData.Name = "rentingData";
            this.rentingData.Size = new System.Drawing.Size(344, 27);
            this.rentingData.TabIndex = 17;
            this.rentingData.Text = "Datum početka iznajmljivanja";
            this.rentingData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crateQuantityLbl
            // 
            this.crateQuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.crateQuantityLbl.AutoSize = true;
            this.crateQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.crateQuantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crateQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.crateQuantityLbl.Location = new System.Drawing.Point(1274, 361);
            this.crateQuantityLbl.Name = "crateQuantityLbl";
            this.crateQuantityLbl.Size = new System.Drawing.Size(300, 27);
            this.crateQuantityLbl.TabIndex = 24;
            this.crateQuantityLbl.Text = "Datum kraj iznajmljivanja";
            this.crateQuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.priceTxt.AutoSize = true;
            this.priceTxt.BackColor = System.Drawing.Color.Transparent;
            this.priceTxt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.ForeColor = System.Drawing.Color.White;
            this.priceTxt.Location = new System.Drawing.Point(1357, 167);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(134, 27);
            this.priceTxt.TabIndex = 33;
            this.priceTxt.Text = "Cena(RSD)";
            this.priceTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentingDataPicker
            // 
            this.rentingDataPicker.CustomFormat = " yyyy-MM-dd";
            this.rentingDataPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentingDataPicker.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentingDataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentingDataPicker.Location = new System.Drawing.Point(153, 391);
            this.rentingDataPicker.Name = "rentingDataPicker";
            this.rentingDataPicker.Size = new System.Drawing.Size(710, 30);
            this.rentingDataPicker.TabIndex = 35;
            // 
            // StorageForRentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 879);
            this.Controls.Add(this.insertFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StorageForRentingForm";
            this.Text = "StorageForRentingForm";
            this.insertFormTblLayout.ResumeLayout(false);
            this.insertFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel insertFormTblLayout;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label partLbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox pricelTxtBox;
        private System.Windows.Forms.Button finishInsertBtn;
        private System.Windows.Forms.Label rentingData;
        private System.Windows.Forms.Label crateQuantityLbl;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.ComboBox storagePositionCmbBox;
        private System.Windows.Forms.DateTimePicker endDataOfRentPicker;
        private System.Windows.Forms.DateTimePicker rentingDataPicker;
    }
}