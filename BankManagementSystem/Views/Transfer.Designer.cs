namespace BankManagementSystem.Views
{
    partial class Transfer
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
            this.cbSourceAccount = new System.Windows.Forms.ComboBox();
            this.lblSourceAccount = new System.Windows.Forms.Label();
            this.cbDestinationAccount = new System.Windows.Forms.ComboBox();
            this.lblDestinationAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSourceAccount
            // 
            this.cbSourceAccount.FormattingEnabled = true;
            this.cbSourceAccount.Location = new System.Drawing.Point(12, 25);
            this.cbSourceAccount.Name = "cbSourceAccount";
            this.cbSourceAccount.Size = new System.Drawing.Size(160, 21);
            this.cbSourceAccount.TabIndex = 8;
            // 
            // lblSourceAccount
            // 
            this.lblSourceAccount.AutoSize = true;
            this.lblSourceAccount.Location = new System.Drawing.Point(12, 9);
            this.lblSourceAccount.Name = "lblSourceAccount";
            this.lblSourceAccount.Size = new System.Drawing.Size(120, 13);
            this.lblSourceAccount.TabIndex = 7;
            this.lblSourceAccount.Text = "Select source account :";
            // 
            // cbDestinationAccount
            // 
            this.cbDestinationAccount.FormattingEnabled = true;
            this.cbDestinationAccount.Location = new System.Drawing.Point(12, 91);
            this.cbDestinationAccount.Name = "cbDestinationAccount";
            this.cbDestinationAccount.Size = new System.Drawing.Size(160, 21);
            this.cbDestinationAccount.TabIndex = 10;
            // 
            // lblDestinationAccount
            // 
            this.lblDestinationAccount.AutoSize = true;
            this.lblDestinationAccount.Location = new System.Drawing.Point(12, 75);
            this.lblDestinationAccount.Name = "lblDestinationAccount";
            this.lblDestinationAccount.Size = new System.Drawing.Size(139, 13);
            this.lblDestinationAccount.TabIndex = 9;
            this.lblDestinationAccount.Text = "Select destination account :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose the amount :";
            // 
            // nudAmount
            // 
            this.nudAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Location = new System.Drawing.Point(12, 131);
            this.nudAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(160, 20);
            this.nudAmount.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Password";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 157);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(160, 23);
            this.btnTransfer.TabIndex = 14;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 186);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbDestinationAccount);
            this.Controls.Add(this.lblDestinationAccount);
            this.Controls.Add(this.cbSourceAccount);
            this.Controls.Add(this.lblSourceAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Transfer_FormClosed);
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSourceAccount;
        private System.Windows.Forms.Label lblSourceAccount;
        private System.Windows.Forms.ComboBox cbDestinationAccount;
        private System.Windows.Forms.Label lblDestinationAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private Controls.PlaceHolderTextBox txtPassword;
        private System.Windows.Forms.Button btnTransfer;
    }
}