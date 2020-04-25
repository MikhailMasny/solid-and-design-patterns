using Masny.Core;
using System;
using System.Collections;

namespace Masny.Patterns.Behavioral.Iterator
{
    interface IAggregate
    {
        IIterator CreateIterator();
    }

    class ConcreteAggregate : IAggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

    interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }

    class ConcreteIterator : IIterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public object First()
        {
            return _aggregate[0];
        }

        public object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current >= _aggregate.Count-1;
        }
    }

    public class IteratorPattern : IExample
    {
        public void Start()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "First element";
            a[1] = "Second element";
            a[2] = "Third element";

            IIterator i = a.CreateIterator();

            Console.WriteLine("Collection is:");

            object item = i.First();

            while (item != null)
            {
                Console.WriteLine($"- {item}");
                item = i.Next();
            }

            Console.WriteLine($"\nCurrent item: {i.CurrentItem()}");
            Console.WriteLine($"Is done: {i.IsDone()}");
        }
    }
}
