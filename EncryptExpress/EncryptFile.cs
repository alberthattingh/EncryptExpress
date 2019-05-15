using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EncryptExpress
{
    public partial class EncryptFile : UserControl
    {
        private const string defaultPassword = "secret";
        private string passwordHash;
        private byte[] password;
        private string customPassword = null;

        public EncryptFile()
        {
            InitializeComponent();
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

                passwordHash = sb.ToString();
                password = hash;
            }
        }

        // Actually encrypt a file
        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                setPassword(defaultPassword);
            }
            else
            {
                while (txtPassword.Text == "" || txtPassword.Text == " ")
                {
                    MessageBox.Show("Invalid password! Please enter a valid password or tick the checkbox.");
                }

                customPassword = txtPassword.Text;
                setPassword(customPassword);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                if (CryptAes.AESEncryptFile(filename, password, true))
                    MessageBox.Show("The file was successfully encrypted.");
                else
                    MessageBox.Show("An error occured while trying to encrypt the file.");

                //this.Visible = false;
            }
        }

        private void EncryptFile_Load(object sender, EventArgs e)
        {
            password = Encoding.ASCII.GetBytes(defaultPassword);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblPassword.Visible = false;
                txtPassword.Clear();
                txtPassword.Visible = false;
                customPassword = null;
            }
            else
            {
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                // customPassword = txtPassword.Text;
            }
        }
    }
}
