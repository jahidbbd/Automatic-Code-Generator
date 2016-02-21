using System;
using System.Data;
using System.Data.SqlClient;

namespace AutomaticCodeGenerator.Class.DAL
{
    /// <summary>
    /// Automatic Code Generator
    /// Developed by: Abdullah Al-Muzahid
    /// </summary>
    /// 
    internal class SQLOperation
    {

        private string ConnectionString;


        public SQLOperation(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

       
        public bool executeQuery(string cmdtxt)
        {
           
            try
            {                
                using (SqlConnection con = new SqlConnection(this.ConnectionString))
                {

                    SqlCommand cmd = new SqlCommand(cmdtxt, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


    }
}
