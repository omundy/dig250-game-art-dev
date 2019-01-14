

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 02



### Terminology

Term | Definition
--- | ---
Design pattern | A general, reusable solution or best practice for commonly occurring problems in software design. A template for how to solve a problem that can be used in many different situations. [Wikipedia](https://en.wikipedia.org/wiki/Software_design_pattern). 
Game design pattern | Design patterns specifically for games. See Bob Nystrom's [Game Programming Patterns](http://gameprogrammingpatterns.com/contents.html), 2014 for a good overview.
Singleton pattern | A software design pattern that restricts the instantiation of a class to one. This is useful when exactly one object is needed to coordinate actions across the system. For example, singletons can be helpful when you have a single class that provides functionality to several other classes in your game, such as coordinating game logic in a Game Manager class. [Wikipedia](https://en.wikipedia.org/wiki/Singleton_pattern).
Composite pattern | The composite pattern (a.k.a. composition over inheritance principle) says classes should achieve polymorphic behavior and code reuse by their composition (by containing instances of other classes that implement the desired functionality) rather than inheritance from a base or parent class. [Wikipedia](https://en.wikipedia.org/wiki/Composition_over_inheritance). In Unity, each [GameObject](https://docs.unity3d.com/ScriptReference/GameObject.html) can have multiple [components](https://docs.unity3d.com/ScriptReference/Component.html) attached to them, with each component providing different functionality. [Read an analogy](https://medium.com/humans-create-software/composition-over-inheritance-cb6f88070205) describing how this is different than inheritance.



### C# Terminology

Term | Definition
--- | ---
[Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/modifiers) | Modifiers are used to modify declarations of types and type members. 
[`abstract`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) | Indicates that a class is intended only to be a base class of other classes. Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class.
[`const`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const) | Constant fields and locals aren't variables and may not be modified. Constants can be numbers, Boolean values, strings, or a null reference. Don’t create a constant to represent information that you expect to change at any time.
[`override`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override) |	Provides a new implementation of a virtual member inherited from a base class. It is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
[`static`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static) |	Declares a member that belongs to the type itself instead of to a specific object.
[`virtual`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual) |	Declares a method or an accessor whose implementation can be changed by an overriding member in a derived class.
[Access modifiers](https://unity3d.com/learn/tutorials/topics/scripting/scope-and-access-modifiers) | Access modifiers are keywords used to specify the declared accessibility of a member or a type. The three access modifiers you will see most often in C# are: `public` (access not restricted), `protected` (access limited to containing class or types derived from containing class), and `private` (access limited to the containing type). [Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers).

[Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html) | A data structure used throughout Unity to represent 2D positions and directions. 
[Vector3](https://docs.unity3d.com/ScriptReference/Vector3.html) | A data structure used throughout Unity to represent 3D positions and directions. Also contains functions for doing common vector operations.


### C# Methods

Term | Definition
--- | ---
[`Destroy()`](https://docs.unity3d.com/ScriptReference/Object.Destroy.html) | Removes a gameobject, component or asset.




### Sources
* [Unity Manual](https://docs.unity3d.com/Manual/index.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 7 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.



