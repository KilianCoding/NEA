namespace NEA_Prototype_1
{
    partial class HomeForm
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
            this.staticlblHome = new System.Windows.Forms.Label();
            this.btnOpenTill = new System.Windows.Forms.Button();
            this.btnOpenInv = new System.Windows.Forms.Button();
            this.btnOpenLogin = new System.Windows.Forms.Button();
            this.btnOpenSales = new System.Windows.Forms.Button();
            this.btnOpenAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staticlblHome
            // 
            this.staticlblHome.AutoSize = true;
            this.staticlblHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticlblHome.Location = new System.Drawing.Point(301, 7);
            this.staticlblHome.Name = "staticlblHome";
            this.staticlblHome.Size = new System.Drawing.Size(65, 28);
            this.staticlblHome.TabIndex = 0;
            this.staticlblHome.Text = "Home";
            // 
            // btnOpenTill
            // 
            this.btnOpenTill.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTill.Location = new System.Drawing.Point(10, 57);
            this.btnOpenTill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenTill.Name = "btnOpenTill";
            this.btnOpenTill.Size = new System.Drawing.Size(200, 45);
            this.btnOpenTill.TabIndex = 1;
            this.btnOpenTill.Text = "Till";
            this.btnOpenTill.UseVisualStyleBackColor = true;
            this.btnOpenTill.Click += new System.EventHandler(this.btnOpenTill_Click);
            // 
            // btnOpenInv
            // 
            this.btnOpenInv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenInv.Location = new System.Drawing.Point(10, 118);
            this.btnOpenInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenInv.Name = "btnOpenInv";
            this.btnOpenInv.Size = new System.Drawing.Size(200, 45);
            this.btnOpenInv.TabIndex = 2;
            this.btnOpenInv.Text = "Inventory";
            this.btnOpenInv.UseVisualStyleBackColor = true;
            this.btnOpenInv.Click += new System.EventHandler(this.btnOpenInv_Click);
            // 
            // btnOpenLogin
            // 
            this.btnOpenLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLogin.Location = new System.Drawing.Point(10, 176);
            this.btnOpenLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenLogin.Name = "btnOpenLogin";
            this.btnOpenLogin.Size = new System.Drawing.Size(200, 45);
            this.btnOpenLogin.TabIndex = 3;
            this.btnOpenLogin.Text = "Login";
            this.btnOpenLogin.UseVisualStyleBackColor = true;
            this.btnOpenLogin.Click += new System.EventHandler(this.btnOpenLogin_Click);
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenSales.Location = new System.Drawing.Point(10, 234);
            this.btnOpenSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(200, 45);
            this.btnOpenSales.TabIndex = 4;
            this.btnOpenSales.Text = "Sales";
            this.btnOpenSales.UseVisualStyleBackColor = true;
            this.btnOpenSales.Click += new System.EventHandler(this.btnOpenSales_Click);
            // 
            // btnOpenAccounts
            // 
            this.btnOpenAccounts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenAccounts.Location = new System.Drawing.Point(236, 57);
            this.btnOpenAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenAccounts.Name = "btnOpenAccounts";
            this.btnOpenAccounts.Size = new System.Drawing.Size(200, 45);
            this.btnOpenAccounts.TabIndex = 5;
            this.btnOpenAccounts.Text = "Accounts";
            this.btnOpenAccounts.UseVisualStyleBackColor = true;
            this.btnOpenAccounts.Click += new System.EventHandler(this.btnOpenAccounts_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnOpenAccounts);
            this.Controls.Add(this.btnOpenSales);
            this.Controls.Add(this.btnOpenLogin);
            this.Controls.Add(this.btnOpenInv);
            this.Controls.Add(this.btnOpenTill);
            this.Controls.Add(this.staticlblHome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticlblHome;
        private System.Windows.Forms.Button btnOpenTill;
        private System.Windows.Forms.Button btnOpenInv;
        private System.Windows.Forms.Button btnOpenLogin;
        private System.Windows.Forms.Button btnOpenSales;
        private System.Windows.Forms.Button btnOpenAccounts;
    }
}