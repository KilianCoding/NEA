namespace NEA_Prototype_1
{
    partial class AccountsForm
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
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblCurrrentPassword = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.Location = new System.Drawing.Point(268, 93);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(134, 20);
            this.lblCurrentUsername.TabIndex = 0;
            this.lblCurrentUsername.Text = "Current Username: ";
            // 
            // lblCurrrentPassword
            // 
            this.lblCurrrentPassword.AutoSize = true;
            this.lblCurrrentPassword.Location = new System.Drawing.Point(273, 135);
            this.lblCurrrentPassword.Name = "lblCurrrentPassword";
            this.lblCurrrentPassword.Size = new System.Drawing.Size(129, 20);
            this.lblCurrrentPassword.TabIndex = 1;
            this.lblCurrrentPassword.Text = "Current Password: ";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(142, 90);
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.PlaceholderText = "Username";
            this.tbNewUsername.Size = new System.Drawing.Size(125, 27);
            this.tbNewUsername.TabIndex = 2;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(142, 132);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PlaceholderText = "Password";
            this.tbNewPassword.Size = new System.Drawing.Size(125, 27);
            this.tbNewPassword.TabIndex = 3;
            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.Location = new System.Drawing.Point(158, 177);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmChange.TabIndex = 4;
            this.btnConfirmChange.Text = "Confirm";
            this.btnConfirmChange.UseVisualStyleBackColor = true;
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmChange);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbNewUsername);
            this.Controls.Add(this.lblCurrrentPassword);
            this.Controls.Add(this.lblCurrentUsername);
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblCurrrentPassword;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button btnConfirmChange;
    }
}