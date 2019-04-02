﻿using GOL.Engine.Game;

namespace GOL.Game
{
    public class NextLifecycle
    {
        public bool[,] NewBoardCreation(Board grid)
        {
            bool[,] tempBoard = new bool[grid.Width, grid.Height];

            for (int y = 0; y < grid.Height; y++)
            {
                for (int x = 0; x < grid.Width; x++)
                {
                    int neighbourCount = LiveNeighbourCount(x, y, grid);
                    bool cellIsAlive = grid.Grid[x, y];
                    // alive AND 2 or 3 neighbours means it lives
                    // dead AND 3 neighbours are alive means it lives
                    // otherwise the cell dies
                    bool aliveCellHasNeededNeighbours = neighbourCount == 2 || neighbourCount == 3;
                    bool deadCellHasNeededNeighbours = neighbourCount == 3;
                    bool cellStaysAlive = cellIsAlive && aliveCellHasNeededNeighbours;
                    bool cellIsRevived = !cellIsAlive && deadCellHasNeededNeighbours;

                    tempBoard[x, y] = cellStaysAlive || cellIsRevived;
                }
            }
            return tempBoard;
        }

        private int LiveNeighbourCount(int x, int y, Board grid)
        {
            int count = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                if (i < 0 || i >= grid.Height)
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j >= grid.Width)
                        continue;
                    if (grid.Grid[j, i])
                        count++;
                }
            }
            //the nested loop counts the x,y value, so if it is alive, we substract it
            if (grid.Grid[x, y])
                count--;
            return count;
        }
    }
}
