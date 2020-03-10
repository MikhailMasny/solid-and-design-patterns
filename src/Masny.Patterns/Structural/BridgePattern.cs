using System;

namespace Masny.Patterns.Structural.Bridge
{
    interface IImplementor
    {
        void Operation();
    }

    class ConcreteImplementorA : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine($"Called {nameof(ConcreteImplementorA)}.{nameof(Operation)}()");
        }
    }

    class ConcreteImplementorB : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine($"Called {nameof(ConcreteImplementorB)}.{nameof(Operation)}()");
        }
    }

    class Abstraction
    {
        protected IImplementor implementor;

        public IImplementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            if (implementor == null)
            {
                Console.WriteLine("Implementor is null.");
                return;
            }

            implementor.Operation();
        }
    }

    public class BridgePattern
    {
        public void Start()
        {
            Abstraction ab = new RefinedAbstraction();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }
    }
}
