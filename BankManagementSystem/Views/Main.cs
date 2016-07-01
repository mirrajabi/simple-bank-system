using BankManagementSystem.Data;
using BankManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace BankManagementSystem.Views
{
    public partial class Main : Form
    {
        public static Main Instance { get; set; }
        public Main()
        {
            Instance = this;
            InitializeComponent();
        }

        #region Methods
        public void ReloadList()
        {
            if (Bank.Instance.Accounts.Count == 0)
                return;
            dgvList.DataSource = null;
            dgvList.DataSource = Bank.Instance.Accounts;
            dgvList.Columns.Remove("PasswordHash");
            dgvList.Update();
            dgvList.Refresh();
        }
        #endregion

        #region UI Controllers
        private void loadRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHandler.Load() == Utility.RecordIOState.Successful)
            {
                MessageBox.Show("Records were successfully loaded from database.");
                ReloadList();
            }
            else
                MessageBox.Show("An Error occured while loading records from database.");
        }

        private void saveRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHandler.Save() == Utility.RecordIOState.Successful)
                MessageBox.Show("Records were successfully saved in database.");
            else
                MessageBox.Show("An Error occured while saving records in database.");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Add().Show();
            Enabled = false;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Modify().Show();
            Enabled = false;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Remove().Show();
            Enabled = false;
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Deposit().Show();
            Enabled = false;
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Withdraw().Show();
            Enabled = false;
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Transfer().Show();
            Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (DbHandler.Load() == Utility.RecordIOState.Successful)
                ReloadList();

            foreach (ToolStripMenuItem menuItem in mainMenuStrip.Items)
                ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
        }
        #endregion
    }
}
