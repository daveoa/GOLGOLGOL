using GOL.Engine.Config;
using GOL.Engine.Display.Helper;
using GOL.Engine.Game;
using System;

namespace GOL.Engine.Display
{
    public class Displayer
    {
        public void FieldCreation(Board grid)
        {
            CoordinateInput coord = new CoordinateInput();

            Console.WriteLine(ConfigSettings.BoardCreationNotification);
            int x = coord.SetCoordinate(ConfigSettings.Width);
            int y = coord.SetCoordinate(ConfigSettings.Height);
            grid.CreateNewBoard(x, y);
        }

        public void DisplayBoard(Board grid)
        {
            BoardToStringBuilder stringdBoard = new BoardToStringBuilder();
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(stringdBoard.ConvertToString(grid));
        }
    }
}
