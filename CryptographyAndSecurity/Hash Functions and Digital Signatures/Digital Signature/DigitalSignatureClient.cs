using System;
using CryptographyAndSecurity.Modern_Ciphers.AsymmetricCipher;
using Lab2;

namespace CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures.Digital_Signature
{
    public class DigitalSignatureClient
    {
        public void Execute()
        {
            string message = "Hello FAF-201";
            string hashMessage = SHA256.HashPassword(message);
         

            Cipher cipher = new RSA();
            string encryptedMessage = cipher.Encrypt(hashMessage, string.Empty);
            

            SignatureCheck signatureCheck = new SignatureCheck();
            signatureCheck.CheckSignature(hashMessage, encryptedMessage);

        }
    }
}