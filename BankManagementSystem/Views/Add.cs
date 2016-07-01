using System;
using System.Windows.Forms;
using BankManagementSystem.Models;
using BankManagementSystem.Utility;

namespace BankManagementSystem.Views
{
    public partial class Add : Form
    {
        public Add()
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
            if (String.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == txtPassword.PlaceHolderText)
            {
                MessageBox.Show("Password cannot be empty.");
                return true;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords doesn't match.");
                return true;
            }
            return false;
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
            Main.Instance.ReloadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (HasError())
                return;
            
            string firstName, lastName, address, phoneNumber, password;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;
            password = txtPassword.Text;

            Account account = new Account()
            {
                Id = Utils.GenerateId(),
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Balance = 0,
                PhoneNumber = phoneNumber,
                PasswordHash = Utils.GetMD5String(password)
            };
            AccountManagementState state = Bank.Instance.Add(account);
            if (state == AccountManagementState.Successful)
            {
                MessageBox.Show("Account has been created.");

                Main.Instance.ReloadList();
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Adding was unsuccessful!");
        }
    }
}
