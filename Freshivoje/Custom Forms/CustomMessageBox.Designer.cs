namespace Freshivoje
{
    partial class CustomMessageBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.customMessageBoxTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.errorMsgLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.customMessageBoxTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // customMessageBoxTblLayout
            // 
            this.customMessageBoxTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.customMessageBoxTblLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customMessageBoxTblLayout.BackgroundImage")));
            this.customMessageBoxTblLayout.ColumnCount = 1;
            this.customMessageBoxTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 521F));
            this.customMessageBoxTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.Controls.Add(this.errorMsgLbl, 0, 0);
            this.customMessageBoxTblLayout.Controls.Add(this.confirmBtn, 0, 1);
            this.customMessageBoxTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customMessageBoxTblLayout.Location = new System.Drawing.Point(5, 5);
            this.customMessageBoxTblLayout.Name = "customMessageBoxTblLayout";
            this.customMessageBoxTblLayout.RowCount = 2;
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customMessageBoxTblLayout.Size = new System.Drawing.Size(521, 315);
            this.customMessageBoxTblLayout.TabIndex = 2;
            // 
            // errorMsgLbl
            // 
            this.errorMsgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMsgLbl.AutoEllipsis = true;
            this.errorMsgLbl.AutoSize = true;
            this.errorMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorMsgLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsgLbl.ForeColor = System.Drawing.Color.White;
            this.errorMsgLbl.Location = new System.Drawing.Point(3, 0);
            this.errorMsgLbl.Name = "errorMsgLbl";
            this.errorMsgLbl.Size = new System.Drawing.Size(515, 180);
            this.errorMsgLbl.TabIndex = 10;
            this.errorMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.confirmBtn.FlatAppearance.BorderSize = 5;
            this.confirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(183, 211);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(154, 72);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "U REDU";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 325);
            this.Controls.Add(this.customMessageBoxTblLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obaveštenje";
            this.customMessageBoxTblLayout.ResumeLayout(false);
            this.customMessageBoxTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customMessageBoxTblLayout;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label errorMsgLbl;
        private System.Windows.Forms.Timer timer;
    }
}