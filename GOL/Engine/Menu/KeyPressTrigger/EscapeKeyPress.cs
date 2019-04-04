using System;

namespace GOL.Engine.Menu.KeyPressTrigger
{
    public static class EscapeKeyPress
    {
        public static bool ReadEscapeKeyPress()
        {
            return !Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
    }
}
