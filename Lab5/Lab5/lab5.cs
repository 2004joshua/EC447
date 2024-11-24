using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab5
{
    public partial class lab5 : Form
    {
        private int cellHeight = 20;
        private int cellWidth = 20;
        private int gridColumns = 50;
        private int gridRows = 25;
        private Grid gridState;

        public lab5()
        {
            InitializeComponent();
            ResizeRedraw = true;
            gridState = new Grid(gridColumns, gridRows);
            this.Text = "Game of Life By Joshua Arrevillaga";
            this.Size = new System.Drawing.Size(cellWidth * gridColumns + 50, cellHeight * gridRows + 125);
            stopButton.Enabled = false;
        }

        private void nextGenerationButton_Click(object sender, EventArgs e)
        {
            Grid nextGridState = new Grid(gridColumns, gridRows);
            gridState.Generate(nextGridState);
            gridState = nextGridState;
            Invalidate();
        }

        private void MouseDown_lab5(object sender, MouseEventArgs e)
        {
            bool isCellActive = false;
            if (e.Button == MouseButtons.Left)
            {
                isCellActive = true;
            }
            ToggleCellState(e.X, e.Y, isCellActive);
        }

        private void ToggleCellState(int mouseX, int mouseY, bool isActive)
        {
            int column = 0;
            int row = 0;
            bool isValidCell = false;
            Graphics graphics = CreateGraphics();
            ApplyTransform(graphics);
            PointF[] points = { new Point(mouseX, mouseY) };
            graphics.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, points);
            column = (int)points[0].X / cellWidth;
            row = (int)points[0].Y / cellHeight;
            if (points[0].X < 0 || points[0].Y < 0)
            {
                isValidCell = false;
            }
            else if (column >= gridColumns || row >= gridRows)
            {
                isValidCell = false;
            }
            else
            {
                isValidCell = true;
            }
            if (isValidCell)
            {
                gridState[column, row] = isActive;
                GetCellPosition(column, row, out var worldX, out var worldY);
                Invalidate(new Rectangle(worldX, worldY, (int)Math.Ceiling(cellWidth * 1f), (int)Math.Ceiling(cellHeight * 1f)));
            }
        }

        private void GetCellPosition(int column, int row, out int worldX, out int worldY)
        {
            Graphics graphics = CreateGraphics();
            ApplyTransform(graphics);
            column *= cellWidth;
            row *= cellHeight;
            PointF[] points = { new Point(column, row) };

            graphics.TransformPoints(CoordinateSpace.Device, CoordinateSpace.World, points);
            worldX = (int)points[0].X;
            worldY = (int)points[0].Y;
        }

        private void ApplyTransform(Graphics g)
        {
            g.TranslateTransform(10, 60);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Brushes.Black);
            Graphics graphics = e.Graphics;
            ApplyTransform(graphics);
            for (int i = 0; i <= gridRows; i++)
            {
                graphics.DrawLine(pen, 0, i * cellHeight, gridColumns * cellWidth, i * cellHeight);
            }
            for (int j = 0; j <= gridColumns; j++)
            {
                graphics.DrawLine(pen, j * cellWidth, 0, j * cellWidth, gridRows * cellHeight);
            }

            for (int x = 0; x < gridColumns; x++)
            {
                for (int y = 0; y < gridRows; y++)
                {
                    if (gridState[x, y])
                    {
                        graphics.FillRectangle(Brushes.Black, x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextGenerationButton_Click(sender, e);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextGenerationButton.Enabled = false;
            clearButton.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            nextGenerationButton.Enabled = true;
            clearButton.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            timer1.Stop();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gridState = new Grid(cellWidth, cellHeight);
            Invalidate();
        }
    }
}
