namespace Lab5
{
    partial class lab5
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextGenerationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.timerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextGenerationButton
            // 
            this.nextGenerationButton.Location = new System.Drawing.Point(103, 42);
            this.nextGenerationButton.Name = "nextGenerationButton";
            this.nextGenerationButton.Size = new System.Drawing.Size(139, 23);
            this.nextGenerationButton.TabIndex = 0;
            this.nextGenerationButton.Text = "Next Generation";
            this.nextGenerationButton.UseVisualStyleBackColor = true;
            this.nextGenerationButton.Click += new System.EventHandler(this.nextGenerationButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(291, 42);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(119, 30);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.startButton);
            this.timerGroupBox.Controls.Add(this.stopButton);
            this.timerGroupBox.Location = new System.Drawing.Point(420, 12);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(200, 53);
            this.timerGroupBox.TabIndex = 4;
            this.timerGroupBox.TabStop = false;
            this.timerGroupBox.Text = "Timer";
            // 
            // lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timerGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nextGenerationButton);
            this.Name = "lab5";
            this.Text = "lab5";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_lab5);
            this.timerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button nextGenerationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox timerGroupBox;
    }
}
