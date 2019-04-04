using GOL.Engine.GameMechanics.Models;

namespace GOL.Engine.GameMechanics
{
    public class NextLifecycle
    {
        public bool[,] NewBoardCreation(Board table)
        {
            bool[,] tempBoard = new bool[table.Width, table.Height];

            for (int y = 0; y < table.Height; y++)
            {
                for (int x = 0; x < table.Width; x++)
                {
                    int neighbourCount = LiveNeighbourCount(x, y, table);
                    bool isCellAlive = table.Grid[x, y];
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

        private int LiveNeighbourCount(int x, int y, Board table)
        {
            int count = 0;
            for (int offsetHeight = y - 1; offsetHeight <= y + 1; offsetHeight++)
            {
                if (offsetHeight < 0 || offsetHeight >= table.Height)
                    continue;
                for (int offsetWidth = x - 1; offsetWidth <= x + 1; offsetWidth++)
                {
                    if (offsetWidth < 0 || offsetWidth >= table.Width)
                        continue;
                    if (table.Grid[offsetWidth, offsetHeight])
                        count++;
                }
            }
            if (table.Grid[x, y])
                count--;
            return count;
        }
    }
}
