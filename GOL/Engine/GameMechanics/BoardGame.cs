using GOL.Engine.GameMechanics.Models;
using System;

namespace GOL.Engine.GameMechanics
{
    public class BoardGame : Board
    {
        NextLifecycle _update = new NextLifecycle();

        public BoardGame CreateNewBoard(int x, int y)
        {
            BoardGame table = new BoardGame();
            table.Width = x;
            table.Height = y;
            table.Iteration = 0;
            table.Grid = new bool[table.Width, table.Height];
            table = FillBoard(table);
            table.CellCount = CountCells(table);
            return table;
        }

        public BoardGame FillBoard(BoardGame table)
        {
            var random = new Random();
            for (var i = 0; i < table.Height; i++)
            {
                for (var j = 0; j < table.Width; j++)
                {
                    table.Grid[j, i] = random.Next(2) == 0;
                }
            }
            return table;
        }

        public BoardGame NextIteration(BoardGame table)
        {
            table.Grid = _update.NewBoardCreation(table);
            table.CellCount = CountCells(table);
            table.Iteration += 1;
            return table;
        }

        private int CountCells(BoardGame table)
        {
            int cellCount = 0;
            for (var i = 0; i < table.Height; i++)
            {
                for (var j = 0; j < table.Width; j++)
                {
                    if (table.Grid[j, i]) cellCount++;
                }
            }
            return cellCount;
        }
    }
}
