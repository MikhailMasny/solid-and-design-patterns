using Masny.Common;

namespace Masny.AppCLI
{
    public class Application
    {
        public void Start(string[] args)
        {
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
                        implementation.GetSingleResponsibilityPrincipleInstance().RunAtCLI();
                    }
                    break;

                case "-ocp":
                case "--open":
                    {
                        implementation.GetOpenClosedPrincipleInstance().RunAtCLI();
                    }
                    break;

                case "-lsp":
                case "--liskov":
                    {
                        implementation.GetLiskovSubstitutionPrincipleInstance().RunAtCLI();
                    }
                    break;

                case "-isp":
                case "--interface":
                    {
                        implementation.GetInterfaceSegregationPrincipleInstance().RunAtCLI();
                    }
                    break;

                case "--dip":
                case "--dependency":
                    {
                        implementation.GetDependencyInversionPrincipleInstance().RunAtCLI();
                    }
                    break;

                case "-chn":
                case "--chain":
                    {
                        implementation.GetChainOfResponsibilityPatternInstance().RunAtCLI();
                    }
                    break;

                case "-cmd":
                case "--сommand":
                    {
                        implementation.GetCommandPatternInstance().RunAtCLI();
                    }
                    break;

                case "-int":
                case "--interpreter":
                    {
                        implementation.GetInterpreterPatternInstance().RunAtCLI();
                    }
                    break;

                case "-itr":
                case "--iterator":
                    {
                        implementation.GetIteratorPatternInstance().RunAtCLI();
                    }
                    break;

                case "-mdt":
                case "--mediator":
                    {
                        implementation.GetMediatorPatternInstance().RunAtCLI();
                    }
                    break;

                case "-mmn":
                case "--memento":
                    {
                        implementation.GetMementoPatternInstance().RunAtCLI();
                    }
                    break;

                case "-obs":
                case "--observer":
                    {
                        implementation.GetObserverPatternInstance().RunAtCLI();
                    }
                    break;

                case "-stt":
                case "--state":
                    {
                        implementation.GetStatePatternInstance().RunAtCLI();
                    }
                    break;

                case "-str":
                case "--strategy":
                    {
                        implementation.GetStrategyPatternInstance().RunAtCLI();
                    }
                    break;

                case "-tmp":
                case "--template":
                    {
                        implementation.GetTemplateMethodPatternInstance().RunAtCLI();
                    }
                    break;

                case "-vst":
                case "--visitor":
                    {
                        implementation.GetVisitorPatternInstance().RunAtCLI();
                    }
                    break;

                case "-abs":
                case "--abstract":
                    {
                        implementation.GetAbstractFactoryPatternInstance().RunAtCLI();
                    }
                    break;

                case "-fct":
                case "--factory":
                    {
                        implementation.GetFactoryPatternInstance().RunAtCLI();
                    }
                    break;

                case "-bld":
                case "--builder":
                    {
                        implementation.GetBuilderPatternInstance().RunAtCLI();
                    }
                    break;

                case "-prt":
                case "--prototype":
                    {
                        implementation.GetPrototypePatternInstance().RunAtCLI();
                    }
                    break;

                case "-sng":
                case "--singleton":
                    {
                        implementation.GetSingletonPatternInstance().RunAtCLI();
                    }
                    break;

                case "-adp":
                case "--adapter":
                    {
                        implementation.GetAdapterPatternInstance().RunAtCLI();
                    }
                    break;

                case "-brd":
                case "--bridge":
                    {
                        implementation.GetBridgePatternInstance().RunAtCLI();
                    }
                    break;

                case "-cmp":
                case "--composite":
                    {
                        implementation.GetCompositePatternInstance().RunAtCLI();
                    }
                    break;

                case "-dcr":
                case "--decorator":
                    {
                        implementation.GetDecoratorPatternInstance().RunAtCLI();
                    }
                    break;

                case "-fcd":
                case "--facade":
                    {
                        implementation.GetFacadePatternInstance().RunAtCLI();
                    }
                    break;

                case "-flw":
                case "--flyweight":
                    {
                        implementation.GetFlyweightPatternInstance().RunAtCLI();
                    }
                    break;

                case "-prx":
                case "--proxy":
                    {
                        implementation.GetProxyPatternInstance().RunAtCLI();
                    }
                    break;
            }
        }
    }
}
