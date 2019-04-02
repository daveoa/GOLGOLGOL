using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.Engine.Display.Helper
{
    public static class EscapeKeyPress
    {
        public static bool ReadEscapeKeyPress()
        {
            return !Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
    }
}
