using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion
{
    // Класс для управления цветом текста консоли
    public static class ConsoleEx
    {
        private const string PREFIX = "C#: ";

        public static void WriteLineRed(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }

        public static void WriteLineGreen(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }

        public static void WriteLineWhite(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }
    }
}
