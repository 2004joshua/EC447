using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
            // Set form properties
            this.Text = "Sine Wave Plot - Joshua Arrevillaga";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(500, 500);  // Set the form size
            this.Resize += new EventHandler(Lab3_Resize);  // Handle resize events
        }

        private void Lab3_Resize(object sender, EventArgs e)
        {
            this.Invalidate();  // Redraw the form when resized
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Calculate scaling factors to fit the 800x400 logical space
            float scaleX = ClientSize.Width / 800f;
            float scaleY = ClientSize.Height / 400f;
            float scale = Math.Min(scaleX, scaleY);

            // Calculate offsets to center the drawing area
            float offsetX = (ClientSize.Width - 800 * scale) / 2f;
            float offsetY = (ClientSize.Height - 400 * scale) / 2f;

            var state = g.Save();  // Save the graphics state

            // Apply transformations for scaling and centering
            g.TranslateTransform(offsetX, offsetY);
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(400, 200);  // Center the origin

            // Draw the axes (400 units each way)
            g.DrawLine(Pens.Black, -400, 0, 400, 0);  // X-axis
            g.DrawLine(Pens.Black, 0, -200, 0, 200);  // Y-axis

            // Draw the sine wave with two complete cycles
            DrawSineWave(g);

            g.Restore(state);  // Restore the original graphics state
        }

        private void DrawSineWave(Graphics g)
        {
            // Plot one point per degree for two cycles (0 to 720 degrees)
            for (int i = 0; i <= 720; i++)
            {
                double radians = i * Math.PI / 180;  // Convert degrees to radians
                double ysin = 100 * Math.Sin(radians);  // Amplitude of 100 (peak-to-peak 200)

                float x = i - 360;  // Shift x to center the wave
                float y = (float)(-ysin);  // Invert y for correct orientation

                // Draw a small 2x2 point for each degree
                g.FillEllipse(Brushes.Black, x - 1, y - 1, 2, 2);
            }
        }
    }
}
