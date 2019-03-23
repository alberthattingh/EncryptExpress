using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptExpress
{
    class CryptAes
    {
        // NOTE: Both the key and IV is necessary for the recipient to have in order to decrypt
        // TODO: Make this vector random for every encryption & decryption
        public static string initializationVector = "my#@Vector123Key"; // 16 chars = 16 bytes

        // TODO: Have user enter their own key when they encrypt or decrypt
        public static string key = "pfheoyqwm630fhjvidnf2nm$gdk&hf9@"; // 32 chars = 32 bytes

        /**
         * Static method that encrypts a plaintext string and returns the encrypted byte array
         */
        public static string Encrypt(string plainText)
        {
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(plainText);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();

            aes.BlockSize = 128;
            aes.KeySize = 256;

            aes.Key = ASCIIEncoding.ASCII.GetBytes(key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(initializationVector);

            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypted = crypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            crypt.Dispose();

            return Convert.ToBase64String(encrypted);
        }

        /**
         * Static method that decrypts an AES encryption and returns the decrypted string
         */
        public static string Decrypt(string encryptedText)
        {
            byte[] textBytes = Convert.FromBase64String(encryptedText);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();

            aes.BlockSize = 128;
            aes.KeySize = 256;

            aes.Key = ASCIIEncoding.ASCII.GetBytes(key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(initializationVector);

            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] decrypted = crypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            crypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(decrypted);
        }
    }
}
