namespace Freshivoje
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginFormTblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.loginFormTblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginFormTblLayout
            // 
            this.loginFormTblLayout.BackColor = System.Drawing.Color.Transparent;
            this.loginFormTblLayout.BackgroundImage = global::Freshivoje.Properties.Resources.background;
            this.loginFormTblLayout.ColumnCount = 4;
            this.loginFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.loginFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginFormTblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.loginFormTblLayout.Controls.Add(this.titleLbl, 0, 0);
            this.loginFormTblLayout.Controls.Add(this.exitBtn, 3, 0);
            this.loginFormTblLayout.Controls.Add(this.loginBtn, 1, 6);
            this.loginFormTblLayout.Controls.Add(this.usernameTxtBox, 1, 3);
            this.loginFormTblLayout.Controls.Add(this.passwordTxtBox, 1, 5);
            this.loginFormTblLayout.Controls.Add(this.passwordLbl, 1, 4);
            this.loginFormTblLayout.Controls.Add(this.usernameLbl, 1, 2);
            this.loginFormTblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFormTblLayout.Location = new System.Drawing.Point(5, 5);
            this.loginFormTblLayout.Name = "loginFormTblLayout";
            this.loginFormTblLayout.RowCount = 8;
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.loginFormTblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loginFormTblLayout.Size = new System.Drawing.Size(611, 618);
            this.loginFormTblLayout.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.loginFormTblLayout.SetColumnSpan(this.titleLbl, 2);
            this.titleLbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleLbl.Size = new System.Drawing.Size(134, 60);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "PRIJAVA";
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
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
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
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 5;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(228, 384);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(154, 72);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "PRIJAVI SE";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(173, 183);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ShortcutsEnabled = false;
            this.usernameTxtBox.Size = new System.Drawing.Size(264, 31);
            this.usernameTxtBox.TabIndex = 1;
            this.usernameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(173, 303);
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '●';
            this.passwordTxtBox.ShortcutsEnabled = false;
            this.passwordTxtBox.Size = new System.Drawing.Size(264, 31);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockEnter);
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(256, 273);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(98, 27);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Lozinka";
            this.passwordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(217, 153);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(176, 27);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "Korisničko ime";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 628);
            this.Controls.Add(this.loginFormTblLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.loginFormTblLayout.ResumeLayout(false);
            this.loginFormTblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginFormTblLayout;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button exitBtn;
    }
}