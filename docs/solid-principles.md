# SOLID Principles

SOLID principles are the design principles that enable us to manage most of the software design problems. Robert C. Martin compiled these principles in the 1990s. These principles provide us with ways to move from tightly coupled code and little encapsulation to the desired results of loosely coupled and encapsulated real needs of a business properly.

## SOLID is an acronym of the following.

- S: Single Responsibility Principle (**SRP**)
- O: Open closed Principle (**OSP**)
- L: Liskov substitution Principle (**LSP**)
- I: Interface Segregation Principle (**ISP**)
- D: Dependency Inversion Principle (**DIP**)

### Single Responsibility Principle

The Single Responsibility Principle states that every software module should have only one reason to change. [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.SOLID/SingleResponsibilityPrinciple.cs).

### Open closed Principle

The Open/closed Principle states that software module/class is open for extension and closed for modification. [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.SOLID/OpenClosedPrinciple.cs).

### Liskov Substitution Principle

The Liskov Substitution Principle (LSP) states that "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification". It ensures that a derived class does not affect the behavior of the parent class, in other words, that a derived class must be substitutable for its base class. [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.SOLID/LiskovSubstitutionPrinciple.cs).

### Interface Segregation Principle

The Interface Segregation Principle states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, many small interfaces are preferred based on groups of methods, each one serving one submodule". [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.SOLID/InterfaceSegregationPrinciple.cs).

### Dependency Inversion Principle

The Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions. [Implementation here](https://github.com/MikhailMasny/solid-and-design-patterns/blob/master/src/Masny.SOLID/DependencyInversionPrinciple.cs).
