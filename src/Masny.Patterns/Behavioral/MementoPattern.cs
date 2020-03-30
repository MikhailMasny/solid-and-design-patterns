using System;

namespace Masny.Patterns.Behavioral.MementoPattern
{
    class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"State = {_state}");
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    class Memento
    {
        private readonly string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }

    class Caretaker
    {
        public Memento Memento { set; get; }
    }

    public class MementoPattern
    {
        public void Start()
        {
            Originator originator = new Originator
            {
                State = "On"
            };

            Caretaker caretaker = new Caretaker
            {
                Memento = originator.CreateMemento()
            };

            originator.State = "Off";
            originator.SetMemento(caretaker.Memento);
        }
    }
}
