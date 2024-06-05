using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

public class AESCipher
{
    private readonly byte[] _key;
    private readonly byte[] _iv;

    public AESCipher(string key)
    {
        // Derive key and IV from the provided key string
        using (var sha256 = SHA256.Create())
        {
            _key = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
        }

        // Generate a random IV and use it for AES encryption/decryption
        _iv = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(_iv);
        }
    }

    public string Encrypt(string plainText)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = _key;
            aes.IV = _iv;

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }

                    var encrypted = ms.ToArray();
                    var result = new byte[_iv.Length + encrypted.Length];
                    Array.Copy(_iv, 0, result, 0, _iv.Length);
                    Array.Copy(encrypted, 0, result, _iv.Length, encrypted.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }
    }

    public string Decrypt(string cipherText)
    {
        var fullCipher = Convert.FromBase64String(cipherText);

        using (var aes = Aes.Create())
        {
            var iv = new byte[16];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Array.Copy(fullCipher, 0, iv, 0, iv.Length);
            Array.Copy(fullCipher, iv.Length, cipher, 0, cipher.Length);

            aes.Key = _key;
            aes.IV = iv;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                using (var ms = new MemoryStream(cipher))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}


