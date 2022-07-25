using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    class DatabaseConnectivity
    {
        static string source = @"D:\Github\NEA\Code\NEA_Prototype_2\NEADatabase.accdb"; //Location of the databse, seperate from next line so can be easily changed between computers
        OleDbConnection DBcon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + source); //Initilises database connection
        

        public void NewSale()
        {
            try
            {
                OleDbCommand cmd = DBcon.CreateCommand(); //Creating instance of a command  
                DBcon.Open(); //Opens connection
                cmd.CommandText = "INSERT INTO Sales(ProductID,EmployeeID,SaleTime)VALUES('07','15','12/6/05')"; //SQL command
                cmd.Connection = DBcon; //Connects the command to the database
                cmd.ExecuteNonQuery(); //Executes the SQL query
                MessageBox.Show("Success, sale confirmed");
            }
            catch (Exception e) //e stores details of an exeptions (errors)
            {
                MessageBox.Show(e.ToString()); //Displays error if one occurs
            }
            finally {DBcon.Close();} //Either way, the connection is closed

        }
        public void NewEmployee()
        {
            try
            {
                OleDbCommand writecmd = DBcon.CreateCommand();
                DBcon.Open();
                writecmd.CommandText = "INSERT INTO Employees(FirstName,LastName,Username,PasswordHash,AccessLevel)VALUES('Jim','Bob','a','a','3')";
                writecmd.Connection = DBcon;
                writecmd.ExecuteNonQuery();
                MessageBox.Show("Success, user added");
            }
            catch (Exception e) {MessageBox.Show(e.ToString());}
            finally {DBcon.Close();}
        }

        public (string, string) ReadEmployee() //Allows me to return both username and password hash 
        {
            try
            {
                OleDbCommand readcmd = DBcon.CreateCommand(); //Creating instance of a command  
                DBcon.Open();
                readcmd.CommandText = "SELECT Username,PasswordHash FROM Employees WHERE EmployeeID=1"; //1 is not in ' ' becuase it isn't a string
                readcmd.Connection = DBcon;

                OleDbDataReader reader = readcmd.ExecuteReader(); //Executes a read SQL query
                string username = "";
                string password = "";
                while (reader.Read()) //While reading
                {
                    username = reader["Username"].ToString(); //Sets the variable to the output of the reader 
                    password = reader["PasswordHash"].ToString();
                }
                return (username, password);

            }
            catch (Exception e) {MessageBox.Show(e.ToString()); return (null, null);}
            finally{DBcon.Close();}
        }
    }
}
