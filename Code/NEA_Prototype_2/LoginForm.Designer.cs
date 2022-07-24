
namespace NEA_Prototype_1
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.staticlblLoginTitle = new System.Windows.Forms.Label();
            this.staticlblPassword = new System.Windows.Forms.Label();
            this.staticlblUsername = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.linkNoAcc = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(293, 182);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 33);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // staticlblLoginTitle
            // 
            this.staticlblLoginTitle.AutoSize = true;
            this.staticlblLoginTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staticlblLoginTitle.Location = new System.Drawing.Point(281, 53);
            this.staticlblLoginTitle.Name = "staticlblLoginTitle";
            this.staticlblLoginTitle.Size = new System.Drawing.Size(94, 26);
            this.staticlblLoginTitle.TabIndex = 13;
            this.staticlblLoginTitle.Text = "LOGIN";
            this.staticlblLoginTitle.Click += new System.EventHandler(this.lblLoginTitle_Click);
            // 
            // staticlblPassword
            // 
            this.staticlblPassword.AutoSize = true;
            this.staticlblPassword.Location = new System.Drawing.Point(241, 120);
            this.staticlblPassword.Name = "staticlblPassword";
            this.staticlblPassword.Size = new System.Drawing.Size(60, 15);
            this.staticlblPassword.TabIndex = 11;
            this.staticlblPassword.Text = "Password:";
            // 
            // staticlblUsername
            // 
            this.staticlblUsername.AutoSize = true;
            this.staticlblUsername.Location = new System.Drawing.Point(236, 92);
            this.staticlblUsername.Name = "staticlblUsername";
            this.staticlblUsername.Size = new System.Drawing.Size(63, 15);
            this.staticlblUsername.TabIndex = 10;
            this.staticlblUsername.Text = "Username:";
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(310, 117);
            this.tbLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(110, 23);
            this.tbLoginPassword.TabIndex = 9;
            this.tbLoginPassword.UseSystemPasswordChar = true;
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(310, 90);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(110, 23);
            this.tbLoginUsername.TabIndex = 8;
            // 
            // linkNoAcc
            // 
            this.linkNoAcc.AutoSize = true;
            this.linkNoAcc.Location = new System.Drawing.Point(281, 154);
            this.linkNoAcc.Name = "linkNoAcc";
            this.linkNoAcc.Size = new System.Drawing.Size(103, 15);
            this.linkNoAcc.TabIndex = 16;
            this.linkNoAcc.TabStop = true;
            this.linkNoAcc.Text = "Having problems?";
            this.linkNoAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNoAcc_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.linkNoAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.staticlblLoginTitle);
            this.Controls.Add(this.staticlblPassword);
            this.Controls.Add(this.staticlblUsername);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label staticlblLoginTitle;
        private System.Windows.Forms.Label staticlblPassword;
        private System.Windows.Forms.Label staticlblUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.LinkLabel linkNoAcc;
    }
}