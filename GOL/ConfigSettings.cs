namespace GOL
{
    public static class ConfigSettings
    {
        public static char FullBlock { get { return '\u2588'; } }
        public static char EmptyBlock { get { return '_'; } }
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
