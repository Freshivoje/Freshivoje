using MySql.Data.MySqlClient;
using System;
using System.Resources;
using System.Windows.Forms;

namespace Freshivoje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Disables flickering on FormLoad
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = "SELECT * FROM `users` WHERE `username` = @username and `password` = @password"
            };
            mySqlCommand.Parameters.AddWithValue("@username", username);
            mySqlCommand.Parameters.AddWithValue("@password", password);
            var userId = Convert.ToInt32(DbConnection.getValue(mySqlCommand));

            if (userId == 0)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.invalidUsernamePassword);
                return;
            }  else if (userId == -1)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.errorMsg);
                return;
            }

            // ODLICNA STVAR (RADI KAO SESIJA U PHP-u
            // Properties.Settings.Default.currentUserId = 1;
            usernameTxtBox.ResetText();
            passwordTxtBox.ResetText();
            usernameTxtBox.Select();
            Close();
        }

        public void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
    }
}
