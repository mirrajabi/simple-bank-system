using BankManagementSystem.Views.Controls;

namespace BankManagementSystem.Views
{
    partial class Add
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
            this.txtConfirmPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtPassword = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtPhoneNumber = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtAddress = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtLastName = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.txtFirstName = new BankManagementSystem.Views.Controls.PlaceHolderTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.IsPassword = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 142);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceHolderText = "Confirm password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(160, 20);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.Text = "Confirm password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.IsPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.IsPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 90);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceHolderText = "Phone number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Text = "Phone number";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.IsPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(12, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceHolderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(160, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.IsPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(12, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceHolderText = "Last name";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.IsPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(12, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceHolderText = "First name";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 197);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add";
            this.Text = "Add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_FormClosed);
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox txtFirstName;
        private PlaceHolderTextBox txtLastName;
        private PlaceHolderTextBox txtAddress;
        private PlaceHolderTextBox txtPhoneNumber;
        private PlaceHolderTextBox txtPassword;
        private PlaceHolderTextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnAdd;
    }
}