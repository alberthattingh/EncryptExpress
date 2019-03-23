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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.btnTextDecrypt = new System.Windows.Forms.Button();
            this.btnTextEncrypt = new System.Windows.Forms.Button();
            this.btnEncryptString = new System.Windows.Forms.Button();
            this.btnDecryptString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnFileDecrypt);
            this.panel1.Controls.Add(this.btnFileEncrypt);
            this.panel1.Controls.Add(this.btnTextDecrypt);
            this.panel1.Controls.Add(this.btnTextEncrypt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 504);
            this.panel1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(171, 156);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(283, 87);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(504, 156);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(283, 87);
            this.txtOutput.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EncryptExpress.Properties.Resources.convert;
            this.pictureBox1.Location = new System.Drawing.Point(457, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::EncryptExpress.Properties.Resources.settings1;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 358);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(166, 53);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
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
            this.btnFileDecrypt.Location = new System.Drawing.Point(0, 252);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(166, 53);
            this.btnFileDecrypt.TabIndex = 6;
            this.btnFileDecrypt.Text = "Decrypt File";
            this.btnFileDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFileEncrypt.FlatAppearance.BorderSize = 0;
            this.btnFileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnFileEncrypt.Image = global::EncryptExpress.Properties.Resources.encryptedFile;
            this.btnFileEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileEncrypt.Location = new System.Drawing.Point(0, 199);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(166, 53);
            this.btnFileEncrypt.TabIndex = 5;
            this.btnFileEncrypt.Text = "Encrypt File";
            this.btnFileEncrypt.UseVisualStyleBackColor = false;
            // 
            // btnTextDecrypt
            // 
            this.btnTextDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTextDecrypt.FlatAppearance.BorderSize = 0;
            this.btnTextDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnTextDecrypt.Image = global::EncryptExpress.Properties.Resources.key;
            this.btnTextDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextDecrypt.Location = new System.Drawing.Point(0, 146);
            this.btnTextDecrypt.Name = "btnTextDecrypt";
            this.btnTextDecrypt.Size = new System.Drawing.Size(166, 53);
            this.btnTextDecrypt.TabIndex = 4;
            this.btnTextDecrypt.Text = "Decrypt Text";
            this.btnTextDecrypt.UseVisualStyleBackColor = false;
            this.btnTextDecrypt.Click += new System.EventHandler(this.btnTextDecrypt_Click);
            // 
            // btnTextEncrypt
            // 
            this.btnTextEncrypt.BackColor = System.Drawing.Color.DimGray;
            this.btnTextEncrypt.FlatAppearance.BorderSize = 0;
            this.btnTextEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnTextEncrypt.Image = global::EncryptExpress.Properties.Resources.lock4;
            this.btnTextEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextEncrypt.Location = new System.Drawing.Point(0, 93);
            this.btnTextEncrypt.Name = "btnTextEncrypt";
            this.btnTextEncrypt.Size = new System.Drawing.Size(166, 53);
            this.btnTextEncrypt.TabIndex = 3;
            this.btnTextEncrypt.Text = "Encrypt Text";
            this.btnTextEncrypt.UseVisualStyleBackColor = false;
            this.btnTextEncrypt.Click += new System.EventHandler(this.btnTextEncrypt_Click);
            // 
            // btnEncryptString
            // 
            this.btnEncryptString.BackColor = System.Drawing.Color.DimGray;
            this.btnEncryptString.FlatAppearance.BorderSize = 0;
            this.btnEncryptString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptString.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptString.ForeColor = System.Drawing.Color.White;
            this.btnEncryptString.Image = global::EncryptExpress.Properties.Resources.lock4;
            this.btnEncryptString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryptString.Location = new System.Drawing.Point(398, 268);
            this.btnEncryptString.Name = "btnEncryptString";
            this.btnEncryptString.Size = new System.Drawing.Size(166, 53);
            this.btnEncryptString.TabIndex = 1;
            this.btnEncryptString.Text = "Encrypt Text";
            this.btnEncryptString.UseVisualStyleBackColor = false;
            this.btnEncryptString.Click += new System.EventHandler(this.btnEncryptString_Click);
            // 
            // btnDecryptString
            // 
            this.btnDecryptString.BackColor = System.Drawing.Color.DimGray;
            this.btnDecryptString.FlatAppearance.BorderSize = 0;
            this.btnDecryptString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptString.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptString.ForeColor = System.Drawing.Color.White;
            this.btnDecryptString.Image = global::EncryptExpress.Properties.Resources.key;
            this.btnDecryptString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptString.Location = new System.Drawing.Point(398, 268);
            this.btnDecryptString.Name = "btnDecryptString";
            this.btnDecryptString.Size = new System.Drawing.Size(166, 53);
            this.btnDecryptString.TabIndex = 1;
            this.btnDecryptString.Text = "Decrypt Text";
            this.btnDecryptString.UseVisualStyleBackColor = false;
            this.btnDecryptString.Visible = false;
            this.btnDecryptString.Click += new System.EventHandler(this.btnDecryptString_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Enter text to encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Encrypted text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(793, 504);
            this.Controls.Add(this.btnEncryptString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDecryptString);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptExpress";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnTextDecrypt;
        private System.Windows.Forms.Button btnTextEncrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEncryptString;
        private System.Windows.Forms.Button btnDecryptString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

