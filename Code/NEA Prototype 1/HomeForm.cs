using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
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
            //this.Close();

        }

        private void btnOpenInv_Click(object sender, EventArgs e)
        {
            Form form = new InventoryForm();
            //this.Hide();
            form.Show();
        }

        private void btnOpenTill_Click(object sender, EventArgs e)
        {
            Form form = new formTill();
            this.Hide();
            form.Show();
        }
    }
}
