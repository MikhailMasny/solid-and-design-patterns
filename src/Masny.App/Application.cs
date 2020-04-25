using Masny.Common;
using Masny.Core;
using System;

namespace Masny.ConsoleApp
{
    public class Application
    {
        public void Start()
        {
            Display.Start();
            Choice();
        }

        private void Choice()
        {
            Console.Write("\nMake your choice: ");
            var input = Console.ReadLine();
            Command(input);
        }

        private void Command(string command)
        {
            var implementation = new Implementation();
            Console.Clear();

            switch (command)
            {
                #region Main menu

                case "e":
                case "exit":
                    {
                        Environment.Exit(0);
                    }
                    break;

                case "s":
                case "solid":
                    {
                        Display.Solid();
                    }
                    break;

                case "p":
                case "patterns":
                    {
                        Display.Pattern();

                    }
                    break;

                #endregion Main menu

                #region Design Patterns (Types)

                case "behavioral":
                    {
                        Display.Behavioral();
                    }
                    break;

                case "creational":
                    {
                        Display.Creational();
                    }
                    break;

                case "structural":
                    {
                        Display.Structural();
                    }
                    break;

                #endregion Design Patterns (Types)

                #region SOLID Principles

                case "srp":
                case "SRP":
                    {
                        implementation.GetSingleResponsibilityPrincipleInstance().RunAtConsole();
                    }
                    break;

                case "ocp":
                case "OCP":
                    {
                        implementation.GetOpenClosedPrincipleInstance().RunAtConsole();
                    }
                    break;

                case "lsp":
                case "LSP":
                    {
                        implementation.GetLiskovSubstitutionPrincipleInstance().RunAtConsole();
                    }
                    break;

                case "isp":
                case "ISP":
                    {
                        implementation.GetInterfaceSegregationPrincipleInstance().RunAtConsole();
                    }
                    break;

                case "dip":
                case "DIP":
                    {
                        implementation.GetDependencyInversionPrincipleInstance().RunAtConsole();
                    }
                    break;

                #endregion SOLID Principles

                #region Design Patters

                case "chain":
                    {
                        implementation.GetChainOfResponsibilityPatternInstance().RunAtConsole();
                    }
                    break;

                case "command":
                    {
                        implementation.GetCommandPatternInstance().RunAtConsole();
                    }
                    break;

                case "interpreter":
                    {
                        implementation.GetInterpreterPatternInstance().RunAtConsole();
                    }
                    break;

                case "iterator":
                    {
                        implementation.GetIteratorPatternInstance().RunAtConsole();
                    }
                    break;

                case "mediator":
                    {
                        implementation.GetMediatorPatternInstance().RunAtConsole();
                    }
                    break;

                case "memento":
                    {
                        implementation.GetMementoPatternInstance().RunAtConsole();
                    }
                    break;

                case "observer":
                    {
                        implementation.GetObserverPatternInstance().RunAtConsole();
                    }
                    break;

                case "state":
                    {
                        implementation.GetStatePatternInstance().RunAtConsole();
                    }
                    break;

                case "strategy":
                    {
                        implementation.GetStrategyPatternInstance().RunAtConsole();
                    }
                    break;

                case "template":
                    {
                        implementation.GetTemplateMethodPatternInstance().RunAtConsole();
                    }
                    break;

                case "visitor":
                    {
                        implementation.GetVisitorPatternInstance().RunAtConsole();
                    }
                    break;

                case "abstract":
                    {
                        implementation.GetAbstractFactoryPatternInstance().RunAtConsole();
                    }
                    break;

                case "builder":
                    {
                        implementation.GetBuilderPatternInstance().RunAtConsole();
                    }
                    break;

                case "factory":
                    {
                        implementation.GetFactoryPatternInstance().RunAtConsole();
                    }
                    break;

                case "prototype":
                    {
                        implementation.GetPrototypePatternInstance().RunAtConsole();
                    }
                    break;

                case "singleton":
                    {
                        implementation.GetSingletonPatternInstance().RunAtConsole();
                    }
                    break;

                case "adapter":
                    {
                        implementation.GetAdapterPatternInstance().RunAtConsole();
                    }
                    break;

                case "bridge":
                    {
                        implementation.GetBridgePatternInstance().RunAtConsole();
                    }
                    break;

                case "composite":
                    {
                        implementation.GetCompositePatternInstance().RunAtConsole();
                    }
                    break;

                case "decorator":
                    {
                        implementation.GetDecoratorPatternInstance().RunAtConsole();
                    }
                    break;

                case "facade":
                    {
                        implementation.GetFacadePatternInstance().RunAtConsole();
                    }
                    break;

                case "flyweight":
                    {
                        implementation.GetFlyweightPatternInstance().RunAtConsole();
                    }
                    break;

                case "proxy":
                    {
                        implementation.GetProxyPatternInstance().RunAtConsole();
                    }
                    break;

                #endregion Design Patters

                #region Exception (Default)

                default:
                    {
                        Display.Error();
                    }
                    break;

                    #endregion Exception (Default)
            }

            Choice();
        }
    }
}
