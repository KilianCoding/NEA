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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDetails temp = new LoginDetails();
            if (tbLoginUsername.Text == temp.Username && tbLoginPassword.Text == temp.Password)
            {
                temp.LoggedIn = true;
                Form form = new HomeForm();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Your username/password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblLoginTitle_Click(object sender, EventArgs e)
        {

        }
    }
    public class LoginDetails
    {
        private string username = "a";
        private string password = "a";
        private bool loggedIn = false;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }
    }
}
