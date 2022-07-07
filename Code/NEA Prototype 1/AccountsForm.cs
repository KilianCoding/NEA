using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            LoginDetails temp = new LoginDetails();
            temp.Username == tbNewUsername.Text;
        }
    }
}
