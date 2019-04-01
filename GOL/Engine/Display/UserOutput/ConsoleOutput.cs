using System;

namespace GOL
{
    public class ConsoleOutput
    {
        public void OutputStringToConsoleDefaultPos(string s)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(s);
        }

        public void OutputStringToConsole(string s)
        {
            Console.WriteLine(s);
        }
    }
}
