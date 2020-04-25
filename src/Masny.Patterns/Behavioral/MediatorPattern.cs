using Masny.Core;
using System;

namespace Masny.Patterns.Behavioral.Mediator
{
    enum ComponentEnvironment
    {
        Comp1_MethodA,
        Comp1_MethodB,
        Comp2_MethodC,
        Comp2_MethodD
    }

    interface IMediator
    {
        void Notify(object sender, ComponentEnvironment env);
    }

    class ConcreteMediator : IMediator
    {
        private readonly Component1 _component1;

        private readonly Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component2 = component2;
        }

        public void Notify(object sender, ComponentEnvironment env)
        {
            Console.WriteLine($"Sender is {sender.GetType()}");

            if (env == ComponentEnvironment.Comp1_MethodA)
            {
                Console.WriteLine("Mediator triggers operations:");
                _component2.MethodC();
            }

            if (env == ComponentEnvironment.Comp2_MethodD)
            {
                Console.WriteLine("Mediator triggers operations:");
                _component1.MethodB();
                _component2.MethodC();
            }
        }
    }

    class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    class Component1 : BaseComponent
    {
        public void MethodA()
        {
            Console.WriteLine("--- Component 1 execute A.");

            _mediator.Notify(this, ComponentEnvironment.Comp1_MethodA);
        }

        public void MethodB()
        {
            Console.WriteLine("--- Component 1 execute B.");

            _mediator.Notify(this, ComponentEnvironment.Comp1_MethodB);
        }
    }

    class Component2 : BaseComponent
    {
        public void MethodC()
        {
            Console.WriteLine("--- Component 2 execute C.");

            _mediator.Notify(this, ComponentEnvironment.Comp2_MethodC);
        }

        public void MethodD()
        {
            Console.WriteLine("--- Component 2 execute D.");

            _mediator.Notify(this, ComponentEnvironment.Comp2_MethodD);
        }
    }

    public class MediatorPattern : IExample
    {
        public void Start()
        {
            var component1 = new Component1();
            var component2 = new Component2();

            IMediator mediator =  new ConcreteMediator(component1, component2);

            component1.SetMediator(mediator);
            component2.SetMediator(mediator);

            Console.WriteLine("Run operation A.");
            component1.MethodA();

            Console.WriteLine();

            Console.WriteLine("Run operation D.");
            component2.MethodD();
        }
    }
}
