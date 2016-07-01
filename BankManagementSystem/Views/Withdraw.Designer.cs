namespace BankManagementSystem.Views
{
    partial class Withdraw
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
            this.txtPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.btnTake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(12, 25);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(160, 21);
            this.cbAccounts.TabIndex = 6;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(12, 9);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(135, 13);
            this.lblAccounts.TabIndex = 5;
            this.lblAccounts.Text = "Select account to remove :";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(12, 117);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(160, 23);
            this.btnTake.TabIndex = 4;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose the amount :";
            // 
            // nudAmount
            // 
            this.nudAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Location = new System.Drawing.Point(12, 65);
            this.nudAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(160, 20);
            this.nudAmount.TabIndex = 8;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.btnTake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Withdraw_FormClosed);
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PlaceHolderTextBox txtPassword;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}