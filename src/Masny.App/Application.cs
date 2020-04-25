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
            IExample example;
            var show = new Show();
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
                        example = implementation.GetSingleResponsibilityPrincipleInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "ocp":
                case "OCP":
                    {
                        example = implementation.GetOpenClosedPrincipleInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "lsp":
                case "LSP":
                    {
                        example = implementation.GetLiskovSubstitutionPrincipleInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "isp":
                case "ISP":
                    {
                        example = implementation.GetInterfaceSegregationPrincipleInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "dip":
                case "DIP":
                    {
                        example = implementation.GetDependencyInversionPrincipleInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                #endregion SOLID Principles

                #region Design Patters

                case "chain":
                    {
                        example = implementation.GetChainOfResponsibilityPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "command":
                    {
                        example = implementation.GetCommandPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "interpreter":
                    {
                        example = implementation.GetInterpreterPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "iterator":
                    {
                        example = implementation.GetIteratorPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "mediator":
                    {
                        example = implementation.GetMediatorPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "memento":
                    {
                        example = implementation.GetMementoPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "observer":
                    {
                        example = implementation.GetObserverPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "state":
                    {
                        example = implementation.GetStatePatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "strategy":
                    {
                        example = implementation.GetStrategyPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "template":
                    {
                        example = implementation.GetTemplateMethodPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "visitor":
                    {
                        example = implementation.GetVisitorPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "abstract":
                    {
                        example = implementation.GetAbstractFactoryPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "builder":
                    {
                        example = implementation.GetBuilderPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "factory":
                    {
                        example = implementation.GetFactoryPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "prototype":
                    {
                        example = implementation.GetPrototypePatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "singleton":
                    {
                        example = implementation.GetSingletonPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "adapter":
                    {
                        example = implementation.GetAdapterPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "bridge":
                    {
                        example = implementation.GetBridgePatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "composite":
                    {
                        example = implementation.GetCompositePatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "decorator":
                    {
                        example = implementation.GetDecoratorPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "facade":
                    {
                        example = implementation.GetFacadePatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "flyweight":
                    {
                        example = implementation.GetFlyweightPatternInstance();
                        show.RunAtConsole(example);
                    }
                    break;

                case "proxy":
                    {
                        example = implementation.GetProxyPatternInstance();
                        show.RunAtConsole(example);
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
