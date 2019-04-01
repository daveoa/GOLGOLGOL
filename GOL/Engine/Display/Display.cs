using GOL.Engine.Display.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GOL.Engine.Display
{
    public class Displayer
    {
        public void DisplayCellCreation(Board grid)
        {
            ConsoleOutput show = new ConsoleOutput();
            ConsoleInput post = new ConsoleInput();
            CoordinateInput coord = new CoordinateInput();
            BoardInput gridEdit = new BoardInput();

            show.OutputStringToConsole("\nCreate new cells");
            do
            {
                int x = coord.SetCoordinate("x");
                int y = coord.SetCoordinate("y");
                gridEdit.AddNewAliveCell(x, y, grid);
                DisplayBoard(grid);
                show.OutputStringToConsole("Make another cell? (y/n)");
            } while (post.GetUserInputKey() == 'y');
            DisplayBoard(grid);
        }

        public void DisplayBoard(Board grid)
        {
            BoardToStringBuilder stringdBoard = new BoardToStringBuilder();
            ConsoleOutput outputter = new ConsoleOutput();
            outputter.OutputStringToConsoleDefaultPos(stringdBoard.ConvertToString(grid));
        }

        public void DisplayNewGameIteration(Board grid)
        {
            ConsoleInput esc = new ConsoleInput();
            BoardGame gridUpdate = new BoardGame();

            while (esc.ReadEscapeKeyPress())
            {
                gridUpdate.NewBoardCreation(grid);
                DisplayBoard(grid);
                Thread.Sleep(ConfigSettings.Delay);
            }
        }
    }
}
