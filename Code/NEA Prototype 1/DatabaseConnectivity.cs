using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace NEA_Prototype_1
{
    class DatabaseConnectivity
    {
        OleDbConnection DBCon;
        public void InitialiseDBCon()
        {
            string source = @"C:\Users\Kilia\OneDrive\Desktop\NEA\NEA\Database\NEADatabase.accdb";
            DBCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + source);
        }
        private void formTill_Load(object sender, EventArgs e)
        {
            InitialiseDBCon();
        }
    }
}
