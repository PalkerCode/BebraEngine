using System;

namespace BebraEngine.BebraEngine
{
    public class Debug
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Out.WriteLine($"[LOG]: {message}");
            Console.ResetColor();
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Out.WriteLine($"[WARN]: {message}");
            Console.ResetColor();
        }
    }
}