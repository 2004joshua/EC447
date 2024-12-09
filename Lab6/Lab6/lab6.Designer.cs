namespace Lab6
{
    partial class lab6
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

        private void InitializeComponent()
        {
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(82, 83);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(614, 29);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(77, 161);
            this.labelKey.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(53, 25);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Key:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(266, 238);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(138, 42);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "All Files|*.*|Encrypted Files|*.des";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(772, 83);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(138, 42); // Adjust to match Encrypt/Decrypt buttons
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse"; // Add text to make it consistent
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Standard; // Make it similar in style
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(82, 190);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(318, 29);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(82, 238);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(138, 42);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(77, 52);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(98, 25);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "Filename:";
            // 
            // lab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 393);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxFileName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "lab6";
            this.Text = "Encryption/Decryption Tool by Joshua Arrevillaga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelFileName;
    }
}
