# Design patterns in C# - Practical examples with diagrams

[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-GPL.3.0-yellow.svg)](LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

A hands-on collection of Gang of Four design patterns implemented in C# with Exalidraw diagrams and examples.  
Perfect for .NET developers preparing for interviews, studying software architecture, or looking for clean, copy-paste-ready pattern implementations.  


## 📋 Patterns Included
 
### Creational Patterns
 
| Pattern | Description | Code |
|---------|-------------|------|
| **Singleton** | Ensures a single instance with global access point | [`singleton_pattern/`](singleton_pattern/) |
| **Factory Method** | Delegates object creation to subclasses | [`factory_pattern/`](factory_pattern/) |
| **Builder** | Constructs complex objects step by step with validation | [`builder_pattern/`](builder_pattern/) |
 
### Structural Patterns
 
| Pattern | Description | Code |
|---------|-------------|------|
| **Adapter** | Makes incompatible interfaces work together | [`adapter_pattern/`](adapter_pattern/) |
| **Bridge** | Decouples abstraction from implementation to avoid class explosion | [`bridge_pattern/`](bridge_pattern/) |
| **Composite** | Composes objects into tree structures | [`composite_pattern/`](composite_pattern/) |
| **Decorator** | Adds behavior dynamically via wrappers | [`decorator_pattern/`](decorator_pattern/) |
| **Façade** | Simplifies a complex subsystem behind a single interface | [`façade_pattern/`](façade_pattern/) |
| **Proxy** | Controls access to another object (includes Remote Proxy) | [`proxy_pattern/`](proxy_pattern/) |
 
### Behavioral Patterns
 
| Pattern | Description | Code |
|---------|-------------|------|
| **Strategy** | Swaps algorithms at runtime via composition | [`strategy_pattern/`](strategy_pattern/) |
| **Template Method** | Defines algorithm skeleton, lets subclasses fill in steps | [`template_method_pattern/`](template_method_pattern/) |
| **Observer** | Notifies multiple objects when state changes | [`observer_pattern/`](observer_pattern/) |
| **Command** | Encapsulates requests as objects (supports undo/redo) | [`command_pattern/`](command_pattern/) |
| **State** | Alters behavior based on internal state changes | [`state_pattern/`](state_pattern/) |
| **Iterator** | Traverses collections without exposing internals | [`iterator_pattern/`](iterator_pattern/) |
 
### Other Patterns
 
| Pattern | Description | Code |
|---------|-------------|------|
| **Repository** | Abstracts data access behind a clean interface | [`repository_pattern/`](repository_pattern/) |

---

## ⚡ Quick Start
~~~ bash
git clone https://github.com/MarioCodes/csharp-design-patterns.git
cd csharp-design-patterns
~~~

Open any pattern folder in Visual Studio or VS Code and run the examples. 

---

## 🧠 Design Principles
 
These are the core SOLID and OOP principles applied throughout the examples:
 
* Identify the aspects of your application that vary and separate them from what stays the same
* Program to an interface, not an implementation
* Favor composition over inheritance - `has-a` may be better than `is-a`
* Strive for loosely coupled designs between objects that interact
* Classes should be open for extension, but closed for modification

---

## 🤝 Contributing
 
Contributions are welcome! Here are some ideas:
 
- Add missing GoF patterns
- Improve or add new Excalidraw diagrams
- Translate descriptions to other languages

Just fork, make your changes, and submit a PR.
 
---

## 📚 References
 
- [Head First Design Patterns](https://www.oreilly.com/library/view/head-first-design/0596007124/)
- [Refactoring Guru — Design Patterns](https://refactoring.guru/design-patterns)
- [Microsoft .NET Design Patterns](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/)

---

## 📄 License
 
This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
 
---
 
## ⭐ Found This Useful?
 
If this repo helped you understand design patterns or prepare for an interview, consider giving it a star
