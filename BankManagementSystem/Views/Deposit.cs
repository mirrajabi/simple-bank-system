using BankManagementSystem.Models;
using BankManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            cbAccounts.Items.Clear();
            for (int i = 0; i < Bank.Instance.Accounts.Count; i++)
            {
                cbAccounts.Items.Add(Bank.Instance.Accounts[i].FirstName + " " + Bank.Instance.Accounts[i].LastName);
            }
            cbAccounts.SelectedIndex = 0;
            cbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Deposit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Instance.Enabled = true;
            Main.Instance.ReloadList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal amount = nudAmount.Value;
            TransactionState state = Bank.Instance.Deposit(Bank.Instance.Accounts[cbAccounts.SelectedIndex].Id, amount);
            if(state == TransactionState.Successful)
            {
                MessageBox.Show("Deposition successfully done.");
                Close();
                Dispose();
            }
            else
                MessageBox.Show("Deposition was unsuccessful!");
        }
    }
}
