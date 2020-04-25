using System;

namespace Masny.ConsoleApp
{
    public class Display
    {
        public void Start()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("***** Design Patterns & SOLID Principles *****");
            Console.WriteLine("**********************************************");
            Menu();
        }

        private void Choice()
        {
            Console.Write("\nMake your choice: ");
            var input = Console.ReadLine();
            Command(input);
        }

        private void Menu()
        {
            Console.WriteLine("Input name of following key:");
            Console.WriteLine("1. `solid` - show list of SOLID Principles");
            Console.WriteLine("2. `patterns` - show list of Design Pattern");

            Choice();
        }

        private void Solid()
        {
            Console.WriteLine("Input name of SOLID Principles the following key:");
            Console.WriteLine("1. `SRP` - show implementation of Single Responsibility Principle");
            Console.WriteLine("2. `OCP` - show implementation of Open Closed Principle");
            Console.WriteLine("3. `LSP` - show implementation of Liskov Substitution Principle");
            Console.WriteLine("4. `ISP` - show implementation of Interface Segregation Principle");
            Console.WriteLine("5. `DIP` - show implementation of Dependency Inversion Principle");

            Choice();
        }

        private void Pattern()
        {
            Console.WriteLine("Input type of design patterns the following key:");
            Console.WriteLine("1. `behavioral` - show list of Behavioral ");
            Console.WriteLine("2. `creational` - show list of Creational design patterns");
            Console.WriteLine("3. `structural` - show list of Structural design patterns");

            Choice();
        }

        private void Behavioral()
        {
            Console.WriteLine("Input name of behavioral design patterns the following key:");
            Console.WriteLine("1. `chain` - show implementation of Chain of responsibility Pattern");
            Console.WriteLine("2. `сommand` - show implementation of Command Pattern");
            Console.WriteLine("3. `interpreter` - show implementation of Interpreter Pattern");
            Console.WriteLine("4. `iterator` - show implementation of Iterator Pattern");
            Console.WriteLine("5. `mediator` - show implementation of Mediator Pattern");
            Console.WriteLine("6. `memento` - show implementation of Memento Pattern");
            Console.WriteLine("7. `observer` - show implementation of Observer Pattern");
            Console.WriteLine("8. `state` - show implementation of State Pattern");
            Console.WriteLine("9. `strategy` - show implementation of Strategy Pattern");
            Console.WriteLine("10. `template` - show implementation of Template method Pattern");
            Console.WriteLine("11. `visitor` - show implementation of Visitor Pattern");

            Choice();
        }

        private void Creational()
        {
            Console.WriteLine("Input name of creational design patterns the following key:");
            Console.WriteLine("1. `abstract` - show implementation of Abstract factory Pattern");
            Console.WriteLine("2. `factory` - show implementation of Factory Pattern");
            Console.WriteLine("3. `builder` - show implementation of Builder Pattern");
            Console.WriteLine("4. `prototype` - show implementation of Prototype Pattern");
            Console.WriteLine("5. `singleton` - show implementation of Singleton Pattern");

            Choice();
        }

        private void Structural()
        {
            Console.WriteLine("Input name of structural design patterns the following key:");
            Console.WriteLine("1. `adapter` - show implementation of Adapter Pattern");
            Console.WriteLine("2. `bridge` - show implementation of Bridge Pattern");
            Console.WriteLine("3. `composite` - show implementation of Composite Pattern");
            Console.WriteLine("4. `decorator` - show implementation of Decorator Pattern");
            Console.WriteLine("5. `facade` - show implementation of Facade Pattern");
            Console.WriteLine("6. `flyweight` - show implementation of Flyweight Pattern");
            Console.WriteLine("7. `proxy` - show implementation of Proxy Pattern");

            Choice();
        }

        private void Run() 
        {
        }

        private void Command(string command)
        {
            Console.Clear();

            switch (command)
            {
                case "-h":
                case "--help":
                    {

                    } 
                    break;

                case "menu":
                    {
                        Menu();
                    }
                    break;

                case "exit":
                    {

                    }
                    break;

                case "solid":
                    {
                        Solid();
                    } 
                    break;

                case "patterns":
                    {
                        Pattern();
                    }
                    break;

                #region Design Patterns

                case "behavioral":
                    {
                        Behavioral();
                    }
                    break;

                case "creational":
                    {
                        Creational();
                    }
                    break;

                case "structural":
                    {
                        Structural();
                    }
                    break;
                #endregion Design Patterns

                #region SOLID Principles
                case "--srp":
                case "SRP":
                    {
                    }
                    break;

                case "--ocp":
                case "OCP":
                    {
                    }
                    break;

                case "--lsp":
                case "LSP":
                    {
                    }
                    break;

                case "--isp":
                case "ISP":
                    {
                    }
                    break;

                case "--dip":
                case "DIP":
                    {

                    }
                    break;

                #endregion SOLID

                default:
                    break;
            }
        }
    }
}
