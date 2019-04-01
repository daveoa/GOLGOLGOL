namespace GOL
{
    public static class ConfigSettings
    {
        public static char FullBlock { get { return '\u2588'; } }
        public static char EmptyBlock { get { return '_'; } }
        public static string CellCreationNotification { get { return "\nCreate new cells";} }
        public static string XCoordinate { get { return "x";} }
        public static string YCoordinate { get { return "y";} }
        public static string CellCreationInquiry { get { return "Make another cell? (y/n)"; } }
        public static string InvalidInput { get { return "Invalid imput"; } }

        public static int Delay { get { return 1000; } } //1 second
        public enum DimensionValues : int
        {
            BoardWidth = 16,
            BoardHeight = 16,
            BufferWidth = 16 * 8 + 4,
            BufferHeight = 16 * 2 + 10,
            WindowWidth = 16 * 8 + 4,
            WindowHeight = 16 * 2 + 10
        };
    }
}
