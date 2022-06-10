
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
            this.panelBasket = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // staticlblTillTitle
            // 
            this.staticlblTillTitle.AutoSize = true;
            this.staticlblTillTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticlblTillTitle.Location = new System.Drawing.Point(176, 12);
            this.staticlblTillTitle.Name = "staticlblTillTitle";
            this.staticlblTillTitle.Size = new System.Drawing.Size(46, 35);
            this.staticlblTillTitle.TabIndex = 0;
            this.staticlblTillTitle.Text = "Till";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(143, 200);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(111, 56);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(37, 72);
            this.btnItem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(105, 43);
            this.btnItem1.TabIndex = 2;
            this.btnItem1.Text = "Item 1 ";
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.AddItemToList);
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Location = new System.Drawing.Point(143, 176);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(117, 20);
            this.lblCurrentTotal.TabIndex = 3;
            this.lblCurrentTotal.Text = "Current Total: £0";
            // 
            // btnItem2
            // 
            this.btnItem2.AutoSize = true;
            this.btnItem2.Location = new System.Drawing.Point(149, 72);
            this.btnItem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(105, 43);
            this.btnItem2.TabIndex = 4;
            this.btnItem2.Text = "Item 2";
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.AddItemToList);
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(261, 72);
            this.btnItem3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(105, 43);
            this.btnItem3.TabIndex = 5;
            this.btnItem3.Text = "Item 3";
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.AddItemToList);
            // 
            // panelBasket
            // 
            this.panelBasket.AutoScroll = true;
            this.panelBasket.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panelBasket.Location = new System.Drawing.Point(394, 16);
            this.panelBasket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(229, 400);
            this.panelBasket.TabIndex = 6;
            // 
            // formTill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panelBasket);
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.btnItem1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.staticlblTillTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formTill";
            this.Text = "Till";
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
        private System.Windows.Forms.Panel panelBasket;
    }
}

