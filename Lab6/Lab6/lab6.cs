using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Lab6
{
    public partial class lab6 : Form
    {
        public string filename = "";
        public string keyString;
        public byte[] key = new byte[8];
        public short keyIndex = 0;
        public int keyLength = 0;

        public lab6()
        {
            InitializeComponent();
        }

        // Triggered when the text in the file name text box changes
        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            filename = textBoxFileName.Text;
            Console.WriteLine("Filename: {0}", filename);
            bool isEncryptedFile = CheckFileExtension();
        }

        // Triggered when the key text box value changes
        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            keyString = textBoxKey.Text;
            Console.WriteLine("Key string: {0}", keyString);
            ProcessEncryptionKey();
        }

        // Opens file dialog to browse and select a file
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = fileDialog.FileName;
                filename = fileDialog.FileName;
            }
        }

        // Encrypts the selected file
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            EncryptFile();
        }

        // Decrypts the selected file
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            DecryptFile();
        }

        private void ProcessEncryptionKey()
        {
            // Process the key string and store it in the key array
            for (int i = 0; i < 8; i++)
            {
                key[i] = 0;
            }

            int index = 0;
            foreach (byte b in keyString)
            {
                key[index] += b;
                index = (index + 1) & 7;
            }

            Console.Write("Processed key: ");
            foreach (byte b in key)
            {
                Console.Write("{0}, ", b);
            }
            Console.WriteLine();
        }

        private bool CheckFileExtension()
        {
            string[] split = filename.Split('.');
            string extension = split[split.Length - 1];
            Console.WriteLine("File extension: {0}", extension);

            return extension == "des";
        }

        private bool IsKeyEmpty()
        {
            // Checks if the encryption key is valid
            foreach (byte b in key)
            {
                if (b != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void EncryptFile()
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Please select a file to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(keyString))
            {
                MessageBox.Show("Please enter a valid encryption key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputFilename = filename + ".enc";

            if (File.Exists(outputFilename))
            {
                DialogResult result = MessageBox.Show("Output file exists. Overwrite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                using (FileStream fin = new FileStream(filename, FileMode.Open, FileAccess.Read))
                using (FileStream fout = new FileStream(outputFilename, FileMode.Create, FileAccess.Write))
                {
                    int rbyte;
                    int pos = 0;
                    int length = keyString.Length;
                    byte kbyte, ebyte;

                    while ((rbyte = fin.ReadByte()) != -1)
                    {
                        kbyte = (byte)keyString[pos];
                        ebyte = (byte)(rbyte ^ kbyte);
                        fout.WriteByte(ebyte);
                        pos = (pos + 1) % length;
                    }
                }

                MessageBox.Show("File encrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DecryptFile()
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Please select a file to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(keyString))
            {
                MessageBox.Show("Please enter a valid decryption key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!filename.EndsWith(".enc"))
            {
                MessageBox.Show("Please select a .enc file to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputFilename = filename.Substring(0, filename.Length - 4);

            if (File.Exists(outputFilename))
            {
                DialogResult result = MessageBox.Show("Output file exists. Overwrite?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                using (FileStream fin = new FileStream(filename, FileMode.Open, FileAccess.Read))
                using (FileStream fout = new FileStream(outputFilename, FileMode.Create, FileAccess.Write))
                {
                    int rbyte;
                    int pos = 0;
                    int length = keyString.Length;
                    byte kbyte, dbyte;

                    while ((rbyte = fin.ReadByte()) != -1)
                    {
                        kbyte = (byte)keyString[pos];
                        dbyte = (byte)(rbyte ^ kbyte);
                        fout.WriteByte(dbyte);
                        pos = (pos + 1) % length;
                    }
                }

                MessageBox.Show("File decrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
