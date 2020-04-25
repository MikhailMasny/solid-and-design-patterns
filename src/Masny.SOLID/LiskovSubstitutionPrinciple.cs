using Masny.Core;
using System;
using System.Linq;

namespace Masny.SOLID.LSP
{
    abstract class SomeClass
    {
        protected readonly int[] _numbers;

        public SomeClass(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Action();
    }

    class FirstClass : SomeClass
    {
        public FirstClass(int[] numbers)
            : base(numbers)
        {
        }

        public override int Action()
        {
            return _numbers.Sum();
        }
    }

    class SecondClass : SomeClass
    {
        public SecondClass(int[] numbers)
           : base(numbers)
        {
        }

        public override int Action()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }

    public class LiskovSubstitutionPrinciple : IExample
    {
        public void Start()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            SomeClass firstClass = new FirstClass(numbers);
            Console.WriteLine($"Result of {nameof(FirstClass)} = {firstClass.Action()}");

            Console.WriteLine();

            SomeClass secondClass = new SecondClass(numbers);
            Console.WriteLine($"Result of {nameof(SecondClass)} = {secondClass.Action()}");
        }
    }
}
