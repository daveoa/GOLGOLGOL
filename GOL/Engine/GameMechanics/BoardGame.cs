using GOL.Engine.GameMechanics.Models;
using System;

namespace GOL.Engine.GameMechanics
{
    public class BoardGame : Board
    { 
        public BoardGame CreateNewBoard(int x, int y)
        {
            this.Width = x;
            this.Height = y;
            this.Iteration = 0;
            this.Grid = new bool[this.Width, this.Height];
            this.FillBoard();
            this.CellCount = CountCells();
            return this;
        }

        private BoardGame FillBoard()
        {
            var random = new Random();
            for (var i = 0; i < this.Height; i++)
            {
                for (var j = 0; j < this.Width; j++)
                {
                    this.Grid[j, i] = random.Next(2) == 0;
                }
            }
            return this;
        }

        public BoardGame NextIteration()
        {
            this.Grid = this.NewBoardCreation();
            this.CellCount = CountCells();
            this.Iteration++;
            return this;
        }

        public int CountCells()
        {
            int cellCount = 0;
            for (var i = 0; i < this.Height; i++)
            {
                for (var j = 0; j < this.Width; j++)
                {
                    if (this.Grid[j, i]) cellCount++;
                }
            }
            return cellCount;
        }

        public bool[,] NewBoardCreation()
        {
            bool[,] tempBoard = new bool[this.Width, this.Height];

            for (int y = 0; y < this.Height; y++)
            {
                for (int x = 0; x < this.Width; x++)
                {
                    int neighbourCount = LiveNeighbourCount(x, y);
                    bool isCellAlive = this.Grid[x, y];
                    // alive AND 2 or 3 neighbours means it lives
                    // dead AND 3 neighbours are alive means it lives
                    // otherwise the cell dies
                    tempBoard[x, y] = DoesCellLive(isCellAlive, neighbourCount);
                }
            }
            return tempBoard;
        }

        private bool DoesCellLive(bool isCellAlive, int neighbourCount)
        {
            if (isCellAlive)
            {
                return neighbourCount == 2 || neighbourCount == 3;
            }
            else
            {
                return neighbourCount == 3;
            }
        }

        private int LiveNeighbourCount(int x, int y)
        {
            int count = 0;
            for (int offsetHeight = y - 1; offsetHeight <= y + 1; offsetHeight++)
            {
                if (offsetHeight < 0 || offsetHeight >= this.Height)
                    continue;
                for (int offsetWidth = x - 1; offsetWidth <= x + 1; offsetWidth++)
                {
                    if (offsetWidth < 0 || offsetWidth >= this.Width)
                        continue;
                    if (this.Grid[offsetWidth, offsetHeight])
                        count++;
                }
            }
            if (this.Grid[x, y])
                count--;
            return count;
        }
    }
}
