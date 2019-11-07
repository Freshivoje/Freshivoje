namespace Freshivoje.Options_Forms
{
    partial class EditPackageForm
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
            this.articleFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.packageQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.packageQuantityLbl = new System.Windows.Forms.Label();
            this.packageCapacityLbl = new System.Windows.Forms.Label();
            this.packageCapacityTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.packageCategoryLbl = new System.Windows.Forms.Label();
            this.packagePriceLbl = new System.Windows.Forms.Label();
            this.packageCategoryCmbBox = new System.Windows.Forms.ComboBox();
            this.packagePriceTxtBox = new System.Windows.Forms.TextBox();
            this.articleFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // articleFormTableLayoutPanel
            // 
            this.articleFormTableLayoutPanel.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.articleFormTableLayoutPanel.ColumnCount = 6;
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.articleFormTableLayoutPanel.Controls.Add(this.packageQuantityTxtBox, 1, 5);
            this.articleFormTableLayoutPanel.Controls.Add(this.packageQuantityLbl, 2, 4);
            this.articleFormTableLayoutPanel.Controls.Add(this.packageCapacityLbl, 2, 0);
            this.articleFormTableLayoutPanel.Controls.Add(this.packageCapacityTxtBox, 1, 1);
            this.articleFormTableLayoutPanel.Controls.Add(this.cancelBtn, 3, 8);
            this.articleFormTableLayoutPanel.Controls.Add(this.editBtn, 1, 8);
            this.articleFormTableLayoutPanel.Controls.Add(this.packageCategoryLbl, 2, 2);
            this.articleFormTableLayoutPanel.Controls.Add(this.packagePriceLbl, 1, 6);
            this.articleFormTableLayoutPanel.Controls.Add(this.packageCategoryCmbBox, 1, 3);
            this.articleFormTableLayoutPanel.Controls.Add(this.packagePriceTxtBox, 1, 7);
            this.articleFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articleFormTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.articleFormTableLayoutPanel.Name = "articleFormTableLayoutPanel";
            this.articleFormTableLayoutPanel.RowCount = 10;
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.articleFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.articleFormTableLayoutPanel.Size = new System.Drawing.Size(666, 668);
            this.articleFormTableLayoutPanel.TabIndex = 2;
            // 
            // packageQuantityTxtBox
            // 
            this.packageQuantityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageQuantityTxtBox, 4);
            this.packageQuantityTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.packageQuantityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageQuantityTxtBox.Location = new System.Drawing.Point(113, 305);
            this.packageQuantityTxtBox.MaxLength = 6;
            this.packageQuantityTxtBox.Multiline = true;
            this.packageQuantityTxtBox.Name = "packageQuantityTxtBox";
            this.packageQuantityTxtBox.ShortcutsEnabled = false;
            this.packageQuantityTxtBox.Size = new System.Drawing.Size(438, 31);
            this.packageQuantityTxtBox.TabIndex = 2;
            this.packageQuantityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // packageQuantityLbl
            // 
            this.packageQuantityLbl.AutoSize = true;
            this.packageQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageQuantityLbl, 2);
            this.packageQuantityLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packageQuantityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageQuantityLbl.ForeColor = System.Drawing.Color.White;
            this.packageQuantityLbl.Location = new System.Drawing.Point(224, 275);
            this.packageQuantityLbl.Name = "packageQuantityLbl";
            this.packageQuantityLbl.Size = new System.Drawing.Size(216, 27);
            this.packageQuantityLbl.TabIndex = 23;
            this.packageQuantityLbl.Text = "Količina";
            this.packageQuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packageCapacityLbl
            // 
            this.packageCapacityLbl.AutoSize = true;
            this.packageCapacityLbl.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageCapacityLbl, 2);
            this.packageCapacityLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packageCapacityLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageCapacityLbl.ForeColor = System.Drawing.Color.White;
            this.packageCapacityLbl.Location = new System.Drawing.Point(224, 33);
            this.packageCapacityLbl.Name = "packageCapacityLbl";
            this.packageCapacityLbl.Size = new System.Drawing.Size(216, 27);
            this.packageCapacityLbl.TabIndex = 10;
            this.packageCapacityLbl.Text = "Nosivost (grama)";
            this.packageCapacityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packageCapacityTxtBox
            // 
            this.packageCapacityTxtBox.BackColor = System.Drawing.Color.White;
            this.packageCapacityTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageCapacityTxtBox, 4);
            this.packageCapacityTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.packageCapacityTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageCapacityTxtBox.Location = new System.Drawing.Point(113, 63);
            this.packageCapacityTxtBox.MaxLength = 6;
            this.packageCapacityTxtBox.Multiline = true;
            this.packageCapacityTxtBox.Name = "packageCapacityTxtBox";
            this.packageCapacityTxtBox.ShortcutsEnabled = false;
            this.packageCapacityTxtBox.Size = new System.Drawing.Size(438, 31);
            this.packageCapacityTxtBox.TabIndex = 0;
            this.packageCapacityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.cancelBtn, 2);
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 5;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(373, 532);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(140, 54);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "ODUSTANI";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.editBtn, 2);
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 5;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(144, 532);
            this.editBtn.Margin = new System.Windows.Forms.Padding(5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(154, 54);
            this.editBtn.TabIndex = 20;
            this.editBtn.TabStop = false;
            this.editBtn.Text = "IZMENI";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // packageCategoryLbl
            // 
            this.packageCategoryLbl.AutoSize = true;
            this.packageCategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageCategoryLbl, 2);
            this.packageCategoryLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packageCategoryLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageCategoryLbl.ForeColor = System.Drawing.Color.White;
            this.packageCategoryLbl.Location = new System.Drawing.Point(224, 154);
            this.packageCategoryLbl.Name = "packageCategoryLbl";
            this.packageCategoryLbl.Size = new System.Drawing.Size(216, 27);
            this.packageCategoryLbl.TabIndex = 14;
            this.packageCategoryLbl.Text = "Kategorija";
            this.packageCategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packagePriceLbl
            // 
            this.packagePriceLbl.AutoSize = true;
            this.packagePriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packagePriceLbl, 4);
            this.packagePriceLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packagePriceLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagePriceLbl.ForeColor = System.Drawing.Color.White;
            this.packagePriceLbl.Location = new System.Drawing.Point(113, 396);
            this.packagePriceLbl.Name = "packagePriceLbl";
            this.packagePriceLbl.Size = new System.Drawing.Size(438, 27);
            this.packagePriceLbl.TabIndex = 12;
            this.packagePriceLbl.Text = "Cena ambalaže (RSD)";
            this.packagePriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // packageCategoryCmbBox
            // 
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packageCategoryCmbBox, 4);
            this.packageCategoryCmbBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.packageCategoryCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageCategoryCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.packageCategoryCmbBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageCategoryCmbBox.FormattingEnabled = true;
            this.packageCategoryCmbBox.Location = new System.Drawing.Point(113, 184);
            this.packageCategoryCmbBox.Name = "packageCategoryCmbBox";
            this.packageCategoryCmbBox.Size = new System.Drawing.Size(438, 31);
            this.packageCategoryCmbBox.TabIndex = 1;
            // 
            // packagePriceTxtBox
            // 
            this.packagePriceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.articleFormTableLayoutPanel.SetColumnSpan(this.packagePriceTxtBox, 4);
            this.packagePriceTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.packagePriceTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagePriceTxtBox.Location = new System.Drawing.Point(113, 426);
            this.packagePriceTxtBox.MaxLength = 8;
            this.packagePriceTxtBox.Multiline = true;
            this.packagePriceTxtBox.Name = "packagePriceTxtBox";
            this.packagePriceTxtBox.ShortcutsEnabled = false;
            this.packagePriceTxtBox.Size = new System.Drawing.Size(438, 31);
            this.packagePriceTxtBox.TabIndex = 3;
            this.packagePriceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumerics);
            // 
            // EditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 678);
            this.Controls.Add(this.articleFormTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPackageForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackageForm";
            this.articleFormTableLayoutPanel.ResumeLayout(false);
            this.articleFormTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel articleFormTableLayoutPanel;
        private System.Windows.Forms.Label packageCapacityLbl;
        private System.Windows.Forms.Label packagePriceLbl;
        private System.Windows.Forms.Label packageCategoryLbl;
        private System.Windows.Forms.ComboBox packageCategoryCmbBox;
        private System.Windows.Forms.TextBox packagePriceTxtBox;
        private System.Windows.Forms.TextBox packageCapacityTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label packageQuantityLbl;
        private System.Windows.Forms.TextBox packageQuantityTxtBox;
    }
}