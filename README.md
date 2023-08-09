# Introduction to Basic C# Project: Classes and Interfaces

This simple C# project is designed to help you become familiar with the concepts of classes and interfaces in C# programming. The project consists of two classes, `TodoList` and `PasswordManager`, and introduces the implementation of the `IDisplayable` and `IResetable` interfaces.

## Project Overview

The project focuses on the following key concepts:

1. **Classes:** The `TodoList` and `PasswordManager` classes are defined to manage a to-do list and password information, respectively. These classes serve as examples of how to structure and manage data using C# classes.

2. **Interfaces:** Two interfaces, `IDisplayable` and `IResetable`, are introduced to demonstrate the concept of interfaces. These interfaces define methods that need to be implemented by the classes that use them.

3. **Getting Familiar:** The project aims to help you become comfortable with creating classes, implementing interfaces, and understanding how to structure code using C#.

## Project Structure

- `TodoList.cs`: Contains the implementation of the `TodoList` class, which manages a list of to-do items. It implements the `IDisplayable` and `IResetable` interfaces.

- `PasswordManager.cs`: Contains the implementation of the `PasswordManager` class, which manages password information. It also implements the `IDisplayable` and `IResetable` interfaces.

- `IDisplayable.cs`: Defines the `IDisplayable` interface, which requires classes to implement a `Display()` method to display information.

- `IResetable.cs`: Defines the `IResetable` interface, which requires classes to implement a `Reset()` method to reset certain properties.

- `Program.cs`: Contains the `Main` method where instances of the `TodoList` and `PasswordManager` classes are created and their methods are called to demonstrate their functionality.

## Getting Started

1. Clone or download the project to your local machine.

2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).

3. Review the code and comments in the different files to understand the classes, interfaces, and how they interact.

4. Run the program to see the examples of class instantiation, interface implementation, and method calls in action.



