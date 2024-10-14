using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Lab_2 : Form
    {
        private ArrayList coordinates = new ArrayList();
        private ArrayList grid = new ArrayList();
        private bool _IsOn;

        public Lab_2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private int Gridround(int point)
        {
            int x = point % 40;
            return (x < 20) ? point - x : point + (40 - x);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point original = new Point(e.X, e.Y);
                Point aligned = new Point(Gridround(e.X), Gridround(e.Y));
                coordinates.Add(original);
                grid.Add(aligned);
                Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                coordinates.Clear();
                grid.Clear();
                Invalidate();
            }
        }

        public bool IsOn
        {
            get => _IsOn;
            set
            {
                _IsOn = value;
                button1.Text = _IsOn ? "Original" : "Align";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsOn = !IsOn;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Pixel;

            // Draw Grid
            int GRID = 40;
            for (int x = GRID; x < ClientRectangle.Width; x += GRID)
                g.DrawLine(Pens.Black, x, 0, x, ClientRectangle.Height);
            for (int y = GRID; y < ClientRectangle.Height; y += GRID)
                g.DrawLine(Pens.Black, 0, y, ClientRectangle.Width, y);

            // Draw Circles
            ArrayList activeList = _IsOn ? grid : coordinates;
            foreach (Point p in activeList)
            {
                g.FillEllipse(Brushes.Red, p.X - 10, p.Y - 10, 20, 20);
            }
        }
    }
}
