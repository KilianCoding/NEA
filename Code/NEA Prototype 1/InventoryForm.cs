using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();         
        }
    }
}
