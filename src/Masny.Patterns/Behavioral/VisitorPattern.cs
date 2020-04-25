using Masny.Core;
using System;
using System.Collections.Generic;

namespace Masny.Patterns.Behavioral.Visitor
{
    interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }

    class ConcreteComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }

    interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }

    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} + {nameof(ConcreteVisitor1)}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} + {nameof(ConcreteVisitor1)}");
        }
    }

    class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteComponentA()} + {nameof(ConcreteVisitor2)}");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine($"{element.SpecialMethodOfConcreteComponentB()} + {nameof(ConcreteVisitor2)}");
        }
    }

    class Client
    {
        public void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }

    public class VisitorPattern : IExample
    {
        public void Start()
        {
            var client = new Client();

            var components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            var visitor1 = new ConcreteVisitor1();
            client.ClientCode(components, visitor1);

            Console.WriteLine();

            var visitor2 = new ConcreteVisitor2();
            client.ClientCode(components, visitor2);
        }
    }
}
