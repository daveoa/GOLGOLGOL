using GOL.Engine.Config;
using GOL.Engine.GameMechanics.Models;
using GOL.Engine.Menu.FieldSizeInput;
using System;

namespace GOL.Engine.Menu
{
    public class ConsoleMenu
    {
        private SizeInput _coord = new SizeInput();

        public Dimensions FieldDimensonSetup()
        {

            Console.WriteLine(ConfigSettings.BoardCreationNotification);
            int x = _coord.SetFieldSize(ConfigSettings.Width);
            int y = _coord.SetFieldSize(ConfigSettings.Height);
            var result = new Dimensions(x, y);
            return result;
        }

        public string GetFilenameFromInput(string s)
        {
            string filename;
            Console.WriteLine(s);
            filename = Console.ReadLine();
            return filename;
        }

        public bool WantsToSaveGame()
        {
            Console.WriteLine(ConfigSettings.SaveInquiry);
            if (Console.ReadKey().KeyChar == ConfigSettings.ConfirmationKey)
            {
                return true;
            }
            return false;
        }

        public bool WantsToLoadGame()
        {
            Console.WriteLine(ConfigSettings.LoadInquiry);
            if (Console.ReadKey().KeyChar == ConfigSettings.ConfirmationKey)
            {
                return true;
            }
            return false;
        }
    }
}
