using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptExpress
{
    public partial class Form1 : Form
    {
        private const string defaultPassword = "secret";
        private byte[] password;
        private string customPassword = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Method to hash and set a custom password
        private void setPassword(string pw)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pw));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                customPassword = sb.ToString();
                password = Encoding.ASCII.GetBytes(customPassword);
            }
        }

        // Hide all controls
        private void hideAllControls()
        {
            encryptFile1.Visible = false;
            decryptFile1.Visible = false;
            settings1.Visible = false;

            btnFileEncrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnFileDecrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);
        }

        // Button to open section that allows user to encrypt files
        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            hideAllControls();
            btnFileEncrypt.BackColor = Color.DimGray;
            encryptFile1.Visible = true;
        }

        private void btnFileDecrypt_Click(object sender, EventArgs e)
        {
            hideAllControls();
            btnFileDecrypt.BackColor = Color.DimGray;
            decryptFile1.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            hideAllControls();
            btnSettings.BackColor = Color.DimGray;
            settings1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password = Encoding.ASCII.GetBytes(defaultPassword);
        }

    
    }
}
