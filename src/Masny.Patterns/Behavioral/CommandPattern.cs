using System;

namespace Masny.Patterns.Behavioral.Command
{
    interface ICommand
    {
        void Execute();
    }

    class ConcreteCommand : ICommand
    {
        public Receiver Receiver { get; set; }

        public void Execute()
        {
            Receiver.Action();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine($"Called {nameof(Receiver)}.{nameof(Action)}()");
        }
    }

    class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }

    public class CommandPattern
    {
        public void Start()
        {
            var invoker = new Invoker();
            var receiver = new Receiver();

            ICommand command = new ConcreteCommand
            {
                Receiver = receiver
            };
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
