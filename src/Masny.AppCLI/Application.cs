using Masny.Common;
using Masny.Core;

namespace Masny.AppCLI
{
    public class Application
    {
        public void Start(string[] args)
        {
            IExample example;
            var show = new Show();
            var implementation = new Implementation();

            // TODO

            switch (args[0])
            {
                case "-h":
                case "--help":
                    {
                        Display.Help();
                    }
                    break;

                case "-srp":
                case "--single":
                    {
                        example = implementation.GetSingleResponsibilityPrincipleInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-ocp":
                case "--open":
                    {
                        example = implementation.GetOpenClosedPrincipleInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-lsp":
                case "--liskov":
                    {
                        example = implementation.GetLiskovSubstitutionPrincipleInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-isp":
                case "--interface":
                    {
                        example = implementation.GetInterfaceSegregationPrincipleInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "--dip":
                case "--dependency":
                    {
                        example = implementation.GetDependencyInversionPrincipleInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-chn":
                case "--chain":
                    {
                        example = implementation.GetChainOfResponsibilityPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-cmd":
                case "--сommand":
                    {
                        example = implementation.GetCommandPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-int":
                case "--interpreter":
                    {
                        example = implementation.GetInterpreterPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-itr":
                case "--iterator":
                    {
                        example = implementation.GetIteratorPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-mdt":
                case "--mediator":
                    {
                        example = implementation.GetMediatorPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-mmn":
                case "--memento":
                    {
                        example = implementation.GetMementoPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-obs":
                case "--observer":
                    {
                        example = implementation.GetObserverPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-stt":
                case "--state":
                    {
                        example = implementation.GetStatePatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-str":
                case "--strategy":
                    {
                        example = implementation.GetStrategyPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-tmp":
                case "--template":
                    {
                        example = implementation.GetTemplateMethodPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-vst":
                case "--visitor":
                    {
                        example = implementation.GetVisitorPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-abs":
                case "--abstract":
                    {
                        example = implementation.GetAbstractFactoryPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-fct":
                case "--factory":
                    {
                        example = implementation.GetFactoryPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-bld":
                case "--builder":
                    {
                        example = implementation.GetBuilderPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-prt":
                case "--prototype":
                    {
                        example = implementation.GetPrototypePatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-sng":
                case "--singleton":
                    {
                        example = implementation.GetSingletonPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-adp":
                case "--adapter":
                    {
                        example = implementation.GetAdapterPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-brd":
                case "--bridge":
                    {
                        example = implementation.GetBridgePatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-cmp":
                case "--composite":
                    {
                        example = implementation.GetCompositePatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-dcr":
                case "--decorator":
                    {
                        example = implementation.GetDecoratorPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-fcd":
                case "--facade":
                    {
                        example = implementation.GetFacadePatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-flw":
                case "--flyweight":
                    {
                        example = implementation.GetFlyweightPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;

                case "-prx":
                case "--proxy":
                    {
                        example = implementation.GetProxyPatternInstance();
                        show.RunAtCLI(example);
                    }
                    break;
            }
        }
    }
}
