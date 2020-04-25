using System;

namespace Masny.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Display.Start();

            var app = new AppClassic();
            app.Start();

            Console.ReadKey();
        }
    }
}
