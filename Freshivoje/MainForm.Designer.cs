namespace Freshivoje
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.paymentsBtn = new System.Windows.Forms.Button();
            this.packagesBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.transportBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
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
            this.mainFormTblLayout.Controls.Add(this.minimizeBtn, 2, 0);
            this.mainFormTblLayout.Controls.Add(this.exitBtn, 3, 0);
            this.mainFormTblLayout.Controls.Add(this.insertBtn, 1, 1);
            this.mainFormTblLayout.Controls.Add(this.paymentsBtn, 1, 2);
            this.mainFormTblLayout.Controls.Add(this.packagesBtn, 1, 3);
            this.mainFormTblLayout.Controls.Add(this.logoutBtn, 1, 7);
            this.mainFormTblLayout.Controls.Add(this.transportBtn, 1, 5);
            this.mainFormTblLayout.Controls.Add(this.settingsBtn, 1, 6);
            this.mainFormTblLayout.Controls.Add(this.inventoryBtn, 1, 4);
            this.mainFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTblLayout.Location = new System.Drawing.Point(5, 5);
            this.mainFormTblLayout.Name = "mainFormTblLayout";
            this.mainFormTblLayout.RowCount = 9;
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.mainFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainFormTblLayout.Size = new System.Drawing.Size(611, 618);
            this.mainFormTblLayout.TabIndex = 0;
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
            this.titleLbl.Size = new System.Drawing.Size(189, 60);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "FRESHIVOJE";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.minimizeBtn.Location = new System.Drawing.Point(514, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(44, 54);
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
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(564, 3);
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
            this.insertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 5;
            this.insertBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.White;
            this.insertBtn.Location = new System.Drawing.Point(227, 63);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(157, 65);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "ULAZ";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // paymentsBtn
            // 
            this.paymentsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentsBtn.BackColor = System.Drawing.Color.Transparent;
            this.paymentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.paymentsBtn.FlatAppearance.BorderSize = 5;
            this.paymentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.paymentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.paymentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentsBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsBtn.ForeColor = System.Drawing.Color.White;
            this.paymentsBtn.Location = new System.Drawing.Point(228, 134);
            this.paymentsBtn.Name = "paymentsBtn";
            this.paymentsBtn.Size = new System.Drawing.Size(154, 65);
            this.paymentsBtn.TabIndex = 1;
            this.paymentsBtn.Text = "EVIDENCIJA";
            this.paymentsBtn.UseVisualStyleBackColor = false;
            this.paymentsBtn.Click += new System.EventHandler(this.paymentsBtn_Click);
            // 
            // packagesBtn
            // 
            this.packagesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.packagesBtn.BackColor = System.Drawing.Color.Transparent;
            this.packagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.packagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.packagesBtn.FlatAppearance.BorderSize = 5;
            this.packagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.packagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.packagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packagesBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagesBtn.ForeColor = System.Drawing.Color.White;
            this.packagesBtn.Location = new System.Drawing.Point(228, 205);
            this.packagesBtn.Name = "packagesBtn";
            this.packagesBtn.Size = new System.Drawing.Size(154, 65);
            this.packagesBtn.TabIndex = 2;
            this.packagesBtn.Text = "AMBALAŽE";
            this.packagesBtn.UseVisualStyleBackColor = false;
            this.packagesBtn.Click += new System.EventHandler(this.packagesBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutBtn.FlatAppearance.BorderSize = 5;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(228, 489);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(154, 65);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "ODJAVA";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // transportBtn
            // 
            this.transportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transportBtn.BackColor = System.Drawing.Color.Transparent;
            this.transportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transportBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transportBtn.FlatAppearance.BorderSize = 5;
            this.transportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.transportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.transportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transportBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportBtn.ForeColor = System.Drawing.Color.White;
            this.transportBtn.Location = new System.Drawing.Point(228, 347);
            this.transportBtn.Name = "transportBtn";
            this.transportBtn.Size = new System.Drawing.Size(154, 65);
            this.transportBtn.TabIndex = 4;
            this.transportBtn.Text = "PUT";
            this.transportBtn.UseVisualStyleBackColor = false;
            this.transportBtn.Click += new System.EventHandler(this.transportBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.BorderSize = 5;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(228, 418);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(154, 65);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "OPCIJE";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.inventoryBtn.FlatAppearance.BorderSize = 5;
            this.inventoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.Location = new System.Drawing.Point(228, 276);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(154, 65);
            this.inventoryBtn.TabIndex = 3;
            this.inventoryBtn.Text = "MAGACIN";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 628);
            this.Controls.Add(this.mainFormTblLayout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freshivoje";
            this.mainFormTblLayout.ResumeLayout(false);
            this.mainFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormTblLayout;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button paymentsBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button packagesBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button transportBtn;
    }
}

