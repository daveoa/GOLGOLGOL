namespace GOL.Engine.Config
{
    public static class ConfigSettings
    {
        public static char ConfirmationKey { get { return 'y'; } }
        public static char FullBlock { get { return '\u2588'; } }
        public static char EmptyBlock { get { return '_'; } }

        public static string BoardCreationNotification { get { return "\nSet the size and width of field";} }
        public static string Width { get { return "Width";} }
        public static string Height { get { return "Height";} }
        public static string InvalidInput { get { return "Invalid imput"; } }

        public static int Delay { get { return 1000; } } //1 second
    }
}
