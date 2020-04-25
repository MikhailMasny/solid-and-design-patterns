using Masny.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.SOLID.OCP
{
    abstract class BaseClass
    {
        protected virtual void FirstAction()
        {
            Console.WriteLine($"{nameof(BaseClass)}. {nameof(FirstAction)}.");
        }

        protected virtual void SecondAction()
        {
            Console.WriteLine($"{nameof(BaseClass)}. {nameof(SecondAction)}.");
        }

        public void Do()
        {
            FirstAction();
            SecondAction();
        }
    }

    class FirstClass : BaseClass { }

    class SecondClass : BaseClass
    {
        protected override void FirstAction()
        {
            Console.WriteLine("Some text before.");
            base.FirstAction();
        }

        protected override void SecondAction()
        {
            base.SecondAction();
            Console.WriteLine("Some text after.");
        }
    }

    class ThirdClass : BaseClass
    {
        protected override void FirstAction()
        {
            Console.WriteLine("Third class. First action.");
        }

        protected override void SecondAction()
        {
            Console.WriteLine("Third class. Second action.");
        }
    }

    class SomeClass
    {
        public string Property { get; set; }

        public SomeClass(string property)
        {
            this.Property = property;
        }

        public void Run(IEnumerable<BaseClass> list)
        {
            list.ToList()
                .ForEach(item =>
                {
                    item.Do();
                    Console.WriteLine();
                });

            Console.WriteLine($"End of start method. {Property}");
        }
    }

    public class OpenClosedPrinciple : IExample
    {
        public void Start()
        {
            IEnumerable<BaseClass> list = new List<BaseClass> { new FirstClass(), new SecondClass(), new ThirdClass() };
            var someClass = new SomeClass("Property from main class!");
            someClass.Run(list);
        }
    }
}
