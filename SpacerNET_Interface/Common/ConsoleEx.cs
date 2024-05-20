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

        public static void WriteLineRed(String message, bool prefix = true)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            if (prefix)
            {
                Console.WriteLine(PREFIX + message);
            }
            else
            {
                Console.WriteLine(message);
            }
            
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

        public static void WriteLineYellow(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }

        public static void WriteLineCyan(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }


        public static void WriteYellow(String message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(PREFIX + message);
            Console.ForegroundColor = oldColor;
        }

    }
}
