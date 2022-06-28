using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkNoAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Only existing accounts with level 2 access or higher can create/modify accounts.\nIf you need an account" +
                " or have forgotten your login details, speak with a manager.","No Account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
