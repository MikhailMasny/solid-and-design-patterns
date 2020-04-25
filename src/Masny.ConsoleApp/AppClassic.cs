using Masny.Core;
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

                #region Design Patterns (Type)

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

                #endregion Design Patterns (Type)

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
