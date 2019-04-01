using static GOL.ConfigSettings.DimensionValues;

namespace GOL.Game
{
    public class BoardGame
    {
        public void NewBoardCreation(Board grid)
        {
            BoardInput gridInput = new BoardInput();
            bool[,] tempBoard = new bool[(int)BoardWidth, (int)BoardHeight];

            for (int y = 0; y < (int)BoardHeight; y++)
            {
                for (int x = 0; x < (int)BoardWidth; x++)
                {
                    int neighbourCount = _LiveNeighbourCount(x, y, grid);
                    bool cellIsAlive = grid.GetValue(x, y);
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

            for (int y = 0; y < (int)BoardHeight; y++)
            {
                for (int x = 0; x < (int)BoardWidth; x++)
                {
                    if (tempBoard[x, y])
                        gridInput.AddNewAliveCell(x, y, grid);
                    else
                        gridInput.AddNewDeadCell(x, y, grid);
                }
            }
        }

        private int _LiveNeighbourCount(int x, int y, Board grid)
        {
            int count = 0;
            for (int i = y - 1; i <= y + 1; i++)
            {
                // i < 0 or i > 15 means that the index is outside of the board
                if (i < 0 || i > 15)
                    continue;
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (j < 0 || j > 15)
                        continue;
                    if (grid.GetValue(j, i) == true)
                        count++;
                }
            }
            //the nested loop counts the x,y value, so if it is alive, we substract it
            if (grid.GetValue(x, y) == true)
                count--;
            return count;
        }
    }
}
