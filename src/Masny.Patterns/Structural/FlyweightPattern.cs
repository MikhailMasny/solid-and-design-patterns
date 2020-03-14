using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.Patterns.Structural.Flyweight
{
    class SomeObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }

    class Flyweight
    {
        private readonly SomeObject _sharedState;

        public Flyweight(SomeObject someObject)
        {
            _sharedState = someObject;
        }

        public void Operation(SomeObject uniqueState)
        {
            string shared = JsonConvert.SerializeObject(_sharedState);
            string unique = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight: Displaying shared {shared} and unique {unique} state.");
        }
    }

    class FlyweightFactory
    {
        private readonly List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params SomeObject[] args)
        {
            foreach (var elem in args)
            {
                AddFlyweight(elem);
            }
        }

        public Flyweight GetFlyweight(SomeObject someObject)
        {
            var (isExistFlyweight, key) = IsExistFlyweight(someObject);

            if (isExistFlyweight)
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                AddFlyweight(someObject);
            }

            return flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;

            Console.WriteLine($"FlyweightFactory: I have {count} flyweights:");

            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }

        private string GetKey(SomeObject key)
        {
            var elements = new List<string> { key.Name, key.Body };

            elements.Sort();

            return string.Join("_", elements);
        }

        private void AddFlyweight(SomeObject someObject)
        {
            var flyweight = new Flyweight(someObject);
            var key = GetKey(someObject);
            var tupleObject = new Tuple<Flyweight, string>(flyweight, key);

            flyweights.Add(tupleObject);
        }

        private (bool, string) IsExistFlyweight(SomeObject someObject)
        {
            string key = GetKey(someObject);
            var result = flyweights.Where(t => t.Item2 == key).Count() > 0;

            return (result, key);
        }
    }

    public class FlyweightPattern
    {
        public void Start()
        {
            var object1 = new SomeObject { Id = 1, Name = "Name1", Body = "Body1" };
            var object2 = new SomeObject { Id = 2, Name = "Name2", Body = "Body2" };
            var object3 = new SomeObject { Id = 3, Name = "Name3", Body = "Body3" };

            var factory = new FlyweightFactory(object1, object2, object3);
            factory.ListFlyweights();

            var object4 = new SomeObject { Id = 4, Name = "Name4", Body = "Body4" };
            var object5 = new SomeObject { Id = 5, Name = "Name5", Body = "Body5" };

            AddObjectToStorage(factory, object4);
            AddObjectToStorage(factory, object5);

            var object6 = new SomeObject { Id = 6, Name = "Name5", Body = "Body5" };
            AddObjectToStorage(factory, object6);

            Console.WriteLine();

            factory.ListFlyweights();
        }

        private void AddObjectToStorage(FlyweightFactory factory, SomeObject someObject)
        {
            Console.WriteLine("\nNew object adding to virtual storage.");

            var newObject = new SomeObject { Id = someObject.Id, Name = someObject.Name, Body = someObject.Body };
            var flyweight = factory.GetFlyweight(newObject);

            flyweight.Operation(someObject);
        }
    }
}
