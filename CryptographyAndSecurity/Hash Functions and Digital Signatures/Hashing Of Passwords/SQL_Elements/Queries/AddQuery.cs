using System;
using System.Data.SqlClient;
using System.Text;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public class AddQuery : IQuery
    {
        public void Execute(SqlConnection conn)
        {
            foreach (var element in DictionaryPasswords.Passwords)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("INSERT INTO login_passwords (login, password) VALUES ");
                strBuilder.Append($"(N'{element.Key}', N'{SHA256.HashPassword(element.Value)}')");
               
                Console.WriteLine(strBuilder);
                string sqlQuery = strBuilder.ToString();
                using (SqlCommand command = new SqlCommand(sqlQuery, conn)) 
                {
                    command.ExecuteNonQuery(); 
                    Console.WriteLine("Query Executed.");
                }
                strBuilder.Clear();
            }
        }
    }
}