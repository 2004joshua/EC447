namespace Lab4
{
    partial class lab4
    {
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startingIntegerLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.startingIntegerLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 20F , System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Reduced font size
            this.titleLabel.Location = new System.Drawing.Point(220, 20);
            this.titleLabel.Text = "Find Numeric Palindromes";
            this.Controls.Add(this.titleLabel);

            // startingIntegerLabel
            this.startingIntegerLabel.AutoSize = true;
            this.startingIntegerLabel.Font = new System.Drawing.Font("Arial", 8F); // Reduced font size
            this.startingIntegerLabel.Location = new System.Drawing.Point(80, 80); // Moved left
            this.startingIntegerLabel.Text = "Enter a starting integer (0-1,000,000,000):";
            this.Controls.Add(this.startingIntegerLabel);

            // textBox1 (Starting integer input)
            this.textBox1.Location = new System.Drawing.Point(320, 78); // Moved left
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.textBox1);

            // countLabel
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Arial", 8F); // Reduced font size
            this.countLabel.Location = new System.Drawing.Point(440, 80); // Moved left
            this.countLabel.Text = "Enter count (1-100):";
            this.Controls.Add(this.countLabel);

            // textBox2 (Count input)
            this.textBox2.Location = new System.Drawing.Point(580, 78); // Moved left
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.Controls.Add(this.textBox2);

            // button1 (Generate button)
            this.button1.Location = new System.Drawing.Point(300, 120);
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Font = new System.Drawing.Font("Arial", 8F); // Reduced font size
            this.button1.Text = "Generate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);

            // listBox1 (Display palindromes)
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(250, 170);
            this.listBox1.Size = new System.Drawing.Size(250, 160);
            this.Controls.Add(this.listBox1);

            // lab4 Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Palindromes by Joshua Arrevillaga";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


