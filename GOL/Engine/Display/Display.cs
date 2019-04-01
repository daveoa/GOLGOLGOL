using GOL.Engine.Display.Helper;
using GOL.Engine.Display.UserInput;
using GOL.Engine.Display.UserOutput;
using GOL.Game;

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

            show.OutputStringToConsole(ConfigSettings.CellCreationNotification);
            do
            {
                int x = coord.SetCoordinate(ConfigSettings.XCoordinate);
                int y = coord.SetCoordinate(ConfigSettings.YCoordinate);
                gridEdit.AddNewAliveCell(x, y, grid);
                DisplayBoard(grid);
                show.OutputStringToConsole(ConfigSettings.CellCreationInquiry);
            } while (post.GetUserInputKey() == 'y');
            DisplayBoard(grid);
        }

        public void DisplayBoard(Board grid)
        {
            BoardToStringBuilder stringdBoard = new BoardToStringBuilder();
            ConsoleOutput outputter = new ConsoleOutput();
            outputter.OutputStringToConsoleDefaultPos(stringdBoard.ConvertToString(grid));
        }
        
    }
}
