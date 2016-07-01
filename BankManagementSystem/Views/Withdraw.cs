using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Clear();
            for (int i = 0; i < Bank.Instance.Accounts.Count; i++)
            {
                cbAccounts.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
            }
            cbAccounts.SelectedIndex = 0;
            cbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Withdraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
            Main.Instance.ReloadList();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            decimal amount = nudAmount.Value;
            if(amount <= 0)
            {
                MessageBox.Show("The amount must be at least 1");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter the account's password.");
                return;
            }
            string passwordHash = Utils.GetMD5String(txtPassword.Text);
            if (passwordHash != Bank.Instance.Accounts[cbAccounts.SelectedIndex].PasswordHash)
            {
                MessageBox.Show("Invalid password.");
                return;
            }

            TransactionState state = Bank.Instance.Withdraw(Bank.Instance.Accounts[cbAccounts.SelectedIndex].Id,amount);
            if (state == TransactionState.Successful)
            {
                MessageBox.Show("Done! Take your invisible cash. ;)");

                Main.Instance.ReloadList();
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Unsuccessful transaction!");
        }
    }
}
