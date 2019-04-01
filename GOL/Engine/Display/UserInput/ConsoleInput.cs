﻿using System;

namespace GOL.Engine.Display.UserInput
{
    public class ConsoleInput
    {
        public char GetUserInputKey()
        {
            return Console.ReadKey().KeyChar;
        }

        public string GetUserInputLine()
        {
            return Console.ReadLine();
        }

        public bool ReadEscapeKeyPress()
        {
            return !Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
    }
}
