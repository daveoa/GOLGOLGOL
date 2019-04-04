using GOL.Engine.Config;
using GOL.Engine.Menu.FieldSizeInput;
using System;

namespace GOL.Engine.Menu
{
    class ConsoleMenu
    {
        public Tuple<int, int> FieldDimensonSetup()
        {
            SizeInput coord = new SizeInput();

            Console.WriteLine(ConfigSettings.BoardCreationNotification);
            int x = coord.SetFieldSize(ConfigSettings.Width);
            int y = coord.SetFieldSize(ConfigSettings.Height);
            var result = Tuple.Create(x, y);
            return result;
        }
    }
}
