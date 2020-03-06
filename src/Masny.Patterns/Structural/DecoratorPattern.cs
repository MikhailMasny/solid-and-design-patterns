using System;

namespace Masny.Patterns.Structural
{
    class ConcreteDecoratorA : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            Console.WriteLine($"{nameof(ConcreteDecoratorA)}.{nameof(Operation)}");
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public new void Operation()
        {
            base.Operation();
            SomeMethod();
            Console.WriteLine($"{nameof(ConcreteDecoratorB)}.{nameof(Operation)}");
        }

        void SomeMethod()
        {
            Console.WriteLine("Some text here.");
        }
    }

    interface IComponent
    {
        void Operation();
    }

    abstract class Decorator : IComponent

    {
        protected IComponent _component;

        public void SetComponent(IComponent component)
        {
            _component = component;
        }

        public void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }

    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine($"{nameof(ConcreteComponent)}.{nameof(Operation)}");
        }
    }

    public class DecoratorPattern
    {
        public void Start()
        {
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            d1.Operation();

            Console.WriteLine();

            d2.Operation();

            Console.WriteLine();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.WriteLine();

            d1.Operation();

            Console.WriteLine();

            c.Operation();
        }
    }
}
