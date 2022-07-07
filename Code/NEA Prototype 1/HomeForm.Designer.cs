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
            this.SuspendLayout();
            // 
            // staticlblHome
            // 
            this.staticlblHome.AutoSize = true;
            this.staticlblHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticlblHome.Location = new System.Drawing.Point(344, 9);
            this.staticlblHome.Name = "staticlblHome";
            this.staticlblHome.Size = new System.Drawing.Size(83, 35);
            this.staticlblHome.TabIndex = 0;
            this.staticlblHome.Text = "Home";
            // 
            // btnOpenTill
            // 
            this.btnOpenTill.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTill.Location = new System.Drawing.Point(12, 76);
            this.btnOpenTill.Name = "btnOpenTill";
            this.btnOpenTill.Size = new System.Drawing.Size(228, 60);
            this.btnOpenTill.TabIndex = 1;
            this.btnOpenTill.Text = "Till";
            this.btnOpenTill.UseVisualStyleBackColor = true;
            this.btnOpenTill.Click += new System.EventHandler(this.btnOpenTill_Click);
            // 
            // btnOpenInv
            // 
            this.btnOpenInv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenInv.Location = new System.Drawing.Point(12, 158);
            this.btnOpenInv.Name = "btnOpenInv";
            this.btnOpenInv.Size = new System.Drawing.Size(228, 60);
            this.btnOpenInv.TabIndex = 2;
            this.btnOpenInv.Text = "Inventory";
            this.btnOpenInv.UseVisualStyleBackColor = true;
            this.btnOpenInv.Click += new System.EventHandler(this.btnOpenInv_Click);
            // 
            // btnOpenLogin
            // 
            this.btnOpenLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLogin.Location = new System.Drawing.Point(12, 234);
            this.btnOpenLogin.Name = "btnOpenLogin";
            this.btnOpenLogin.Size = new System.Drawing.Size(228, 60);
            this.btnOpenLogin.TabIndex = 3;
            this.btnOpenLogin.Text = "Login";
            this.btnOpenLogin.UseVisualStyleBackColor = true;
            this.btnOpenLogin.Click += new System.EventHandler(this.btnOpenLogin_Click);
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenSales.Location = new System.Drawing.Point(12, 312);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(228, 60);
            this.btnOpenSales.TabIndex = 4;
            this.btnOpenSales.Text = "Sales";
            this.btnOpenSales.UseVisualStyleBackColor = true;
            this.btnOpenSales.Click += new System.EventHandler(this.btnOpenSales_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenSales);
            this.Controls.Add(this.btnOpenLogin);
            this.Controls.Add(this.btnOpenInv);
            this.Controls.Add(this.btnOpenTill);
            this.Controls.Add(this.staticlblHome);
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
    }
}