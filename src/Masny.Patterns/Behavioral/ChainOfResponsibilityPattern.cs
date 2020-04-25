using Masny.Core;
using System;
using System.Collections.Generic;

namespace Masny.Patterns.Behavioral.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class FirstHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "FirstValue")
            {
                return $"FirstObject: Use {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class SecondHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "SecondValue")
            {
                return $"SecondObject: Use {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class ThirdHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "ThirdValue")
            {
                return $"ThirdObject: Use {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        public bool ClientCode(AbstractHandler handler)
        {
            foreach (var someValue in new List<string> { "FirstValue", "SecondValue", "ThirdValue" })
            {
                Console.WriteLine($"Client: {someValue}?");

                var result = handler.Handle(someValue);

                if (result != null)
                {
                    Console.Write($"{result}");
                    Console.WriteLine(new string('-', 45));
                }
                else
                {
                    Console.WriteLine($"{someValue} was left with error.");
                    Console.WriteLine(new string('-', 45));
                    return false;
                }
            }

            return true;
        }
    }

    public class ChainOfResponsibilityPattern : IExample
    {
        public void Start()
        {
            var firstObject = new FirstHandler();
            var secondObject = new SecondHandler();
            var thiredObject = new ThirdHandler();

            var client = new Client();

            firstObject.SetNext(secondObject).SetNext(thiredObject);

            Console.WriteLine("Chain: FirstObject > SecondObject > ThiredObject\n");
            var resultFirstOperation = client.ClientCode(firstObject);
            Console.WriteLine("First chain result: " + resultFirstOperation);
            
            Console.WriteLine("\n\n");

            Console.WriteLine("Subchain: SecondObject > ThiredObject\n");
            var resultSecondOperation = client.ClientCode(secondObject);
            Console.WriteLine("Second chain result: " + resultSecondOperation);
        }
    }
}
