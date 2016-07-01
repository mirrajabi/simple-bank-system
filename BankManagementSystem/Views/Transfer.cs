using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            cbSourceAccount.Items.Clear();
            cbDestinationAccount.Items.Clear();
            for (int i = 0; i < Bank.Instance.Accounts.Count; i++)
            {
                cbSourceAccount.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
                cbDestinationAccount.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
            }
            cbSourceAccount.SelectedIndex = 0;
            cbDestinationAccount.SelectedIndex = 0;
            cbSourceAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDestinationAccount.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(cbDestinationAccount.SelectedIndex == cbSourceAccount.SelectedIndex)
            {
                MessageBox.Show("The source and the destination accounts cannot be the same.");
                return;
            }
            decimal amount = nudAmount.Value;
            if (amount <= 0)
            {
                MessageBox.Show("The amount must be at least 1");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter the source account's password.");
                return;
            }
            string passwordHash = Utils.GetMD5String(txtPassword.Text);
            if (passwordHash != Bank.Instance.Accounts[cbSourceAccount.SelectedIndex].PasswordHash)
            {
                MessageBox.Show("Invalid password for source account.");
                return;
            }

            TransactionState state = Bank.Instance.Transfer(Bank.Instance.Accounts[cbSourceAccount.SelectedIndex].Id,
                Bank.Instance.Accounts[cbDestinationAccount.SelectedIndex].Id, amount);
            if (state == TransactionState.Successful)
            {
                MessageBox.Show("Transfer was successfully done.");

                Main.Instance.ReloadList();
                Close();
                Dispose();
            }
            else if(state == TransactionState.NotEnoughCredit)
                MessageBox.Show("Not enough credit in source account!");
            else
                MessageBox.Show("Unsuccessful transaction!");
        }

        private void Transfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
            Main.Instance.ReloadList();
        }
    }
}
