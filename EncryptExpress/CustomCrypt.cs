using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncryptExpress
{
    class CustomCrypt
    {
        // The key / password the user enters to encrypt / decrypt the file
        private string key;

        public static bool encryptFile(string fileName)
        {
            byte[] fileBytes = File.ReadAllBytes(fileName);
            StringBuilder sb = new StringBuilder();

            foreach (byte b in fileBytes)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            // byte[] bytes = Encoding.ASCII.GetBytes(someString);
            byte[] bytes = Encoding.ASCII.GetBytes(sb.ToString());
            File.WriteAllBytes("new.png", bytes);
            return false;
        }

        public static bool decryptFile(string fileName)
        {
            byte[] fileBytes = File.ReadAllBytes(fileName);
            StringBuilder sb = new StringBuilder();

            foreach (byte b in fileBytes)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            byte[] bytes = Encoding.ASCII.GetBytes(sb.ToString());
            File.WriteAllBytes(fileName, bytes);
            return false;
        }
    }
}
