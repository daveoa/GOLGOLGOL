using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public class Board
    {
        private bool[,] Grid;

        public Board()
        {
            Grid = new bool[ConfigSettings.Width, ConfigSettings.Height];
        }

        public bool GetValue(int x, int y)
        {
            return Grid[x, y];
        }

        public void SetValue(int x, int y, bool value = true)
        {
            Grid[x, y] = value;
        }
    }
}
