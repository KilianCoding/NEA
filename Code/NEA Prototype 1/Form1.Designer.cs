
namespace NEA_Prototype_1
{
    partial class formTill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.staticlblTillTitle = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staticlblTillTitle
            // 
            this.staticlblTillTitle.AutoSize = true;
            this.staticlblTillTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticlblTillTitle.Location = new System.Drawing.Point(154, 9);
            this.staticlblTillTitle.Name = "staticlblTillTitle";
            this.staticlblTillTitle.Size = new System.Drawing.Size(37, 28);
            this.staticlblTillTitle.TabIndex = 0;
            this.staticlblTillTitle.Text = "Till";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(125, 150);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(97, 42);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(32, 54);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(92, 32);
            this.btnItem1.TabIndex = 2;
            this.btnItem1.Text = "Item 1 ";
            this.btnItem1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Location = new System.Drawing.Point(125, 132);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(93, 15);
            this.lblCurrentTotal.TabIndex = 3;
            this.lblCurrentTotal.Text = "Current Total: £0";
            // 
            // btnItem2
            // 
            this.btnItem2.Location = new System.Drawing.Point(130, 54);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(92, 32);
            this.btnItem2.TabIndex = 4;
            this.btnItem2.Text = "Item 2";
            this.btnItem2.UseVisualStyleBackColor = true;
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(228, 54);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(92, 32);
            this.btnItem3.TabIndex = 5;
            this.btnItem3.Text = "Item 3";
            this.btnItem3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(588, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 429);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // formTill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.btnItem1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.staticlblTillTitle);
            this.Name = "formTill";
            this.Text = "Till";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticlblTillTitle;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.Button btnItem3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

