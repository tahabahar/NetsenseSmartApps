using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    ///  
    /// Usage
    /*string key = "yourSecretKey"; // Replace with your secret key
    string plainText = "Hello, world!";

    string encryptedText = AESHelper.Encrypt(plainText, key);
    Console.WriteLine("Encrypted: " + encryptedText);

            string decryptedText = AESHelper.Decrypt(encryptedText, key);
    Console.WriteLine("Decrypted: " + decryptedText);
    */
    /// </summary>
    public class AESHelper
    {
        private static byte[] GenerateRandomKey(int keySize)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = keySize;
                aes.GenerateKey();
                return aes.Key;
            }
        }

        private static byte[] GenerateRandomIV()
        {
            using (var aes = Aes.Create())
            {
                aes.GenerateIV();
                return aes.IV;
            }
        }

        public static string Encrypt(string plainText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = GenerateRandomIV();

            using (var aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return Convert.ToBase64String(ivBytes.Concat(msEncrypt.ToArray()).ToArray());
                }
            }
        }

        public static string Decrypt(string encryptedText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Convert.FromBase64String(encryptedText).Take(16).ToArray();
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText).Skip(16).ToArray();

            using (var aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var msDecrypt = new MemoryStream(encryptedBytes))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }

    
       
           

}
