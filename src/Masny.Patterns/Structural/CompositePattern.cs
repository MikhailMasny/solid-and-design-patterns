using Masny.Core;
using System;
using System.Collections.Generic;

namespace Masny.Patterns.Structural.Composite
{
    interface IComponent
    {
        string Name { get; set; }
        void Add(IComponent component);
        void Remove(IComponent component);
        void Display(int depth);
    }

    class Composite : IComponent
    {
        private readonly List<IComponent> _children = new List<IComponent>();

        public string Name { get; set; }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }

    class Leaf : IComponent
    {
        public string Name { get; set; }

        public void Add(IComponent c)
        {
            Console.WriteLine($"Cannot add to a leaf, component - {c.Name}");
        }

        public void Remove(IComponent c)
        {
            Console.WriteLine($"Cannot remove from a leaf, component - {c.Name}");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }

    public class CompositePattern : IExample
    {
        public void Start()
        {
            var root = new Composite { Name = "root" };
            var leafA = new Leaf { Name = "Leaf A" };
            var leafB = new Leaf { Name = "Leaf B" };

            root.Add(leafA);
            root.Add(leafB);

            var comp = new Composite { Name = "Composite X" };

            var leafXA = new Leaf { Name = "Leaf XA" };
            var leafXB = new Leaf { Name = "Leaf XB" };

            comp.Add(leafXA);
            comp.Add(leafXB);

            root.Add(comp);

            var leafC = new Leaf { Name = "Leaf C" };
            root.Add(leafC);

            var leafD = new Leaf { Name = "Leaf D" };
            root.Add(leafD);
            root.Remove(leafD);

            root.Display(1);
        }
    }
}
