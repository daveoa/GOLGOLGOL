namespace GOL.Engine.Config
{
    public static class ConfigSettings
    {
        public static char ConfirmationKey { get { return 'y'; } }
        public static char FullBlock { get { return '\u2588'; } }
        public static char EmptyBlock { get { return '_'; } }

        public static string BoardCreationNotification => "\nSet the size and width of field";
        public static string Width => "Width";
        public static string Height => "Height";
        public static string InvalidInput => "Invalid input";
        public static string Iteration => "Iteration: {0}";
        public static string CellCount => "Cell count: {0}";
        public static string Path => @"C:\Users\deivs.oskars.alksnis\";
        public static string SaveNameInquiry => "\nEnter the name for this game:";
        public static string LoadNameInquiry => "\nEnter the name for loadable save:";
        public static string SaveInquiry => "\nSave game to file? (y/n)";
        public static string LoadInquiry => "\nLoad game from file? (y/n)";

        public static int Delay => 1000; //1 second
    }
}
