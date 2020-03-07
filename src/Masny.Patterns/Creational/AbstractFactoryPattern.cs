using System;

namespace Masny.Patterns.Creational.AbstractFactory
{
    interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    interface IAbstractProductA
    {
    }

    interface IAbstractProductB
    {
        void Interact(IAbstractProductA product);
    }

    class ProductA1 : IAbstractProductA
    {
    }

    class ProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA product)
        {
            Console.WriteLine($"Product set: {product.GetType().Name} and {GetType().Name}");
        }
    }

    class ProductA2 : IAbstractProductA
    {
    }

    class ProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA product)
        {
            Console.WriteLine($"Product set: {product.GetType().Name} and {GetType().Name}");
        }
    }

    class Client
    {
        private readonly IAbstractProductA _abstractProductA;
        private readonly IAbstractProductB _abstractProductB;

        public Client(IAbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }

    public class AbstractFactoryPattern
    {
        public void Start()
        {
            IAbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            IAbstractFactory factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();
        }
    }
}
