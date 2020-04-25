using Masny.Core;
using System;

namespace Masny.Patterns.Creational.Prototype
{
    class AnotherClass
    {
        public int SomeField;

        public AnotherClass(int someField)
        {
            SomeField = someField;
        }
    }

    class ConcreteClass
    {
        public int FirstProp { get; set; }
        public string SecondProp { get; set; }
        public AnotherClass AnotherClass { get; set; }

        public ConcreteClass ShallowCopy()
        {
            return (ConcreteClass)MemberwiseClone();
        }

        public ConcreteClass DeepCopy()
        {
            var clone = (ConcreteClass)MemberwiseClone();
            clone.AnotherClass = new AnotherClass(AnotherClass.SomeField);
            
            return clone;
        }
    }

    public class PrototypePattern : IExample
    {
        public void Start()
        {
            var concreteClass = new ConcreteClass
            {
                FirstProp = 111,
                SecondProp = "Text",
                AnotherClass = new AnotherClass(222)
            };

            DisplayObject(nameof(concreteClass), concreteClass);

            ConcreteClass shallowCopy = concreteClass.ShallowCopy();
            DisplayObject(nameof(shallowCopy), shallowCopy);

            concreteClass.SecondProp = "AnotherText";
            concreteClass.AnotherClass.SomeField = 333;
            DisplayObject(nameof(shallowCopy), shallowCopy);

            ConcreteClass deepCopy = concreteClass.DeepCopy();

            concreteClass.AnotherClass.SomeField = 444;
            DisplayObject(nameof(deepCopy), deepCopy);
            DisplayObject(nameof(concreteClass), concreteClass);
        }

        private void DisplayObject(string name, ConcreteClass obj)
        {
            Console.WriteLine($"{name}: {obj.FirstProp} {obj.SecondProp} {obj.AnotherClass.SomeField}");
            Console.WriteLine("---------------------");
        }
    }
}
