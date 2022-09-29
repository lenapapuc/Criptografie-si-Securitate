using System;
using System.IO;
using System.Text;

namespace CryptographyAndSecurity
{ 
    public class CaesarCipher
    {
        private static int static_key = 3;
        private static Alphabet cases = new Alphabet();
        public static string UppercaseAlphabet = cases.Uppercase();
        public static string LowercaseAlphabet = cases.Lowercase();
       
        public virtual Char GiveMeChar(char message, int _key)

       {
           int newindex = 0;
           if (Char.IsUpper(message))
           {
               newindex = (UppercaseAlphabet.IndexOf(message) + _key) % UppercaseAlphabet.Length;
               message = UppercaseAlphabet[newindex];
           }
           else
           {
               newindex = (LowercaseAlphabet.IndexOf(message) + _key) % UppercaseAlphabet.Length;
               message = LowercaseAlphabet[newindex];
           }

           return message;
       }

       public void CipherEncryption()
       {
           string text = Console.ReadLine();
           string encryptedText = String.Empty;
            
            
           foreach (var character in text)
           {
               if (Char.IsLetter(character))
               {
                   encryptedText += GiveMeChar(character, static_key);
               }
               else encryptedText += character;
           }

           Console.WriteLine("The encrypted text is: " + encryptedText);
       }

       public void CipherDecryption()
       {

           string text = Console.ReadLine();
           string decryptedText = String.Empty;
           
           foreach (var character in text)
           {
               if (Char.IsLetter(character))
               {
                   decryptedText += GiveMeChar(character, 26 - static_key);
               }
               else decryptedText += character;
           }

           Console.WriteLine("The decrypted text is: " + decryptedText);
           
       }


    }
}
