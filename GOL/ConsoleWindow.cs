using System;

namespace GOL
{
    public class ConsoleWindow
    {
        public void ConfigureConsole()
        {
            Console.SetWindowSize((int)ConfigSettings.DimensionValues.WindowWidth, (int)ConfigSettings.DimensionValues.WindowHeight);
            Console.SetBufferSize((int)ConfigSettings.DimensionValues.BufferWidth, (int)ConfigSettings.DimensionValues.BufferHeight);
        }
    }
}
