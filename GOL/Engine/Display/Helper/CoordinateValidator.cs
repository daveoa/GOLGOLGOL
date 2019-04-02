using GOL.Engine.Config;
using System;

namespace GOL.Engine.Display.Helper
{
    public class CoordinateValidator
    {
        public bool IsValid(int x)
        {
            return x < 0 || x > 32;
        }

        public int ConvertToInt(string s)
        {
            int x;
            try
            {
                x = Convert.ToInt32(s);
            }
            catch (Exception)
            {
                Console.WriteLine(ConfigSettings.InvalidInput);
                return -1;
            }
            return x;
        }
    }
}
