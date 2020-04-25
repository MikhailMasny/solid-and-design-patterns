using Masny.Core;
using Masny.Patterns.Behavioral.ChainOfResponsibility;
using Masny.Patterns.Behavioral.Command;
using Masny.Patterns.Behavioral.Interpreter;
using Masny.Patterns.Behavioral.Iterator;
using Masny.Patterns.Behavioral.Mediator;
using Masny.Patterns.Behavioral.MementoPattern;
using Masny.Patterns.Behavioral.Observer;
using Masny.Patterns.Behavioral.State;
using Masny.Patterns.Behavioral.Strategy;
using Masny.Patterns.Behavioral.TemplateMethod;
using Masny.Patterns.Behavioral.Visitor;
using Masny.Patterns.Creational.AbstractFactory;
using Masny.Patterns.Creational.Builder;
using Masny.Patterns.Creational.Factory;
using Masny.Patterns.Creational.Prototype;
using Masny.Patterns.Creational.Singleton;
using Masny.Patterns.Structural.Adapter;
using Masny.Patterns.Structural.Bridge;
using Masny.Patterns.Structural.Composite;
using Masny.Patterns.Structural.Decorator;
using Masny.Patterns.Structural.Facade;
using Masny.Patterns.Structural.Flyweight;
using Masny.Patterns.Structural.Proxy;
using Masny.SOLID.DIP;
using Masny.SOLID.ISP;
using Masny.SOLID.LSP;
using Masny.SOLID.OCP;
using Masny.SOLID.SRP;
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
                        example = new SingleResponsibilityPrinciple();
                        show.RunAtApp(example);
                    }
                    break;

                case "ocp":
                case "OCP":
                    {
                        example = new OpenClosedPrinciple();
                        show.RunAtApp(example);
                    }
                    break;

                case "lsp":
                case "LSP":
                    {
                        example = new LiskovSubstitutionPrinciple();
                        show.RunAtApp(example);
                    }
                    break;

                case "isp":
                case "ISP":
                    {
                        example = new InterfaceSegregationPrinciple();
                        show.RunAtApp(example);
                    }
                    break;

                case "dip":
                case "DIP":
                    {
                        example = new DependencyInversionPrinciple();
                        show.RunAtApp(example);
                    }
                    break;

                #endregion SOLID Principles

                #region Design Patters

                case "chain":
                    {
                        example = new ChainOfResponsibilityPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "command":
                    {
                        example = new CommandPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "interpreter":
                    {
                        example = new InterpreterPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "iterator":
                    {
                        example = new IteratorPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "mediator":
                    {
                        example = new MediatorPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "memento":
                    {
                        example = new MementoPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "observer":
                    {
                        example = new ObserverPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "state":
                    {
                        example = new StatePattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "strategy":
                    {
                        example = new StrategyPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "template":
                    {
                        example = new TemplateMethodPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "visitor":
                    {
                        example = new VisitorPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "abstract":
                    {
                        example = new AbstractFactoryPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "builder":
                    {
                        example = new BuilderPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "factory":
                    {
                        example = new FactoryPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "prototype":
                    {
                        example = new PrototypePattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "singleton":
                    {
                        example = new SingletonPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "adapter":
                    {
                        example = new AdapterPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "bridge":
                    {
                        example = new BridgePattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "composite":
                    {
                        example = new CompositePattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "decorator":
                    {
                        example = new DecoratorPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "facade":
                    {
                        example = new FacadePattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "flyweight":
                    {
                        example = new FlyweightPattern();
                        show.RunAtApp(example);
                    }
                    break;

                case "proxy":
                    {
                        example = new ProxyPattern();
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
