using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Clear();
            for (int i = 0; i < Bank.Instance.Accounts.Count; i++)
            {
                cbAccounts.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
            }
            cbAccounts.SelectedIndex = 0;
            cbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter the account's password.");
                return;
            }
            string passwordHash = Utils.GetMD5String(txtPassword.Text);
            if(passwordHash != Bank.Instance.Accounts[cbAccounts.SelectedIndex].PasswordHash)
            {
                MessageBox.Show("Invalid password.");
                return;
            }
            
            AccountManagementState state = Bank.Instance.RemoveAt(cbAccounts.SelectedIndex);
            if (state == AccountManagementState.Successful)
            {
                MessageBox.Show("Account has been removed.");

                Main.Instance.ReloadList();
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Removing was unsuccessful!");
        }

        private void Remove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
            Main.Instance.ReloadList();
        }
    }
}
