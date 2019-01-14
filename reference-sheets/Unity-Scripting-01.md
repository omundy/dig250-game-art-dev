

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 01


### MonoBehaviour

* [MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) is the base class from which every Unity script derives. 
* When you use C#, you must explicitly derive from MonoBehaviour.


### Monobehavior Methods

Method | Description
--- | ---
[`Awake()`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html) | Awake is called just once, when the script instance is being loaded.
[`Start()`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html) | Start is called just once, on the frame when a script is enabled, [just before](https://docs.unity3d.com/Manual/ExecutionOrder.html) any of the Update methods are called the first time. This makes it a better place to store references to the game object's components needed in the script.
[`Update()`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html) | The Monobehavior method that runs every frame. 
[`FixedUpdate()`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html) | This method, like `Update()` runs every frame, but is frame rate independent. This means it is better for physics calculations because the character movement will happen at the same rate regardless of hardware performance. 
[`OnTriggerEnter2D(Collider2D)`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html) | Sent when another object enters a trigger collider attached to this object (2D physics only). Further information about the other collider is reported in the Collider2D parameter passed during the call.


### Terminology

Term | Definition
--- | ---
[Variable](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables) (value type) | There are two kinds of types in C#: value types and reference types. Variables of value types directly contain their data. With value types, the variables each have their own copy of the data, and it is not possible for operations on one to affect the other (except in the case of ref and out parameter variables). C#’s value types are further divided into simple types (e.g. `float`,`int`,`bool`), [`enum`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/enums) types, [`struct`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/structs) types, and nullable value types. 
[Variable](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables) (reference type) | Reference types store references to their data, the latter being known as objects. With reference types, it is possible for two variables to reference the same object and thus possible for operations on one variable to affect the object referenced by the other variable. C#’s reference types are further divided into [class](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/classes-and-objects) types (e.g. `object`, `string`, `class`), [`interface`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/interfaces) types, [`array`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/arrays) types, and [`delegate`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/delegates) types.
[Method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods) | A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. 
[Inheritance](https://unity3d.com/learn/tutorials/topics/scripting/inheritance) | Allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. The class whose members are inherited is called the base class. The class that inherits the members of the base class is called the derived class. [Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance).
[Namespace](https://docs.unity3d.com/Manual/Namespaces.html) | Help to prevent naming conflicts by organizing our class names into collections referred to using the chosen prefix. An example of this simplified access: instead of typing `UnityEngine.Debug.Log()` we can type `Debug.Log()` by writing `using UnityEngine`.
[Scope](https://unity3d.com/learn/tutorials/topics/scripting/scope-and-access-modifiers) | A variable can be either of global or local scope. A global variable is a variable declared in the main body of the source code, outside all functions, while a local variable is one declared within the body of a function or a block. [Wikipedia](https://en.wikipedia.org/wiki/Scope_(computer_science)).
[Scriptable objects](https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects) | Scriptable objects are reusable data containers defined via C# script and saved as Assets. They reduce memory usage by storing references to a single instance of a data set. Because they inherit from `ScriptableObject` class they cannot be attached to GameObjects as they do not inherit from MonoBehaviour.


### Tips

* In VisualStudio Code on Mac, `shift + option + F` will auto format.
* In C# the filename (e.g. `PlayerController.cs`) and the Class name (e.g. `PlayerController`) must match.
* If you see an error like `The type or namespace name <Type> could not be found. Are you missing a <namespace> using directive?`, you may have forgotten to import the correct `namespace` at the top of your script.


### Sources
* [Unity Manual](https://docs.unity3d.com/Manual/index.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 3 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 1 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018.
* Chapter 1 in DaGraca & Lukosek. Learning C# 7 By Developing Games with Unity 2017 (3rd Edition). Packt, 2017.
* Chapter 5 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.

