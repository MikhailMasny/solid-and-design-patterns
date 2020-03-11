using System;

namespace Masny.Patterns.Behavioral.TemplateMethod
{
    abstract class AbstractClass
    {
        public abstract void Operation1();
        public abstract void Operation2();

        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
    }

    class ConcreteClass1 : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine($"{nameof(ConcreteClass1)}.{nameof(Operation1)}()");
        }
        public override void Operation2()
        {
            Console.WriteLine($"{nameof(ConcreteClass1)}.{nameof(Operation2)}()");
        }
    }

    class ConcreteClass2 : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine($"{nameof(ConcreteClass2)}.{nameof(Operation1)}()");
        }
        public override void Operation2()
        {
            Console.WriteLine($"{nameof(ConcreteClass2)}.{nameof(Operation2)}()");
        }
    }

    public class TemplateMethodPattern
    {
        public void Start()
        {
            AbstractClass concreteClass1 = new ConcreteClass1();
            concreteClass1.TemplateMethod();

            Console.WriteLine(new string('-', 27));

            AbstractClass concreteClass2 = new ConcreteClass2();
            concreteClass2.TemplateMethod();
        }
    }
}
