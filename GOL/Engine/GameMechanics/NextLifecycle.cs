using GOL.Engine.GameMechanics.Model;

namespace GOL.Engine.GameMechanics
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
                    bool isCellAlive = grid.Grid[x, y];
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
                return AliveHasNeededNeighbours(neighbourCount);
            }
            else
            {
                return DeadHasNeededNeighbours(neighbourCount);
            }
        }

        private bool AliveHasNeededNeighbours(int neighbourCount)
        {
            return neighbourCount == 2 || neighbourCount == 3;
        }

        private bool DeadHasNeededNeighbours(int neighbourCount)
        {
            return neighbourCount == 3;
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
