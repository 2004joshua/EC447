using System.Windows.Forms; 

namespace Lab_2
{
    partial class Lab_2
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new Button();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Joshua Arrevillaga - Lab 2";

            // Button Configuration
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.Text = "Align";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);

            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion
    }
}

