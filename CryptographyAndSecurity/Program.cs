using System;
using System.IO;

namespace CryptographyAndSecurity
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
        
        /*CaesarCipher caesarCipher = new CaesarCipher();
        Console.WriteLine("Input text for Caesar Encryption:");
        caesarCipher.CipherEncryption();
        Console.WriteLine("Input text for Caesar Decryption:");
        caesarCipher.CipherDecryption();
        
        CaesarCipherPermutation caesarCipherPermutation = new CaesarCipherPermutation();
        Console.WriteLine("Input text for Caesar Encryption with alphabet permutation:");
        caesarCipherPermutation.CipherEncryption();
        Console.WriteLine("Input text for Caesar Decryption with alphabet permutation:");
        caesarCipherPermutation.CipherDecryption();*/

       /* VigenereCipher vigenereCipher = new VigenereCipher();
        Console.WriteLine("Input your uppercase text for encryption with Vigenere Cipher:");
        vigenereCipher.Encrypt();
        Console.WriteLine("Input your uppercase encrypted text for decryption with Vigenere Cipher: ");
        vigenereCipher.Decrypt();*/
        PolybiusSquareCipher polybiusSquareCipher = new PolybiusSquareCipher();
        //polybiusSquareCipher.PolybiusEncrypt();
        polybiusSquareCipher.PolybiusDecrypt();



        }
    }
}