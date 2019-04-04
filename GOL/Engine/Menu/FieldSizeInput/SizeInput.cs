using System;

namespace GOL.Engine.Menu.FieldSizeInput
{
    public class SizeInput
    {
        private SizeValidator validate = new SizeValidator();

        public int SetFieldSize(string s)
        {
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
