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
            DatabaseConnectivity user = new DatabaseConnectivity();
            var (username, password) = user.ReadEmployee(); //Allows me fetch both values as the method returns two values
           
            if (tbLoginUsername.Text == username && tbLoginPassword.Text == password) //Checks to see whether the text inputted is the same as the database
            {
                LoginDetails.LoggedIn = true;
                Form form = new HomeForm();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Your username/password is incorrect\n"+username + password, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblLoginTitle_Click(object sender, EventArgs e)
        {

        }
    }
    public static class LoginDetails //By having a static class, I do not need to instantiate the account object and can therefore access the same class from any part of my program.
                                     //Normally, you would have to insantiate an object to access it, but this overwrites it's values, so any changes aren't permenant
    {
        private static string username;
        private static string password;
        private static bool loggedIn;

        static LoginDetails() //Default details for the account
        {
            username = "a";
            password = "a";
            loggedIn = false;
        }

        public static string Username //Getters and setters to access private variables
        {
            get { return username; }
            set { username = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static bool LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }
    }
}
