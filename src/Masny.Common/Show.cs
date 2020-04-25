using Masny.Core;
using System;

namespace Masny.Common
{
    public static class ShowExtension
    {
        public static void RunAtConsole(this IExample example)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            example.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\nPress any key to continue..");
            Console.ReadKey();
            Console.Clear();
            Display.Menu();
        }

        public static void RunAtCLI(this IExample example)
        {
            example.Start();
        }
    }
}
