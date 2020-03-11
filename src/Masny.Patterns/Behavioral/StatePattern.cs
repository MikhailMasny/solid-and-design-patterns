using System;

namespace Masny.Patterns.Behavioral.State
{
    interface IState
    {
        void DoSomething();
    }

    class ConcreteStateA : IState
    {
        public void DoSomething()
        {
            Console.WriteLine($"Some simple text.");
        }
    }

    class ConcreteStateB : IState
    {
        public void DoSomething()
        {
            Console.WriteLine($"Another simple text.");
        }
    }

    class Context
    {
        private IState _state;

        public IState State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"Now state is: {_state.GetType().Name}.");
            }
        }

        public void Request()
        {
            _state.DoSomething();
            Console.WriteLine();
        }
    }

    public class StatePattern
    {
        public void Start()
        {
            var context = new Context();

            var concreteStateA = new ConcreteStateA();
            var concreteStateB = new ConcreteStateB();

            context.State = concreteStateA;
            context.Request();

            context.State = concreteStateB;
            context.Request();

            context.State = concreteStateA;
            context.Request();
        }
    }
}
