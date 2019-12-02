namespace Freshivoje.Storage
{
    partial class ChooseInsertStorageMethodForm
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
            this.articleBtn = new System.Windows.Forms.Button();
            this.ambalageBtn = new System.Windows.Forms.Button();
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
            this.mainFormTblLayout.Controls.Add(this.articleBtn, 1, 1);
            this.mainFormTblLayout.Controls.Add(this.ambalageBtn, 1, 2);
            this.mainFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTblLayout.Location = new System.Drawing.Point(0, 0);
            this.mainFormTblLayout.Name = "mainFormTblLayout";
            this.mainFormTblLayout.RowCount = 4;
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFormTblLayout.Size = new System.Drawing.Size(505, 588);
            this.mainFormTblLayout.TabIndex = 3;
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
            this.titleLbl.Size = new System.Drawing.Size(85, 60);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "ULAZ";
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
            this.exitBtn.Location = new System.Drawing.Point(458, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(44, 54);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.TabStop = false;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // articleBtn
            // 
            this.articleBtn.BackColor = System.Drawing.Color.Transparent;
            this.articleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.articleBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.articleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.articleBtn.FlatAppearance.BorderSize = 5;
            this.articleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.articleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.articleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articleBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleBtn.ForeColor = System.Drawing.Color.White;
            this.articleBtn.Location = new System.Drawing.Point(103, 226);
            this.articleBtn.Name = "articleBtn";
            this.articleBtn.Size = new System.Drawing.Size(299, 65);
            this.articleBtn.TabIndex = 0;
            this.articleBtn.Text = "ARTIKLI";
            this.articleBtn.UseVisualStyleBackColor = false;
            this.articleBtn.Click += new System.EventHandler(this.articleBtn_Click);
            // 
            // ambalageBtn
            // 
            this.ambalageBtn.BackColor = System.Drawing.Color.Transparent;
            this.ambalageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ambalageBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ambalageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ambalageBtn.FlatAppearance.BorderSize = 5;
            this.ambalageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ambalageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ambalageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambalageBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambalageBtn.ForeColor = System.Drawing.Color.White;
            this.ambalageBtn.Location = new System.Drawing.Point(103, 460);
            this.ambalageBtn.Name = "ambalageBtn";
            this.ambalageBtn.Size = new System.Drawing.Size(299, 65);
            this.ambalageBtn.TabIndex = 1;
            this.ambalageBtn.Text = "AMBALAŽE";
            this.ambalageBtn.UseVisualStyleBackColor = false;
            this.ambalageBtn.Click += new System.EventHandler(this.ambalageBtn_Click);
            // 
            // ChooseInsertStorageMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 588);
            this.Controls.Add(this.mainFormTblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseInsertStorageMethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseInsertStorageMethodForm";
            this.mainFormTblLayout.ResumeLayout(false);
            this.mainFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormTblLayout;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button articleBtn;
        private System.Windows.Forms.Button ambalageBtn;
    }
}