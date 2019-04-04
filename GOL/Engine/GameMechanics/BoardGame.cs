using GOL.Engine.GameMechanics.Model;
using System;

namespace GOL.Engine.GameMechanics
{
    public class BoardGame : Board
    {
        public BoardGame CreateNewBoard(int x, int y)
        {
            BoardGame grid = new BoardGame();
            grid.Width = x;
            grid.Height = y;
            grid.Grid = new bool[grid.Width, grid.Height];
            grid.Grid = FillBoard(grid);
            return grid;
        }

        public bool[,] FillBoard(BoardGame grid)
        {
            var random = new Random();
            for (var i = 0; i < grid.Height; i++)
            {
                for (var j = 0; j < grid.Width; j++)
                {
                    grid.Grid[j, i] = random.Next(2) == 0;
                }
            }
            return grid.Grid;
        }
    }
}
