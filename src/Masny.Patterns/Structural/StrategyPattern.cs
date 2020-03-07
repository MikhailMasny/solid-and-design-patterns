using System;

namespace Masny.Patterns.Structural.Strategy
{
    interface IStrategy
    {
        void SomeMethod();
    }

    class ConcreteStrategyC : IStrategy
    {
        public void SomeMethod()
        {
            Console.WriteLine($"{nameof(ConcreteStrategyC)}.");
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public void SomeMethod()
        {
            Console.WriteLine($"{nameof(ConcreteStrategyB)}.");
        }
    }

    class ConcreteStrategyA : IStrategy
    {
        public void SomeMethod()
        {
            Console.WriteLine($"{nameof(ConcreteStrategyA)}.");
        }
    }

    class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextMethod()
        {
            _strategy.SomeMethod();
        }
    }

    public class StrategyPattern
    {
        public void Start()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextMethod();

            context = new Context(new ConcreteStrategyB());
            context.ContextMethod();

            context = new Context(new ConcreteStrategyC());
            context.ContextMethod();
        }
    }
}
