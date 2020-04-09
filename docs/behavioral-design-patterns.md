# Behavioral Design Patterns

These patterns solve the problems of effective and safe interaction between program objects.

## Chain of Responsibility

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/chain-of-responsibility-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://www.dofactory.com/net/chain-of-responsibility-design-pattern);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/ChainOfResponsibilityPattern.cs).

## Command

Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/command-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/command);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/CommandPattern.cs).

## Interpreter

Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/interpreter-design-pattern);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/InterpreterPattern.cs).

## Iterator

Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/iterator-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/iterator);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/IteratorPattern.cs).

## Mediator

Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/mediator-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/mediator);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/MediatorPattern.cs).

## Memento

Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/memento-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/memento);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/MementoPattern.cs).

## Observer

Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/observer-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/observer);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/ObserverPattern.cs).

## State

Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/state-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/state);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/StatePattern.cs).

## Strategy

Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/strategy-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/strategy);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/StrategyPattern.cs).

## Template Method

Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/template-method-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/template-method);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/TemplateMethodPattern.cs).

## Visitor

Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.

  * [Text material for reference by dofactory](https://www.dofactory.com/net/visitor-design-pattern);
  * [Text material for reference by Refactoring.Guru](https://refactoring.guru/design-patterns/visitor);
  * [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.Patterns/Behavioral/VisitorPattern.cs).
