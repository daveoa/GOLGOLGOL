using System;

namespace GOL.Engine.Display.Helper
{
    public class CoordinateInput
    {
        public int SetCoordinate(string s)
        {
            CoordinateValidator validate = new CoordinateValidator();

            Console.WriteLine("\nEnter " + s + "(0 to 32):");
            string input = Console.ReadLine();
            int coord = validate.ConvertToInt(input);
            while (validate.IsValid(coord))
            {
                input = Console.ReadLine();
                coord = validate.ConvertToInt(input);
            }
            return coord;
        }
    }
}
