using System.Data.SqlClient;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public interface IQuery
    {
        public void Execute(SqlConnection conn);
    }
}