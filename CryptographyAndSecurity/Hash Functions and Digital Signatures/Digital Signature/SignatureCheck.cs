using System;
using CryptographyAndSecurity.Modern_Ciphers.AsymmetricCipher;
using Lab2;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures.Digital_Signature
{
    public class SignatureCheck
    {
        public void CheckSignature(string hash, string encryption)
        {
            Cipher cipher = new RSA();
            if(cipher.Decrypt(encryption, string.Empty) == hash) 
                Console.WriteLine("Valid");
            else Console.WriteLine("Non Valid");
        }
    }
}