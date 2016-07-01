using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private bool HasError()
        {
            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text == txtFirstName.PlaceHolderText)
            {
                MessageBox.Show("First name cannot be empty.");
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text == txtLastName.PlaceHolderText)
            {
                MessageBox.Show("Last name cannot be empty.");
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtPhoneNumber.Text) || txtPhoneNumber.Text == txtPhoneNumber.PlaceHolderText)
            {
                MessageBox.Show("Phone number cannot be empty.");
                return true;
            }
            if ((!String.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text != txtNewPassword.PlaceHolderText) || (!String.IsNullOrWhiteSpace(txtConfirmNewPassword.Text) || txtConfirmNewPassword.Text != txtConfirmNewPassword.PlaceHolderText))
            {
                if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                {
                    MessageBox.Show("New passwords doesn't match.");
                    return true;
                }
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == txtPassword.PlaceHolderText)
            {
                MessageBox.Show("Current password cannot be empty.");
                return true;
            }
            return false;
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Clear();
            for (int i = 0; i < Bank.Instance.Accounts.Count; i++)
            {
                cbAccounts.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
            }
            cbAccounts.SelectedIndex = 0;
            cbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (HasError())
                return;

            string firstName, lastName, address, phoneNumber, newPassword, password;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;
            password = txtPassword.Text;
            newPassword = txtNewPassword.Text;

            Account account = Bank.Instance.Accounts[cbAccounts.SelectedIndex];
            account.FirstName = firstName;
            account.LastName = lastName;
            account.Address = address;
            account.PhoneNumber = phoneNumber;
            string passwordHash = Utils.GetMD5String(password);
            if(passwordHash != account.PasswordHash)
            {
                MessageBox.Show("Current password is not valid.");
                return;
            }
            if ((!String.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text != txtNewPassword.PlaceHolderText) || (!String.IsNullOrWhiteSpace(txtConfirmNewPassword.Text) || txtNewPassword.Text != txtNewPassword.PlaceHolderText))
            {
                if (txtNewPassword.Text == txtConfirmNewPassword.Text)
                {
                    account.PasswordHash = Utils.GetMD5String(txtNewPassword.Text);
                }
            }
            AccountManagementState state = Bank.Instance.Modify(account);
            if (state == AccountManagementState.Successful)
            {
                MessageBox.Show("Account has been modified.");

                Main.Instance.ReloadList();
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Modifying was unsuccessful!");
        }

        private void Modify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
        }

        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account account = Bank.Instance.Accounts[cbAccounts.SelectedIndex];

            txtFirstName.RemovePlaceHolder();
            txtLastName.RemovePlaceHolder();
            txtAddress.RemovePlaceHolder();
            txtPhoneNumber.RemovePlaceHolder();

            txtFirstName.Text = account.FirstName;
            txtLastName.Text = account.LastName;
            txtAddress.Text = account.Address;
            txtPhoneNumber.Text = account.PhoneNumber;
        }
    }
}
