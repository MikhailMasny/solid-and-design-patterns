using Masny.Core;
using System;

namespace Masny.ConsoleApp
{
    public class AppClassic
    {
        public void Start()
        {
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
                        show.RunAtApp(example);
                    }
                    break;

                case "ocp":
                case "OCP":
                    {
                        example = implementation.GetOpenClosedPrincipleInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "lsp":
                case "LSP":
                    {
                        example = implementation.GetLiskovSubstitutionPrincipleInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "isp":
                case "ISP":
                    {
                        example = implementation.GetInterfaceSegregationPrincipleInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "dip":
                case "DIP":
                    {
                        example = implementation.GetDependencyInversionPrincipleInstance();
                        show.RunAtApp(example);
                    }
                    break;

                #endregion SOLID Principles

                #region Design Patters

                case "chain":
                    {
                        example = implementation.GetChainOfResponsibilityPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "command":
                    {
                        example = implementation.GetCommandPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "interpreter":
                    {
                        example = implementation.GetInterpreterPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "iterator":
                    {
                        example = implementation.GetIteratorPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "mediator":
                    {
                        example = implementation.GetMediatorPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "memento":
                    {
                        example = implementation.GetMementoPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "observer":
                    {
                        example = implementation.GetObserverPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "state":
                    {
                        example = implementation.GetStatePatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "strategy":
                    {
                        example = implementation.GetStrategyPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "template":
                    {
                        example = implementation.GetTemplateMethodPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "visitor":
                    {
                        example = implementation.GetVisitorPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "abstract":
                    {
                        example = implementation.GetAbstractFactoryPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "builder":
                    {
                        example = implementation.GetBuilderPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "factory":
                    {
                        example = implementation.GetFactoryPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "prototype":
                    {
                        example = implementation.GetPrototypePatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "singleton":
                    {
                        example = implementation.GetSingletonPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "adapter":
                    {
                        example = implementation.GetAdapterPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "bridge":
                    {
                        example = implementation.GetBridgePatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "composite":
                    {
                        example = implementation.GetCompositePatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "decorator":
                    {
                        example = implementation.GetDecoratorPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "facade":
                    {
                        example = implementation.GetFacadePatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "flyweight":
                    {
                        example = implementation.GetFlyweightPatternInstance();
                        show.RunAtApp(example);
                    }
                    break;

                case "proxy":
                    {
                        example = implementation.GetProxyPatternInstance();
                        show.RunAtApp(example);
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
