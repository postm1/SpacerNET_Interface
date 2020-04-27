using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion
{
    public static class ConsoleEx
    {
        public static void WriteLineRed(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        public static void WriteLineGreen(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        public static void WriteLineWhite(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }
    }
}
