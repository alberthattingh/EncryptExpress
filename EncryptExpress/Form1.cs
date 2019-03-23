using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void hideAllControls()
        {
            label1.Visible = false;
            label2.Visible = false;

            txtInput.Clear();
            txtOutput.Clear();

            btnTextEncrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnTextDecrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnFileEncrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnFileDecrypt.BackColor = Color.FromArgb(64, 64, 64);
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);

            txtInput.Visible = false;
            txtOutput.Visible = false;
            pictureBox1.Visible = false;
            btnEncryptString.Visible = false;
            btnDecryptString.Visible = false;
        }

        private void btnTextEncrypt_Click(object sender, EventArgs e)
        {
            hideAllControls();
            btnTextEncrypt.BackColor = Color.DimGray;

            txtInput.Visible = true;
            txtInput.Focus();
            txtOutput.Visible = true;
            pictureBox1.Visible = true;
            btnEncryptString.Visible = true;

            label1.Text = "Enter text to encrypt:";
            label2.Text = "Encrypted text:";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void btnEncryptString_Click(object sender, EventArgs e)
        {
            try
            { 
                string encrypted = CryptAes.Encrypt(txtInput.Text);
                txtOutput.Text = encrypted;
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured while encrypting the text. Please make sure you typed something in the textbox.");
                txtOutput.Focus();
            }
        }

        private void btnTextDecrypt_Click(object sender, EventArgs e)
        {
            hideAllControls();
            btnTextDecrypt.BackColor = Color.DimGray;

            txtInput.Visible = true;
            txtInput.Focus();
            txtOutput.Visible = true;
            pictureBox1.Visible = true;
            btnDecryptString.Visible = true;

            label1.Text = "Enter encrypted text to decrypt:";
            label2.Text = "Decrypted text:";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void btnDecryptString_Click(object sender, EventArgs e)
        {
            try
            {
                string decrypted = CryptAes.Decrypt(txtInput.Text);
                txtOutput.Text = decrypted;
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured while decrypting the text. Please make sure you typed something in the textbox.");
                txtInput.Focus();
            }
        }
    }
}
