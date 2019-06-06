namespace Sales_Management
{
    partial class FrmRegister
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRegiser = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(84, 89);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(110, 25);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(274, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(454, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // btnRegiser
            // 
            this.btnRegiser.Location = new System.Drawing.Point(568, 498);
            this.btnRegiser.Name = "btnRegiser";
            this.btnRegiser.Size = new System.Drawing.Size(160, 52);
            this.btnRegiser.TabIndex = 7;
            this.btnRegiser.Text = "Register";
            this.btnRegiser.UseVisualStyleBackColor = true;
            this.btnRegiser.Click += new System.EventHandler(this.btnRegister_Clicked);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(84, 154);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(106, 25);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(274, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(454, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(84, 221);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 25);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(84, 286);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(106, 25);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "Full name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(274, 283);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(454, 31);
            this.txtFullname.TabIndex = 4;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(84, 355);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(74, 25);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(84, 420);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(91, 25);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(274, 352);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(454, 31);
            this.txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(274, 417);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(454, 31);
            this.txtAddress.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(274, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 52);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Clicked);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 607);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegiser);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRegiser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnClear;
    }
}