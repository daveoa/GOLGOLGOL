using System;

namespace GOL.Engine.Menu.FieldSizeInput
{
    public class SizeInput
    {
        public int SetFieldSize(string s)
        {
            SizeValidator validate = new SizeValidator();

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
