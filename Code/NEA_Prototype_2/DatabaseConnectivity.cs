using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    class DatabaseConnectivity
    {
        static string source = @"D:\Github\NEA\Code\NEA_Prototype_2\NEADatabase.accdb";
        OleDbConnection DBcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + source); //Initilises database connection
        

        public void NewSale()
        {
            try
            {
                OleDbCommand cmd = DBcon.CreateCommand(); //Creating instance of a command  
                DBcon.Open();
                cmd.CommandText = "INSERT INTO Sales(ProductID,EmployeeID,SaleTime)VALUES('07','15','12/6/05')"; //SQL command
                cmd.Connection = DBcon; //Connects the command to the database
                cmd.ExecuteNonQuery(); //Runs the SQL command
                MessageBox.Show("Success, sale confirmed");
                DBcon.Close();
            }
            catch (Exception e) //e stores details of an exeptions (errors)
            {
                MessageBox.Show(e.ToString()); //Displays error if one occurs
            }

        }
        public void NewEmployee()
        {
            try
            {
                OleDbCommand writecmd = DBcon.CreateCommand(); //Creating instance of a command  
                DBcon.Open();
                writecmd.CommandText = "INSERT INTO Employees(FirstName,LastName,Username,PasswordHash,AccessLevel)VALUES('Jim','Bob','a','a','3')"; //SQL command
                writecmd.Connection = DBcon; //Connects the command to the database
                writecmd.ExecuteNonQuery(); //Runs the SQL command
                MessageBox.Show("Success, user added");
                DBcon.Close();
            }            
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        
        public string ReadEmployee()
        {
            try
            {
                OleDbCommand readcmd = DBcon.CreateCommand(); //Creating instance of a command  
                DBcon.Open();
                readcmd = new OleDbCommand();
                readcmd.CommandText = "SELECT Username FROM Employees WHERE EmployeeID=1";
                readcmd.Connection = DBcon;

                OleDbDataReader reader = readcmd.ExecuteReader();
                string test = "";
                while (reader.Read()) //While reading
                {
                    test = reader["Username"].ToString(); //Sets the variable to the output of the reader 
                    //Otherwise it will read forever (loop)
                }
                return test;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                DBcon.Close();
            }
        }
    }
}
