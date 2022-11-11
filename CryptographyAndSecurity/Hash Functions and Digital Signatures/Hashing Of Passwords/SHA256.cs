using System;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using EasyEncryption;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public class SHA256
    {
        public static string HashPassword(string input)
        {
            return SHA.ComputeSHA256Hash(input);
        }
    }
}