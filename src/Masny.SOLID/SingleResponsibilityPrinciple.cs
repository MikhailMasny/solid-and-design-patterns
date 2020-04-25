using Masny.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.SOLID.SRP
{
    interface IFirstAction
    {
        IEnumerable<string> ReadAction();
    }

    class FirstAction : IFirstAction
    {
        public IEnumerable<string> ReadAction()
        {
            Console.Write("Enter some string value: ");
            var valueOne = Console.ReadLine();

            Console.Write("Enter another string value: ");
            var valueTwo = Console.ReadLine();

            Console.WriteLine();

            return new List<string> { valueOne, valueTwo };
        }
    }

    class AnotherFirstAction : IFirstAction
    {
        public IEnumerable<string> ReadAction()
        {
            return new List<string> { "defaultValueOne", "defaultValueOne", "defaultValueThree" };
        }
    }

    interface ISecondAction
    {
        void ShowAction(IEnumerable<string> list);
    }

    class SecondAction : ISecondAction
    {
        public void ShowAction(IEnumerable<string> list)
        {
            if (!list.Any())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            list.ToList()
                .ForEach(item => Console.WriteLine(item));
        }
    }

    class MainClass
    {
        private readonly IFirstAction _firstAction;
        private readonly ISecondAction _secondAction;

        public MainClass(IFirstAction firstAction,
                         ISecondAction secondAction)
        {
            _firstAction = firstAction ?? throw new ArgumentNullException(nameof(firstAction));
            _secondAction = secondAction ?? throw new ArgumentNullException(nameof(secondAction));
        }

        public void Run()
        {
            var list = _firstAction.ReadAction();
            _secondAction.ShowAction(list);
        }
    }

    public class SingleResponsibilityPrinciple : IExample
    {
        public void Start()
        {
            IFirstAction firstAction = new FirstAction();
            ISecondAction secondAction = new SecondAction();

            var mainClass = new MainClass(firstAction, secondAction);
            mainClass.Run();

            Console.WriteLine("\nEnd of start method.");
        }
    }
}
