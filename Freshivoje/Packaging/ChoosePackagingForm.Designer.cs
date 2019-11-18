namespace Freshivoje.Packaging
{
    partial class ChoosePackagingForm
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
            this.mainFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.forrentBtn = new System.Windows.Forms.Button();
            this.receiptStorageBtn = new System.Windows.Forms.Button();
            this.receiptClientBtn = new System.Windows.Forms.Button();
            this.mainFormTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormTblLayout
            // 
            this.mainFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.mainFormTblLayout.ColumnCount = 4;
            this.mainFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainFormTblLayout.Controls.Add(this.titleLbl, 0, 0);
            this.mainFormTblLayout.Controls.Add(this.exitBtn, 3, 0);
            this.mainFormTblLayout.Controls.Add(this.forrentBtn, 1, 1);
            this.mainFormTblLayout.Controls.Add(this.receiptStorageBtn, 1, 2);
            this.mainFormTblLayout.Controls.Add(this.receiptClientBtn, 1, 3);
            this.mainFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.mainFormTblLayout.Name = "mainFormTblLayout";
            this.mainFormTblLayout.RowCount = 5;
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFormTblLayout.Size = new System.Drawing.Size(563, 649);
            this.mainFormTblLayout.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.mainFormTblLayout.SetColumnSpan(this.titleLbl, 2);
            this.titleLbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleLbl.Size = new System.Drawing.Size(161, 60);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "AMBALAŽE";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(516, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(44, 54);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // forrentBtn
            // 
            this.forrentBtn.BackColor = System.Drawing.Color.Transparent;
            this.forrentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forrentBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.forrentBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.forrentBtn.FlatAppearance.BorderSize = 5;
            this.forrentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.forrentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.forrentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forrentBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forrentBtn.ForeColor = System.Drawing.Color.White;
            this.forrentBtn.Location = new System.Drawing.Point(103, 168);
            this.forrentBtn.Name = "forrentBtn";
            this.forrentBtn.Size = new System.Drawing.Size(357, 65);
            this.forrentBtn.TabIndex = 0;
            this.forrentBtn.Text = "IZDAVANJE AMBALAŽA";
            this.forrentBtn.UseVisualStyleBackColor = false;
            // 
            // receiptStorageBtn
            // 
            this.receiptStorageBtn.BackColor = System.Drawing.Color.Transparent;
            this.receiptStorageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptStorageBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receiptStorageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.receiptStorageBtn.FlatAppearance.BorderSize = 5;
            this.receiptStorageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.receiptStorageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.receiptStorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptStorageBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptStorageBtn.ForeColor = System.Drawing.Color.White;
            this.receiptStorageBtn.Location = new System.Drawing.Point(103, 344);
            this.receiptStorageBtn.Name = "receiptStorageBtn";
            this.receiptStorageBtn.Size = new System.Drawing.Size(357, 65);
            this.receiptStorageBtn.TabIndex = 1;
            this.receiptStorageBtn.Text = "EVIDENCIJA ZADUŽENJA HLADNJAČE";
            this.receiptStorageBtn.UseVisualStyleBackColor = false;
            // 
            // receiptClientBtn
            // 
            this.receiptClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.receiptClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptClientBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.receiptClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.receiptClientBtn.FlatAppearance.BorderSize = 5;
            this.receiptClientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.receiptClientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.receiptClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptClientBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptClientBtn.ForeColor = System.Drawing.Color.White;
            this.receiptClientBtn.Location = new System.Drawing.Point(103, 520);
            this.receiptClientBtn.Name = "receiptClientBtn";
            this.receiptClientBtn.Size = new System.Drawing.Size(357, 65);
            this.receiptClientBtn.TabIndex = 2;
            this.receiptClientBtn.Text = "EVIDENCIJA ZADUŽENJA  KLIJENTA";
            this.receiptClientBtn.UseVisualStyleBackColor = false;
            // 
            // ChoosePackagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 649);
            this.Controls.Add(this.mainFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoosePackagingForm";
            this.Text = "ChoosePackagingForm";
            this.mainFormTblLayout.ResumeLayout(false);
            this.mainFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormTblLayout;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button forrentBtn;
        private System.Windows.Forms.Button receiptStorageBtn;
        private System.Windows.Forms.Button receiptClientBtn;
    }
}