using System;

namespace Masny.SOLID.DIP
{
    interface IFirstAction
    {
        void Action(string text);
    }

    class FirstClass : IFirstAction
    {
        public void Action(string text)
        {
            Console.WriteLine($"Message: {text}");
            Console.WriteLine($"{nameof(FirstClass)} {nameof(Action)}");
        }
    }

    class SecondClass : IFirstAction
    {
        public void Action(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine($"{nameof(SecondClass)} {nameof(Action)}");
        }
    }

    class SomeClass
    {
        public string SomeText { get; set; }
        public IFirstAction FirstAction { get; set; }

        public SomeClass(IFirstAction firstAction)
        {
            FirstAction = firstAction ?? throw new ArgumentNullException(nameof(firstAction));
        }

        public void Run()
        {
            FirstAction.Action(SomeText);
        }
    }

    public class DependencyInversionPrinciple
    {
        public void Start()
        {
            var someClass = new SomeClass(new FirstClass());
            someClass.Run();

            Console.WriteLine();

            someClass.FirstAction = new SecondClass();
            someClass.SomeText = "This is our message!";
            someClass.Run();
        }
    }
}
