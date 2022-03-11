namespace Day09Demo.AssignmentSample.Utility
{
    public static class ConsoleTextColor
    {
        public static void SetError()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
        }

        public static void SetWarning() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        public static void Reset()
        {
            Console.ResetColor();
        }

        public static void SetHighlight()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
    }
}
