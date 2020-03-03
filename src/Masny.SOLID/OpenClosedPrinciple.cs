using System;
using System.Collections.Generic;
using System.Linq;

namespace Masny.SOLID.OCP
{
    public abstract class BaseClass
    {
        protected virtual void FirstAction()
        {
            Console.WriteLine($"{nameof(BaseClass)}. {nameof(FirstAction)}.");
        }

        protected virtual void SecondAction()
        {
            Console.WriteLine($"{nameof(BaseClass)}. {nameof(SecondAction)}.");
        }

        public void Run()
        {
            FirstAction();
            SecondAction();
        }
    }

    public class FirstClass : BaseClass { }

    public class SecondClass : BaseClass
    {
        protected override void FirstAction()
        {
            Console.WriteLine("Second class. First action.");
        }

        protected override void SecondAction()
        {
            Console.WriteLine("Second class. Second action.");
        }
    }

    public class SomeClass
    {
        public string Property { get; set; }

        public SomeClass(string property)
        {
            this.Property = property;
        }

        public void Start(IEnumerable<BaseClass> list)
        {
            list.ToList()
                .ForEach(item => item.Run());

            Console.WriteLine($"End of start method. {Property}");
        }
    }

    public class OpenClosedPrinciple
    {
        public void Start()
        {
            IEnumerable<BaseClass> list = new List<BaseClass> { new FirstClass(), new SecondClass() };
            var someClass = new SomeClass("Property from main class!");
            someClass.Start(list);
        }
    }

    // TODO: var OCP = new OpenClosedPrinciple();
    // OCP.Start();
}
