using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    class DatabaseConnectivity
    {
        static string source = @"C:\Users\Kilia\OneDrive\Desktop\NEA\NEA\Code\NEA Prototype 1\NEADatabase.accdb";
        OleDbConnection DBcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + source); //Inist

        public void SalesCommand()
        {
            try
            {
                OleDbCommand cmd = DBcon.CreateCommand();
                DBcon.Open();
                cmd.CommandText = "INSERT INTO Sales(ProductID,EmployeeID,SaleTime)VALUES('07','15','12/6/05')";
                cmd.Connection = DBcon;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
    }
}
