using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public static class BoardGame
    {
        public static void NewBoardCalcuation(Board grid)
        {
            bool[,] tempBoard = new bool[ConfigSettings.Width, ConfigSettings.Height];
            for (int y = 0; y < ConfigSettings.Height; y++)
            {
                for (int x = 0; x < ConfigSettings.Width; x++)
                {
                    int neighbourCount = LiveNeighbourCount(x, y, grid);
                    bool cell = grid.GetValue(x, y);
                    // alive AND 2 or 3 neighbours means it lives
                    // dead AND 3 neighbours are alive means it lives
                    // otherwise the cell dies
                    //tempBoard.SetValue(x, y,
                    //            (cell && (neighbourCount == 2 || neighbourCount == 3)) || (!cell && (neighbourCount == 3)));
                    tempBoard[x, y] = (cell && (neighbourCount == 2 || neighbourCount == 3)) || (!cell && (neighbourCount == 3));
                }
            }

            for (int y = 0; y < ConfigSettings.Height; y++)
            {
                for (int x = 0; x < ConfigSettings.Width; x++)
                {
                    grid.SetValue(x, y, tempBoard[x, y]);
                }
            }
        }
        private static int LiveNeighbourCount(int x, int y, Board grid)
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
