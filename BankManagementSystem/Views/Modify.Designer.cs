namespace BankManagementSystem.Views
{
    partial class Modify
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
            this.btnApply = new System.Windows.Forms.Button();
            this.txtConfirmNewPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtPhoneNumber = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtAddress = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtLastName = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtFirstName = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.txtNewPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 221);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(160, 23);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmNewPassword.IsPassword = true;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(12, 169);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PlaceHolderText = "Confirm new password";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(160, 20);
            this.txtConfirmNewPassword.TabIndex = 12;
            this.txtConfirmNewPassword.Text = "Confirm new password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Current password";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Current password";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.IsPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 117);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceHolderText = "Phone number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.Text = "Phone number";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.IsPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(12, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(160, 20);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.IsPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(12, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceHolderText = "Last name";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.IsPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(12, 39);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceHolderText = "First name";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.Text = "First name";
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(12, 12);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(160, 21);
            this.cbAccounts.TabIndex = 14;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPassword.IsPassword = true;
            this.txtNewPassword.Location = new System.Drawing.Point(12, 143);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceHolderText = "New password";
            this.txtNewPassword.Size = new System.Drawing.Size(160, 20);
            this.txtNewPassword.TabIndex = 15;
            this.txtNewPassword.Text = "New password";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 257);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Modify";
            this.Text = "Modify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Modify_FormClosed);
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private Controls.PlaceHolderTextBox txtConfirmNewPassword;
        private Controls.PlaceHolderTextBox txtPassword;
        private Controls.PlaceHolderTextBox txtPhoneNumber;
        private Controls.PlaceHolderTextBox txtAddress;
        private Controls.PlaceHolderTextBox txtLastName;
        private Controls.PlaceHolderTextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbAccounts;
        private Controls.PlaceHolderTextBox txtNewPassword;
    }
}