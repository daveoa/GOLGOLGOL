using GOL.Engine.GameMechanics.Model;
using System;

namespace GOL.Engine.GameMechanics
{
    public class BoardGame : Board
    {
        NextLifecycle _update = new NextLifecycle();

        public BoardGame CreateNewBoard(int x, int y)
        {
            BoardGame grid = new BoardGame();
            grid.Width = x;
            grid.Height = y;
            grid.Iteration = 0;
            grid.Grid = new bool[grid.Width, grid.Height];
            grid = FillBoard(grid);
            grid.CellCount = CountCells(grid);
            return grid;
        }

        public BoardGame FillBoard(BoardGame grid)
        {
            var random = new Random();
            for (var i = 0; i < grid.Height; i++)
            {
                for (var j = 0; j < grid.Width; j++)
                {
                    grid.Grid[j, i] = random.Next(2) == 0;
                }
            }
            return grid;
        }

        public BoardGame NextIteration(BoardGame grid)
        {
            grid.Grid = _update.NewBoardCreation(grid);
            grid.CellCount = CountCells(grid);
            grid.Iteration += 1;
            return grid;
        }

        private int CountCells(BoardGame grid)
        {
            int cellCount = 0;
            for (var i = 0; i < grid.Height; i++)
            {
                for (var j = 0; j < grid.Width; j++)
                {
                    if (grid.Grid[j, i]) cellCount++;
                }
            }
            return cellCount;
        }
    }
}
