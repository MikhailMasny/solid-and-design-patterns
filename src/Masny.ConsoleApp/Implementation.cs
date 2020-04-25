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

namespace Masny.ConsoleApp
{
    public class Implementation
    {
        public IExample GetSingleResponsibilityPrincipleInstance()
        {
            return new SingleResponsibilityPrinciple();
        }

        public IExample GetOpenClosedPrincipleInstance()
        {
            return new OpenClosedPrinciple();
        }

        public IExample GetLiskovSubstitutionPrincipleInstance()
        {
            return new LiskovSubstitutionPrinciple();
        }

        public IExample GetInterfaceSegregationPrincipleInstance()
        {
            return new InterfaceSegregationPrinciple();
        }

        public IExample GetDependencyInversionPrincipleInstance()
        {
            return new DependencyInversionPrinciple();
        }

        public IExample GetChainOfResponsibilityPatternInstance()
        {
            return new ChainOfResponsibilityPattern();
        }

        public IExample GetCommandPatternInstance()
        {
            return new CommandPattern();
        }

        public IExample GetInterpreterPatternInstance()
        {
            return new InterpreterPattern();
        }

        public IExample GetIteratorPatternInstance()
        {
            return new IteratorPattern();
        }

        public IExample GetMediatorPatternInstance()
        {
            return new MediatorPattern();
        }

        public IExample GetMementoPatternInstance()
        {
            return new MementoPattern();
        }

        public IExample GetObserverPatternInstance()
        {
            return new ObserverPattern();
        }

        public IExample GetStatePatternInstance()
        {
            return new StatePattern();
        }

        public IExample GetStrategyPatternInstance()
        {
            return new StrategyPattern();
        }

        public IExample GetTemplateMethodPatternInstance()
        {
            return new TemplateMethodPattern();
        }

        public IExample GetVisitorPatternInstance()
        {
            return new VisitorPattern();
        }

        public IExample GetAbstractFactoryPatternInstance()
        {
            return new AbstractFactoryPattern();
        }

        public IExample GetBuilderPatternInstance()
        {
            return new BuilderPattern();
        }

        public IExample GetFactoryPatternInstance()
        {
            return new FactoryPattern();
        }

        public IExample GetPrototypePatternInstance()
        {
            return new PrototypePattern();
        }

        public IExample GetSingletonPatternInstance()
        {
            return new SingletonPattern();
        }

        public IExample GetAdapterPatternInstance()
        {
            return new AdapterPattern();
        }

        public IExample GetBridgePatternInstance()
        {
            return new BridgePattern();
        }

        public IExample GetCompositePatternInstance()
        {
            return new CompositePattern();
        }

        public IExample GetDecoratorPatternInstance()
        {
            return new DecoratorPattern();
        }

        public IExample GetFacadePatternInstance()
        {
            return new FacadePattern();
        }

        public IExample GetFlyweightPatternInstance()
        {
            return new FlyweightPattern();
        }

        public IExample GetProxyPatternInstance()
        {
            return new ProxyPattern();
        }
    }
}
