using System.Linq;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures
{
    public class ClientPassword
    {
        public void AddClients()
        {
            string login1 = "geronimo";
            string password1 = "what2345";
            string login2 = "badboy1";
            string password2 = "lockedsystem!@34NOentrance";
            
            DictionaryPasswords dictionaryPasswords = new DictionaryPasswords();
            if(!DictionaryPasswords.Passwords.ContainsKey(login1))
            dictionaryPasswords.FillDictionary(login1, password1);
            if(!DictionaryPasswords.Passwords.ContainsKey(login2))
            dictionaryPasswords.FillDictionary(login2, password2);
        }
    }
}