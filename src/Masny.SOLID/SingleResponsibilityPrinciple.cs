using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.SOLID.SRP
{
    public interface IFirstAction
    {
        IEnumerable<string> ReadAction();
    }

    public class FirstAction : IFirstAction
    {
        public IEnumerable<string> ReadAction()
        {
            Console.WriteLine("Enter some value:");
            var valueOne = Console.ReadLine();

            Console.WriteLine("Enter another value:");
            var valueTwo = Console.ReadLine();

            return new List<string> { valueOne, valueTwo };
        }
    }

    public class AnotherFirstAction : IFirstAction
    {
        public IEnumerable<string> ReadAction()
        {
            return new List<string> { "defaultValueOne", "defaultValueOne", "defaultValueThree" };
        }
    }

    public interface ISecondAction
    {
        void ShowAction(IEnumerable<string> list);
    }

    public class SecondAction : ISecondAction
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

    public class SingleResponsibilityPrinciple
    {
        private readonly IFirstAction _firstAction;
        private readonly ISecondAction _secondAction;

        public SingleResponsibilityPrinciple(IFirstAction firstAction,
                         ISecondAction secondAction)
        {
            _firstAction = firstAction ?? throw new ArgumentNullException(nameof(firstAction));
            _secondAction = secondAction ?? throw new ArgumentNullException(nameof(secondAction));
        }

        public void Start()
        {
            var list = _firstAction.ReadAction();
            _secondAction.ShowAction(list);

            Console.WriteLine("End of start method.");
        }
    }
}
