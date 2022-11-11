using System;
using System.IO;
using System.Text;
using CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures;
using CryptographyAndSecurity.Hash_Functions_and_Digital_Signatures.Digital_Signature;
using CryptographyAndSecurity.Modern_Ciphers.AsymmetricCipher;
using Lab2;

namespace CryptographyAndSecurity
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
        
       /* Cipher caesarCipher = new CaesarCipher();
        Console.WriteLine("This is the encryption with Caesar Cipher:");
        Console.WriteLine(caesarCipher.Encrypt("hello", "3")); ;
        Console.WriteLine("This is the decryption with Caesar Cipher:");
        Console.WriteLine(caesarCipher.Decrypt("khoor", "3"));
        
        Cipher caesarCipherPermutation = new CaesarCipherPermutation();
        Console.WriteLine("This is the encryption with Caesar Cipher with permutation:");
        Console.WriteLine(caesarCipherPermutation.Encrypt("hello", "3"));
        Console.WriteLine("Input text for Caesar Decryption with alphabet permutation:");
        Console.WriteLine(caesarCipherPermutation.Decrypt("liqqs","3"));

        Cipher vigenereCipher = new VigenereCipher();
        
        vigenereCipher.Encrypt("PER ASPERA AD ASTRA", "SUPER");
        vigenereCipher.Decrypt("HYGEJHYGERVUHXIS", "SUPER");
        
        Cipher polybiusSquareCipher = new PolybiusSquareCipher();
        polybiusSquareCipher.Encrypt("hello", String.Empty);
        polybiusSquareCipher.Decrypt("osmaumumuc", string.Empty);
        
        String plainText = "123456BCD1325361";
        String key = "AABB09182736CCDD";
        // string text = "12";
        
        Cipher des = new DES();
        Console.WriteLine("This is the encrypted message with DES: "+ des.Encrypt(plainText, key));
        Console.WriteLine("This is the decrypted message with DES: "+ des.Decrypt("02d013d0d5fc027a",key));

        string plain_text_rc4 = "Plaintext";
        string key_rc4 = "Key";
        

        Cipher rc4 = new RC4();
        Console.WriteLine("This is the encryption with RC4: " + rc4.Encrypt(plain_text_rc4, key_rc4));
        Console.WriteLine("This is the decyption with RC4: " + rc4.Decrypt("BBF316E8D940AF0AD3", key_rc4));*/

       /* Cipher rsa = new RSA();
        Console.WriteLine(rsa.Encrypt("car", string.Empty));
        Console.WriteLine(rsa.Decrypt("036013095", string.Empty));*/

       /* ClientPassword clientPassword = new ClientPassword();
        clientPassword.AddClients();
        ConnectionToSql connectToSql = new ConnectionToSql();
        connectToSql.Connect();*/

       DigitalSignatureClient digitalSignatureClient = new DigitalSignatureClient();
       digitalSignatureClient.Execute();



        }
    }
}