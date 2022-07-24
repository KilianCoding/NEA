using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    //All this form does is link to other forms, when a button is pressed, it's corresponding form is opened and this form is closed 
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnOpenInv_Click(object sender, EventArgs e)
        {
            Form form = new InventoryForm();
            form.Show();
            this.Close();
        }

        private void btnOpenTill_Click(object sender, EventArgs e)
        {
            Form form = new formTill();
            form.Show();
            this.Close();
        }

        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            Form form = new SalesForm();
            form.Show();
            this.Close();
        }

        private void btnOpenAccounts_Click(object sender, EventArgs e)
        {
            Form form = new AccountsForm();
            form.Show();
            this.Close();
        }
    }
}
