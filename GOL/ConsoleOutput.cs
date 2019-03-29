using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public static class ConsoleOutput
    {
        public static void ConfigureConsole()
        {
            Console.SetWindowSize(ConfigSettings.Width * 8 + 4, ConfigSettings.Height * 2 + 10);
            Console.SetBufferSize(ConfigSettings.Width * 8 + 4, ConfigSettings.Height * 2 + 10);
        }

        public static void DisplayBoard(Board grid)
        {
            var displayString = new StringBuilder();
            for (int y = 0; y < ConfigSettings.Height; y++)
            {
                for (int x = 0; x < ConfigSettings.Width; x++)
                {
                    char c = grid.GetValue(x, y) ? ConfigSettings.FullBlock : ConfigSettings.EmptyBlock;
                    // 2 appends because that will make a nice square
                    displayString.Append(c);
                    displayString.Append(c);
                }
                displayString.Append("\n");
            }
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(displayString.ToString());
        }
    }
}
