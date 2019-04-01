namespace GOL.Engine.Display.Helper
{
    class CoordinateInput
    {
        public int SetCoordinate(string s)
        {
            ConsoleOutput show = new ConsoleOutput();
            ConsoleInput post = new ConsoleInput();
            CoordinateValidator validate = new CoordinateValidator();

            show.OutputStringToConsole("\nEnter " + s + "(0 to 15):");
            string input = post.GetUserInputLine();
            int coord = validate.ConvertToInt(input);
            while (!validate.IsValid(coord))
            {
                input = post.GetUserInputLine();
                coord = validate.ConvertToInt(input);
            }
            return coord;
        }
    }
}
