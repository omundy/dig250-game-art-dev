

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Game Programming Patterns & Principles



- Game development is clearly its own world, however many of these patterns and principles are applicable across all programming environments. See [Game programming patterns in Unity](https://github.com/Habrador/Unity-Programming-Patterns) by Erik Nordeus for an in-depth look at game patterns.





## Principles


### Don't Repeat Yourself (DRY)

> "...if you find yourself writing the same line, or lines, of code over and over, it's time to rethink and reorganize. This usually take the form of a new method to hold the repeated code, making it easier to modify and call that functionality elsewhere." – Ferrone

The DRY principle reduces repetition in your code, replacing it with abstractions to avoid redundancy. The most common way is to wrap data and behaviors inside a function or method that can be called every time they are needed.




## Patterns


### Singleton

> "The singleton pattern restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system." — [Wikipedia](https://en.wikipedia.org/wiki/Singleton_pattern)

The Singleton pattern is most often used to store and access global variables across your scene. Its name comes from the fact that there can only be one instance of the class, thus making it good for storing single references to variables you need across your entire game.


### Observer

> "The observer pattern is a software design pattern in which an object, named the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods." — [Wikipedia](https://en.wikipedia.org/wiki/Observer_pattern)

**Example** – Say you have a variable `health` inside a Player object. Every time `health` changes you need several things to happen (e.g. sound, animations, text in UI, or other visual cues) on other GameObjects. Rather than getting a reference *to Player* in all other objects, or a reference *to all other objects* in Player, the Observer pattern handles messages through an EventManager.

- **Reduces dependencies** Any object can subscribe to or send events, regardless if other objects are present.
- **Simplifies code** You think only about the event, not all the object, component, method, variable names and references (avoiding [spaghetti code](https://en.wikipedia.org/wiki/Spaghetti_code)).
- **Coding is easier** Adding new features requires only subscribing to event notifications, allowing easier maintenance of your project.


**References**
- Unity Tutorial [Create a Simple Messaging System with Events](https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events)
- [Game programming patterns in Unity: Observer](https://github.com/Habrador/Unity-Programming-Patterns#3-observer)










### Sources
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
- Chapter 4 in Ferrone. Learning C# by Developing Games with Unity 2020 (5th Edition). Packt, 2020.
