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

        private void btnConfirmChange_Click(object sender, EventArgs e) //Reassigns account details
        {
            DatabaseConnectivity DBCon = new DatabaseConnectivity();
            DBCon.NewEmployee();
        }

        private void AccountsForm_Load(object sender, EventArgs e) //Shows the current username and password
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form form = new HomeForm();
            this.Hide();
            form.Show();
        }
    }
}
