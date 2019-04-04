using System;

namespace GOL.Engine.Menu.KeyPressTriggers
{
    public static class EscapeKeyPress
    {
        public static bool EscIsNotPressed()
        {
            return !Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
    }
}
