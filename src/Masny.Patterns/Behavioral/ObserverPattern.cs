using System;
using System.Collections.Generic;

namespace Masny.Patterns.Behavioral.Observer
{
    interface IObserver
    {
        void Update();
    }

    class ConcreteObserver : IObserver
    {
        private readonly string _name;
        private readonly ConcreteSubject _subject;
        private string _observerState;

        public ConcreteObserver(ConcreteSubject subject,
                                string name)
        {
            _subject = subject;
            _name = name;
        }

        public void Update()
        {
            _observerState = _subject.SubjectState;

            Console.WriteLine($"Now state is {_observerState} of {_name}. DateTime {DateTime.Now}");
        }
    }

    interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        public void Notify();
    }

    class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public string SubjectState { get; set; }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }
    }

    public class ObserverPattern
    {
        public void Start()
        {
            var subject = new ConcreteSubject();

            var firstConcreteObserver = new ConcreteObserver(subject, "First");
            var secondConcreteObserver = new ConcreteObserver(subject, "Second");

            subject.Attach(firstConcreteObserver);
            subject.Attach(secondConcreteObserver);

            subject.SubjectState = "FirstState";
            subject.Notify();

            subject.Detach(secondConcreteObserver);

            subject.SubjectState = "SecondState";
            subject.Notify();
        }
    }
}
