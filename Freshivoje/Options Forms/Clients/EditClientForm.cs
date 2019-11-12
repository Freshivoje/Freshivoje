using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Freshivoje.Options_Forms
{
    public partial class EditClientForm : Form
    {
        private readonly int _clientId;
        public EditClientForm(Client client)
        {
            InitializeComponent();
            _clientId = client._id;
            clientFirstNameTxtBox.Text = client._firstName;
            clientLastNameTxtBox.Text = client._lastName;
            clientAddressTxtBox.Text = client._address;
            clientPhoneTxtBox.Text = client._phone;
            clientTypeCmbBox.SelectedIndex = client._type == "Fizičko lice" ? 0 : 1;
            clientCompanyNameTxtBox.Text = client._companyName;
            clientJMBGTxtBox.Text = client._JMBG;
            clientTypeCmbBox.SelectedItem = client._type;
            clientZipCodeTxtBox.Text = client._zipCode;
            clientBankAccountTxtBox.Text = client._bankAccount;
            clientSPOTxtBox.Text = client._SPO;
            clientPIBTxtBox.Text = client._PIB;
            clientBPGTxtBox.Text = client._BPG;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void onlyNumerics(object sender, KeyPressEventArgs e)
        {
            {
                // Limit input to numbers only
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientFirstNameTxtBox.Text) || string.IsNullOrWhiteSpace(clientLastNameTxtBox.Text) || string.IsNullOrWhiteSpace(clientAddressTxtBox.Text)
                || string.IsNullOrWhiteSpace(clientPhoneTxtBox.Text) || string.IsNullOrWhiteSpace(clientJMBGTxtBox.Text) || string.IsNullOrWhiteSpace(clientZipCodeTxtBox.Text)
                || string.IsNullOrWhiteSpace(clientBankAccountTxtBox.Text) || string.IsNullOrWhiteSpace(clientCompanyNameTxtBox.Text) || string.IsNullOrWhiteSpace(clientPIBTxtBox.Text)
                || string.IsNullOrWhiteSpace(clientBPGTxtBox.Text) || string.IsNullOrWhiteSpace(clientSPOTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.emptyInputErrorMsg);
                return;
            }

            if (clientJMBGTxtBox.Text.Length != 13)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.invalidJMBGMsg);
                clientJMBGTxtBox.Focus();
                return;
            }

            if (clientBPGTxtBox.Text.Length != 12)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.invalidBPGMsg);
                clientBPGTxtBox.Focus();
                return;
            }

            if (clientBankAccountTxtBox.Text.Length != 13)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.invalidBankAccountMsg);
                clientBankAccountTxtBox.Focus();
                return;
            }

            if (clientZipCodeTxtBox.Text.Length != 5)
            {
                CustomMessageBox.ShowDialog(this, Properties.Resources.invalidZipCodeMsg);
                clientZipCodeTxtBox.Focus();
                return;
            }

            Client client = new Client(_clientId,
                  clientFirstNameTxtBox.Text, clientLastNameTxtBox.Text, clientAddressTxtBox.Text, clientTypeCmbBox.Text,
                  clientJMBGTxtBox.Text, clientBPGTxtBox.Text, clientZipCodeTxtBox.Text, clientBankAccountTxtBox.Text, clientPhoneTxtBox.Text, clientPIBTxtBox.Text, clientSPOTxtBox.Text, clientCompanyNameTxtBox.Text);
            

            DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da izmenite klijenta?\nIme: {client._firstName} {client._lastName}\nJMBG: {client._JMBG}\nTelefon: {client._phone}\nAdresa: {client._address}");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }

            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = @"UPDATE `clients` SET 
                                                    `first_name`= @firstName,
                                                    `last_name`= @lastName,
                                                    `address`= @address,
                                                    `type`= @type,
                                                    `company_name`= @companyName,
                                                    `JMBG`= @JMBG,
                                                    `PIB`= @PIB,
                                                    `BPG`= @BPG,
                                                    `SPO`= @SPO,
                                                    `zip_code`= @zipCode,
                                                    `bank_account`= @bankAccount,
                                                    `phone`= @phone 
                                WHERE id_client = @clientId"
            };

            mySqlCommand.Parameters.AddWithValue("@clientId", _clientId);
            mySqlCommand.Parameters.AddWithValue("@firstName", client._firstName);
            mySqlCommand.Parameters.AddWithValue("@lastName", client._lastName);
            mySqlCommand.Parameters.AddWithValue("@address", client._address);
            mySqlCommand.Parameters.AddWithValue("@type", client._type);
            mySqlCommand.Parameters.AddWithValue("@companyName", client._companyName);
            mySqlCommand.Parameters.AddWithValue("@JMBG", client._JMBG);
            mySqlCommand.Parameters.AddWithValue("@PIB", client._PIB);
            mySqlCommand.Parameters.AddWithValue("@BPG", client._BPG);
            mySqlCommand.Parameters.AddWithValue("@SPO", client._SPO);
            mySqlCommand.Parameters.AddWithValue("@zipCode", client._zipCode);
            mySqlCommand.Parameters.AddWithValue("@bankAccount", client._bankAccount);
            mySqlCommand.Parameters.AddWithValue("@phone", client._phone);

            DbConnection.executeQuery(mySqlCommand);
            Close();
        }

        private void clientTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                clientCompanyNameLbl.Enabled = false;
                clientSPOLbl.Enabled = false;
                clientPIBLbl.Enabled = false;

                clientCompanyNameTxtBox.Enabled = false;
                clientSPOTxtBox.Enabled = false;
                clientPIBTxtBox.Enabled = false;

                clientCompanyNameTxtBox.Text = Properties.Resources.dashInput;
                clientSPOTxtBox.Text = Properties.Resources.dashInput;
                clientPIBTxtBox.Text = Properties.Resources.dashInput;
            }
            else
            {
                clientCompanyNameLbl.Enabled = true;
                clientSPOLbl.Enabled = true;
                clientPIBLbl.Enabled = true;

                clientCompanyNameTxtBox.Enabled = true;
                clientSPOTxtBox.Enabled = true;
                clientPIBTxtBox.Enabled = true;

                clientCompanyNameTxtBox.ResetText();
                clientSPOTxtBox.ResetText();
                clientPIBTxtBox.ResetText();
            }
        }
    }
}
