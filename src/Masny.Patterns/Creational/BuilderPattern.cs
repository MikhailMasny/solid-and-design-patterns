using Masny.Core;
using System;
using System.Collections.Generic;

namespace Masny.Patterns.Creational.Builder
{
    class Product
    {
        private readonly List<string> _parts;

        public string Name { get; set; }

        public Product()
        {
            _parts = new List<string>();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine("-------");

            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }

    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void SetName();
        Product GetResult();
    }

    class ConcreteBuilder1 : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add($"{nameof(ConcreteBuilder1)}. {nameof(BuildPartA)}");
        }

        public void BuildPartB()
        {
            _product.Add($"{nameof(ConcreteBuilder1)}. {nameof(BuildPartB)}");
        }

        public void SetName()
        {
            _product.Name = nameof(ConcreteBuilder1);
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add($"{nameof(ConcreteBuilder2)}. {nameof(BuildPartA)}");
        }

        public void BuildPartB()
        {
            _product.Add($"{nameof(ConcreteBuilder2)}. {nameof(BuildPartB)}");
        }

        public void SetName()
        {
            _product.Name = Guid.NewGuid().ToString();
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.SetName();
        }
    }

    public class BuilderPattern : IExample
    {
        public void Start()
        {
            var director = new Director();

            IBuilder b1 = new ConcreteBuilder1();
            IBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            Console.WriteLine();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
        }
    }
}
