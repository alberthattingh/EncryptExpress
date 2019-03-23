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
            this.button5 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.btnTextDecrypt = new System.Windows.Forms.Button();
            this.btnTextEncrypt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.button5);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 53);
            this.button5.TabIndex = 1;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = false;
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
            this.btnSettings.TabIndex = 1;
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
            this.btnFileDecrypt.TabIndex = 1;
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
            this.btnFileEncrypt.TabIndex = 1;
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
            this.btnTextDecrypt.TabIndex = 1;
            this.btnTextDecrypt.Text = "Decrypt Text";
            this.btnTextDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnTextEncrypt
            // 
            this.btnTextEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTextEncrypt.FlatAppearance.BorderSize = 0;
            this.btnTextEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnTextEncrypt.Image = global::EncryptExpress.Properties.Resources.lock4;
            this.btnTextEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextEncrypt.Location = new System.Drawing.Point(0, 93);
            this.btnTextEncrypt.Name = "btnTextEncrypt";
            this.btnTextEncrypt.Size = new System.Drawing.Size(166, 53);
            this.btnTextEncrypt.TabIndex = 1;
            this.btnTextEncrypt.Text = "Encrypt Text";
            this.btnTextEncrypt.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EncryptExpress.Properties.Resources.quit;
            this.btnExit.Location = new System.Drawing.Point(728, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "EncryptExpress";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnTextDecrypt;
        private System.Windows.Forms.Button btnTextEncrypt;
        private System.Windows.Forms.Button btnExit;
    }
}

