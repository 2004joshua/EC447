using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Grid
    {
        private bool[,] cells; // Renamed from grid
        private int columnCount, rowCount; // Renamed from cx and cy

        public Grid()
        {
        }

        public Grid(int columns, int rows) // Renamed parameters from x and y
        {
            cells = new bool[columns, rows];
            columnCount = columns;
            rowCount = rows;
        }

        private int CountNeighbors(int column, int row) // Renamed method and parameters
        {
            int neighborCount = 0; // Renamed from num
            for (int i = column - 1; i <= column + 1; i++)
            {
                for (int j = row - 1; j <= row + 1; j++)
                {
                    if (!(i == column && j == row)) // Skip the current cell
                    {
                        if (this[i, j])
                        {
                            neighborCount++;
                        }
                    }
                }
            }
            return neighborCount;
        }

        public bool this[int column, int row] // Renamed parameters
        {
            get
            {
                if (column < 0 || row < 0 || column >= columnCount || row >= rowCount) return false;
                return cells[column, row];
            }
            set
            {
                if (column < 0 || row < 0 || column >= columnCount || row >= rowCount) return; // Ignore out of bounds
                cells[column, row] = value;
            }
        }

        public void Generate(Grid nextGrid) // Renamed parameter g to nextGrid
        {
            for (int column = 0; column < columnCount; column++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    int neighborCount = CountNeighbors(column, row);
                    if (this[column, row]) // For the current cell
                    {
                        if (neighborCount >= 2 && neighborCount <= 3)
                        {
                            nextGrid[column, row] = true;
                        }
                        else
                        {
                            nextGrid[column, row] = false;
                        }
                    }
                    else if (neighborCount == 3)
                    {
                        nextGrid[column, row] = true;
                    }
                    else
                    {
                        nextGrid[column, row] = false;
                    }
                }
            }
        }
    }
}
