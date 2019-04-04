using GOL.Engine.Config;
using GOL.Engine.GameMechanics.Models;
using GOL.Engine.Menu.FieldSizeInput;
using System;

namespace GOL.Engine.Menu
{
    class ConsoleMenu
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

        public string GetFilenameFromInput()
        {
            string filename;
            Console.WriteLine("\nEnter the name for this game:");
            filename = Console.ReadLine();
            return filename;
        }

        public bool WantsToSaveGame()
        {
            Console.WriteLine("\nSave game to file? (y/n)");
            if (Console.ReadKey().KeyChar == ConfigSettings.ConfirmationKey)
            {
                return true;
            }
            return false;
        }
    }
}
