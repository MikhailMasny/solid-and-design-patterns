using Masny.Core;
using System;

namespace Masny.SOLID.ISP
{
    public interface IFirstAction
    {
        void Action();
    }

    interface ISecondAction
    {
        void Action();
    }

    interface IThirdAction
    {
        void AnotherAction();
    }

    class SomeClass : IThirdAction
    {
        public void AnotherAction()
        {
            Console.WriteLine($"{nameof(SomeClass)} {nameof(AnotherAction)}");
        }
    }

    class AnoterClass : IFirstAction, ISecondAction, IThirdAction
    {
        void IFirstAction.Action()
        {
            Console.WriteLine($"{nameof(AnoterClass)} This is IFirstAction.");
        }

        void ISecondAction.Action()
        {
            Console.WriteLine($"{nameof(AnoterClass)} This is ISecondAction.");
        }

        public void AnotherAction()
        {
            Console.WriteLine($"{nameof(AnoterClass)} {nameof(AnotherAction)}");
        }
    }

    public class InterfaceSegregationPrinciple : IExample
    {
        public void Start()
        {
            var someClass = new SomeClass();
            someClass.AnotherAction();

            Console.Write(Environment.NewLine);

            var anotherClass = new AnoterClass();
            anotherClass.AnotherAction();

            Console.Write(Environment.NewLine);

            IFirstAction anotherClassWithFirstAction = new AnoterClass();
            anotherClassWithFirstAction.Action();

            Console.Write(Environment.NewLine);

            ISecondAction anotherClassWithSecondAction = new AnoterClass();
            anotherClassWithSecondAction.Action();
        }
    }
}
