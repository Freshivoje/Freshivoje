namespace Freshivoje.Custom_Forms
{
    partial class CustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog));
            this.customDialogTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dialogMsgLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.customDialogTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // customDialogTblLayout
            // 
            this.customDialogTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.customDialogTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.customDialogTblLayout.ColumnCount = 2;
            this.customDialogTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customDialogTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.customDialogTblLayout.Controls.Add(this.cancelBtn, 0, 1);
            this.customDialogTblLayout.Controls.Add(this.dialogMsgLbl, 0, 0);
            this.customDialogTblLayout.Controls.Add(this.confirmBtn, 0, 1);
            this.customDialogTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDialogTblLayout.Location = new System.Drawing.Point(5, 5);
            this.customDialogTblLayout.Name = "customDialogTblLayout";
            this.customDialogTblLayout.RowCount = 2;
            this.customDialogTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.customDialogTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.customDialogTblLayout.Size = new System.Drawing.Size(521, 315);
            this.customDialogTblLayout.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 5;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(313, 211);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(154, 72);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "NE";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dialogMsgLbl
            // 
            this.dialogMsgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogMsgLbl.AutoEllipsis = true;
            this.dialogMsgLbl.AutoSize = true;
            this.dialogMsgLbl.BackColor = System.Drawing.Color.Transparent;
            this.customDialogTblLayout.SetColumnSpan(this.dialogMsgLbl, 2);
            this.dialogMsgLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogMsgLbl.ForeColor = System.Drawing.Color.White;
            this.dialogMsgLbl.Location = new System.Drawing.Point(3, 0);
            this.dialogMsgLbl.Name = "dialogMsgLbl";
            this.dialogMsgLbl.Size = new System.Drawing.Size(515, 180);
            this.dialogMsgLbl.TabIndex = 10;
            this.dialogMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.confirmBtn.Location = new System.Drawing.Point(53, 211);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(154, 72);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "DA";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 325);
            this.Controls.Add(this.customDialogTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.customDialogTblLayout.ResumeLayout(false);
            this.customDialogTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customDialogTblLayout;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label dialogMsgLbl;
        private System.Windows.Forms.Button confirmBtn;
    }
}