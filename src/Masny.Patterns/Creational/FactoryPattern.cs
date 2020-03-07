using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.Patterns.Creational.Factory
{
    interface IProduct
    {
        void DoSomething();
    }

    class ConcreteProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine($"Run method from class: {nameof(ConcreteProductA)}");
        }
    }

    class ConcreteProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine($"Run method from class: {nameof(ConcreteProductB)}");
        }
    }

    interface ICreator
    {
        IProduct FactoryMethod();
    }

    class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class FactoryPattern
    {
        public void Start()
        {
            IEnumerable<ICreator> creators = new List<ICreator>
            {
                new ConcreteCreatorA(),
                new ConcreteCreatorB()
            };

            creators.ToList()
                    .ForEach(creator =>
                    {
                        var product = creator.FactoryMethod();
                        var productMethod = product.GetType().GetMethod("DoSomething");
                        productMethod.Invoke(product, new object[] { });

                        Console.WriteLine($"Product: {product.GetType().Name}");
                        Console.WriteLine();
                    });
        }
    }
}
