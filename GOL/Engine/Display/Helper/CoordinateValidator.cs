using System;

namespace GOL.Engine.Display.Helper
{
    public class CoordinateValidator
    {
        public bool IsValid(int x)
        {
            if (x < 0 || x > 15)
                return false;
            return true;
        }

        public int ConvertToInt(string s)
        {
            ConsoleOutput show = new ConsoleOutput();
            int x;
            try
            {
                x = Convert.ToInt32(s);
            }
            catch (Exception)
            {
                show.OutputStringToConsole("Incorrect input");
                return -1;
            }
            return x;
        }
    }
}
