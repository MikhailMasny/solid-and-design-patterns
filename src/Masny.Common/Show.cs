using Masny.Core;
using System;

namespace Masny.Common
{
    public class Show
    {
        public void RunAtApp(IExample example)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            example.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\nPress any key to continue..");
            Console.ReadKey();
            Console.Clear();
            Display.Menu();
        }

        public void RunAtCLI(IExample example)
        {
            // TODO
        }
    }
}
