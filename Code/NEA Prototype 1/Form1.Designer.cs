
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
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
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
            this.panelBasket.Size = new System.Drawing.Size(229, 188);
            this.panelBasket.TabIndex = 6;
            // 
            // dgvBasket
            // 
            this.dgvBasket.AllowUserToAddRows = false;
            this.dgvBasket.AllowUserToDeleteRows = false;
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnID,
            this.dgvColumnItem,
            this.dgvColumnPrice,
            this.dgvColumnQuantity,
            this.dgvColumnRemove});
            this.dgvBasket.Location = new System.Drawing.Point(22, 263);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.ReadOnly = true;
            this.dgvBasket.RowHeadersWidth = 51;
            this.dgvBasket.RowTemplate.Height = 29;
            this.dgvBasket.Size = new System.Drawing.Size(776, 277);
            this.dgvBasket.TabIndex = 7;
            this.dgvBasket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasket_CellClicked);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dgvColumnID
            // 
            this.dgvColumnID.HeaderText = "ID";
            this.dgvColumnID.MinimumWidth = 6;
            this.dgvColumnID.Name = "dgvColumnID";
            this.dgvColumnID.ReadOnly = true;
            this.dgvColumnID.Width = 125;
            // 
            // dgvColumnItem
            // 
            this.dgvColumnItem.HeaderText = "Item";
            this.dgvColumnItem.MinimumWidth = 6;
            this.dgvColumnItem.Name = "dgvColumnItem";
            this.dgvColumnItem.ReadOnly = true;
            this.dgvColumnItem.Width = 125;
            // 
            // dgvColumnPrice
            // 
            this.dgvColumnPrice.HeaderText = "Price";
            this.dgvColumnPrice.MinimumWidth = 6;
            this.dgvColumnPrice.Name = "dgvColumnPrice";
            this.dgvColumnPrice.ReadOnly = true;
            this.dgvColumnPrice.Width = 125;
            // 
            // dgvColumnQuantity
            // 
            this.dgvColumnQuantity.HeaderText = "Quantity";
            this.dgvColumnQuantity.MinimumWidth = 6;
            this.dgvColumnQuantity.Name = "dgvColumnQuantity";
            this.dgvColumnQuantity.ReadOnly = true;
            this.dgvColumnQuantity.Width = 125;
            // 
            // dgvColumnRemove
            // 
            this.dgvColumnRemove.HeaderText = "Remove Item";
            this.dgvColumnRemove.MinimumWidth = 6;
            this.dgvColumnRemove.Name = "dgvColumnRemove";
            this.dgvColumnRemove.ReadOnly = true;
            this.dgvColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColumnRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnRemove.Width = 125;
            // 
            // formTill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 600);
            this.Controls.Add(this.dgvBasket);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn dgvColumnRemove;
    }
}

