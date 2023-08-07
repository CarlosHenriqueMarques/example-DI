# example-DI

This repo is to recap the concepts about DI

Dependency injection is a design pattern used in software development to make code more flexible, maintainable, and testable. It involves removing direct dependencies between classes or components and instead, providing those dependencies from external sources

Dependency Injection (DI):
In dependency injection, instead of a class creating its own dependencies, those dependencies are "injected" into the class from outside. This means that a class doesn't need to know the details of how its dependencies are created or obtained; it relies on them being provided externally. This is often achieved by passing dependencies through constructors, methods, or properties

Simple Explanation:
Imagine you have two classes: Class A and Class B. Class A requires some functionality from Class B. Traditionally, Class A would create an instance of Class B internally, tightly coupling them together. With dependency injection, you provide Class A with an instance of Class B from an external source, allowing Class A to use it without knowing how it was created or where it came from. This decouples the classes and makes the code more flexible and easier to maintain.

Given the code: 
Let's say we have two classes: Logger and UserService. The UserService class requires a logger to log messages. Instead of creating an instance of Logger inside UserService, we'll inject it through the constructor.
