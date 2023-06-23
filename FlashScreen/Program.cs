namespace FlashScreen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Color1 = Color.Red;
            Color2 = Color.Blue;
            Continue = false;

            while (true)
            {
                Application.Run(new Start());

                if (!Continue)
                    break;

                Continue = false;
                Application.Run(new Flash());
            }
        }

        public static Color Color1 { get; set; }

        public static Color Color2 { get; set; }

        public static bool Continue { get; set; }
    }
}