using Masny.Core;
using System;

namespace Masny.Patterns.Structural.Facade
{
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" " + nameof(SubSystemOne));
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(" " + nameof(SubSystemTwo));
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" " + nameof(SubSystemThree));
        }
    }

    class Facade
    {
        private readonly SubSystemOne _one;
        private readonly SubSystemTwo _two;
        private readonly SubSystemThree _three;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine($"{nameof(Facade)}.{nameof(MethodA)}()");

            _one.MethodOne();
            _two.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine($"{nameof(Facade)}.{nameof(MethodB)}()");

            _two.MethodTwo();
            _three.MethodThree();
        }
    }

    public class FacadePattern : IExample
    {
        public void Start()
        {
            var facade = new Facade();

            facade.MethodA();
            Console.WriteLine();
            facade.MethodB();
        }
    }
}
