namespace Freshivoje.Storage
{
    partial class ChooseStorageMethodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseStorageMethodForm));
            this.mainFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.recordBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
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
            this.mainFormTblLayout.Controls.Add(this.insertBtn, 1, 1);
            this.mainFormTblLayout.Controls.Add(this.recordBtn, 1, 2);
            this.mainFormTblLayout.Controls.Add(this.outBtn, 1, 3);
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
            this.mainFormTblLayout.Size = new System.Drawing.Size(639, 696);
            this.mainFormTblLayout.TabIndex = 2;
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
            this.titleLbl.Size = new System.Drawing.Size(156, 60);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "KOMORA :";
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
            this.exitBtn.Location = new System.Drawing.Point(592, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(44, 54);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 5;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(103, 184);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(433, 65);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "ULAZ";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.Color.Transparent;
            this.recordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recordBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.recordBtn.FlatAppearance.BorderSize = 5;
            this.recordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.recordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.recordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordBtn.ForeColor = System.Drawing.Color.White;
            this.recordBtn.Location = new System.Drawing.Point(103, 376);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(433, 65);
            this.recordBtn.TabIndex = 1;
            this.recordBtn.Text = "EVIDENCIJA ";
            this.recordBtn.UseVisualStyleBackColor = false;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.BackColor = System.Drawing.Color.Transparent;
            this.outBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.outBtn.FlatAppearance.BorderSize = 5;
            this.outBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.outBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.outBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBtn.ForeColor = System.Drawing.Color.White;
            this.outBtn.Location = new System.Drawing.Point(103, 568);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(433, 65);
            this.outBtn.TabIndex = 2;
            this.outBtn.Text = "IZLAZ";
            this.outBtn.UseVisualStyleBackColor = false;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // ChooseStorageMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 696);
            this.Controls.Add(this.mainFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseStorageMethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseStorageMethodForm";
            this.mainFormTblLayout.ResumeLayout(false);
            this.mainFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormTblLayout;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button outBtn;
    }
}