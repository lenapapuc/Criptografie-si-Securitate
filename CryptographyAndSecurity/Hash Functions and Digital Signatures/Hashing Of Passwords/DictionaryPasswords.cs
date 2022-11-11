using System.Collections.Generic;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public class DictionaryPasswords
    {
        public static Dictionary<string, string> Passwords = new Dictionary<string, string>();

        public void FillDictionary(string login, string password)
        {
            Passwords.Add(login,SHA256.HashPassword(password));
        }
    }
}