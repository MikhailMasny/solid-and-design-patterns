using System;

namespace Masny.Common
{
    public static class Display
    {
        public static void Start()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("***** Design Patterns & SOLID Principles *****");
            Console.WriteLine("**********************************************");
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Input name of following key:");
            Console.WriteLine("1. `s` or `solid` - show list of SOLID Principles");
            Console.WriteLine("2. `p` or `patterns` - show list of Design Pattern");
            Console.WriteLine("3. `e` or `exit` - exit from the application");
        }

        public static void Error()
        {
            Console.WriteLine("Nonexistent command. Try again..\n");
            Menu();
        }

        public static void Solid()
        {
            Console.WriteLine("Input name of SOLID Principles the following key:");
            Console.WriteLine("1. `srp` or `SRP` - show implementation of Single Responsibility Principle");
            Console.WriteLine("2. `ocp` or `OCP` - show implementation of Open Closed Principle");
            Console.WriteLine("3. `lsp` or `LSP` - show implementation of Liskov Substitution Principle");
            Console.WriteLine("4. `isp` or `ISP` - show implementation of Interface Segregation Principle");
            Console.WriteLine("5. `dip` or `DIP` - show implementation of Dependency Inversion Principle");
        }

        public static void Pattern()
        {
            Console.WriteLine("Input type of design patterns the following key:");
            Console.WriteLine("1. `behavioral` - show list of Behavioral ");
            Console.WriteLine("2. `creational` - show list of Creational design patterns");
            Console.WriteLine("3. `structural` - show list of Structural design patterns");
        }

        public static void Behavioral()
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
        }

        public static void Creational()
        {
            Console.WriteLine("Input name of creational design patterns the following key:");
            Console.WriteLine("1. `abstract` - show implementation of Abstract factory Pattern");
            Console.WriteLine("2. `factory` - show implementation of Factory Pattern");
            Console.WriteLine("3. `builder` - show implementation of Builder Pattern");
            Console.WriteLine("4. `prototype` - show implementation of Prototype Pattern");
            Console.WriteLine("5. `singleton` - show implementation of Singleton Pattern");
        }

        public static void Structural()
        {
            Console.WriteLine("Input name of structural design patterns the following key:");
            Console.WriteLine("1. `adapter` - show implementation of Adapter Pattern");
            Console.WriteLine("2. `bridge` - show implementation of Bridge Pattern");
            Console.WriteLine("3. `composite` - show implementation of Composite Pattern");
            Console.WriteLine("4. `decorator` - show implementation of Decorator Pattern");
            Console.WriteLine("5. `facade` - show implementation of Facade Pattern");
            Console.WriteLine("6. `flyweight` - show implementation of Flyweight Pattern");
            Console.WriteLine("7. `proxy` - show implementation of Proxy Pattern");
        }

        public static void Help()
        {
            Console.WriteLine("Usage: [appname].dll [command]");
            Console.WriteLine("\ncommand:");
            Console.WriteLine("  -h|--help            show command line help");
            Console.WriteLine("  -srp|--single        show implementation of Single Responsibility Principle");
            Console.WriteLine("  -ocp|--open          show implementation of Open Closed Principle");
            Console.WriteLine("  -lsp|--liskov        show implementation of Liskov Substitution Principle");
            Console.WriteLine("  -isp|--interface     show implementation of Interface Segregation Principle");
            Console.WriteLine("  -dip|--dependency    show implementation of Dependency Inversion Principle");
            Console.WriteLine("  -chn|--chain         show implementation of Chain of responsibility Pattern");
            Console.WriteLine("  -cmd|--сommand       show implementation of Command Pattern");
            Console.WriteLine("  -int|--interpreter   show implementation of Interpreter Pattern");
            Console.WriteLine("  -itr|--iterator      show implementation of Iterator Pattern");
            Console.WriteLine("  -mdt|--mediator      show implementation of Mediator Pattern");
            Console.WriteLine("  -mmn|--memento       show implementation of Memento Pattern");
            Console.WriteLine("  -obs|--observer      show implementation of Observer Pattern");
            Console.WriteLine("  -stt|--state         show implementation of State Pattern");
            Console.WriteLine("  -str|--strategy      show implementation of Strategy Pattern");
            Console.WriteLine("  -tmp|--template      show implementation of Template method Pattern");
            Console.WriteLine("  -vst|--visitor       show implementation of Visitor Pattern");
            Console.WriteLine("  -abs|--abstract      show implementation of Abstract factory Pattern");
            Console.WriteLine("  -fct|--factory       show implementation of Factory Pattern");
            Console.WriteLine("  -bld|--builder       show implementation of Builder Pattern");
            Console.WriteLine("  -prt|--prototype     show implementation of Prototype Pattern");
            Console.WriteLine("  -sng|--singleton     show implementation of Singleton Pattern");
            Console.WriteLine("  -adp|--adapter       show implementation of Adapter Pattern");
            Console.WriteLine("  -brd|--bridge        show implementation of Bridge Pattern");
            Console.WriteLine("  -cmp|--composite     show implementation of Composite Pattern");
            Console.WriteLine("  -dcr|--decorator     show implementation of Decorator Pattern");
            Console.WriteLine("  -fcd|--facade        show implementation of Facade Pattern");
            Console.WriteLine("  -flw|--flyweight     show implementation of Flyweight Pattern");
            Console.WriteLine("  -prx|--proxy         show implementation of Proxy Pattern");
        }
    }
}
