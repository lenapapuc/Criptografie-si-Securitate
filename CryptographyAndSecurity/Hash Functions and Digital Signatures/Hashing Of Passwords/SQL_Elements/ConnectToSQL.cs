using System;
using System.Data.SqlClient;
using System.Text;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public class ConnectionToSql
    {
        public void Connect()
        {
            var datasource = @"DESKTOP-C7P2UM3"; 
            var database = "Passwords";
            var username = "ElenaP"; 
            var password = "password"; 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" +
                                password;

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                IQuery query = new AddQuery();
                query.Execute(conn);
                
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}