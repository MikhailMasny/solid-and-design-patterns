using System;

namespace Masny.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new AppClassic();
            app.Start();

            Console.ReadKey();
        }
    }
}
