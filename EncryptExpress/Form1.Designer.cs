namespace EncryptExpress
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.settings1 = new EncryptExpress.Settings();
            this.encryptFile1 = new EncryptExpress.EncryptFile();
            this.decryptFile1 = new EncryptExpress.DecryptFile();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnFileDecrypt);
            this.panel1.Controls.Add(this.btnFileEncrypt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 504);
            this.panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::EncryptExpress.Properties.Resources.settings1;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 305);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(166, 53);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFileDecrypt.FlatAppearance.BorderSize = 0;
            this.btnFileDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnFileDecrypt.Image = global::EncryptExpress.Properties.Resources.decryptedFile;
            this.btnFileDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileDecrypt.Location = new System.Drawing.Point(0, 199);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(166, 53);
            this.btnFileDecrypt.TabIndex = 6;
            this.btnFileDecrypt.Text = "Decrypt File";
            this.btnFileDecrypt.UseVisualStyleBackColor = false;
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click);
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.BackColor = System.Drawing.Color.DimGray;
            this.btnFileEncrypt.FlatAppearance.BorderSize = 0;
            this.btnFileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnFileEncrypt.Image = global::EncryptExpress.Properties.Resources.encryptedFile;
            this.btnFileEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileEncrypt.Location = new System.Drawing.Point(0, 146);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(166, 53);
            this.btnFileEncrypt.TabIndex = 5;
            this.btnFileEncrypt.Text = "Encrypt File";
            this.btnFileEncrypt.UseVisualStyleBackColor = false;
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settings1.Location = new System.Drawing.Point(166, 59);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(627, 445);
            this.settings1.TabIndex = 8;
            this.settings1.Visible = false;
            // 
            // encryptFile1
            // 
            this.encryptFile1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.encryptFile1.Location = new System.Drawing.Point(166, 59);
            this.encryptFile1.Name = "encryptFile1";
            this.encryptFile1.Size = new System.Drawing.Size(627, 445);
            this.encryptFile1.TabIndex = 10;
            // 
            // decryptFile1
            // 
            this.decryptFile1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.decryptFile1.Location = new System.Drawing.Point(166, 59);
            this.decryptFile1.Name = "decryptFile1";
            this.decryptFile1.Size = new System.Drawing.Size(627, 445);
            this.decryptFile1.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EncryptExpress.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(736, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 53);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(793, 504);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.encryptFile1);
            this.Controls.Add(this.decryptFile1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptExpress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DecryptFile decryptFile1;
        private EncryptFile encryptFile1;
        private Settings settings1;
    }
}

