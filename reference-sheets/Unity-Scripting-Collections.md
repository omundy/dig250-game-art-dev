

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Unity C# Scripting - Collections

- Storing and using data in multiples and collections


### Terminology

Term | Definition
--- | ---
[Serialization](https://docs.unity3d.com/Manual/script-Serialization.html) | The process of converting the state of an object to a set of bytes in order to store the object into memory, a database or a file.
[Deserialization](https://www.gamasutra.com/blogs/VivekTank/20180731/323248/Introduction_to_Unity_Serialization_and_Game_Data.php) | The reverse process of building an object out of a file, converting text/binary data into usable datatypes in code.




### Classes

- Like a blueprint for a specific object
- Helps group and define data and the functionality for an object
- Can hold all types of properties, fields, events, method etc.
- Reference type (not copied). When you pass a class (or object from it) it is passed as a reference


### Structs

- Useful for holding small data values
- Structs are value types (so faster than a class object). When you pass a struct, it creates a copy of the data.
- Easier to transfer a class object than a struct so do not use struct when you are passing data across the wire or to other classes
- Can contain parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events and nested types

```C#
public struct NPC
{
    // fields
    public string Title;
    public bool GoodGuy;
    // constructor
    public NPC(string _Title, bool _GoodGuy)
    {
        Title = _Title;
        GoodGuy = _GoodGuy;
    }
}
// create instance using constructor
NPC badguy1 = new NPC(1, "Dr. Evil", false);
// test
Console.Write(badguy1.Name); // prints Dr. Evil
```


### Arrays

- Can contain elements of any data type
- Stores a sequential collection of values of the same type
- Length is fixed, unchangeable, and can be specified or inferred
- Use index number to access values (below, `colors[1] = "green"`)

```C#
using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour
{
    public string[] colors = new string[] { "red", "green", "blue" };

    void Start()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log("Array " + i + " = " + colors[i]);
        }
    }
}
```


### ArrayList

- A non-generic type of collection
- Stores objects of any type like an array
- Unlike an array, you don't need to specify the size as it grows automatically as you add items in it

```C#
IList arrayList = new ArrayList() { 100, "Two", 12.5, 200 };
arrayList.Add("hello");
print (myArryList[4]); // prints "hello"
```


### Lists

- The List<T> collection is the same as an ArrayList except that List<T> is a generic collection
- Stores a sequential collection of values of the same type
- Length is adjustable
- You can easily add and remove elements from a List

```C#
IList<int> intList = new List<int>();
intList.Add(10);
print (intList[0]); // prints 10
```


### Dictionaries

- Dictionaries store a collection of Keys and Values
- The Dictionary<TKey, TValue> class is a generic collection class in the System.Collection.Generics namespace.
- TKey denotes the type of key and TValue is the type of TValue.

```C#
// create dictionary
Dictionary<string, string> dict = new Dictionary<string, string>();
// add to key=value
dict.Add("greeting","hello world!");
// confirm it contains key and print
if ( dict.ContainsKey("greeting") ){
    print (dict["greeting"]);
}
```



### Scriptable Objects

- Data containers specific to Unity that can be saved as assets in a project
- Can also be used to help serialize objects and can be instantiated in a scene

```C#
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ThingManagerScriptableObject", order = 1)]
public class ThingManagerScriptableObject : ScriptableObject
{
    public int numberOfThings; // edit in the Inspector for the instance
}

public class Thing : MonoBehaviour
{
    // An instance of the ScriptableObject defined above.
    public ThingManagerScriptableObject thingManagerValues;

    void Start()
    {
        for (int i = 0; i < thingManagerValues.numberOfThings; i++)
        {
            print ("Thing Number " + i);
        }
    }
}
```
[Example details](https://docs.unity3d.com/Manual/class-ScriptableObject.html)





## Sharing data between Game Objects

- There are several ways to do this, depending on the complexity of your project.
- Some of these allow you to share across Scenes as well




### 1. Access its instance

- Pro(s):
    - Simple method to access a public field on one script from another script
    - The reference can be saved using the Inspector or during runtime (using `Find`).
    - Also see: [Component.SendMessage()](https://docs.unity3d.com/ScriptReference/Component.SendMessage.html) to send a message to all scripts *attached to the same object*.
- Con(s):
    - Violates the Single Responsibility Principle (the S in [SOLID](https://en.wikipedia.org/wiki/SOLID))
    - Data is not saved across scenes

```C#
// attached to Enemy
public class EnemyScript : MonoBehaviour
{
    public float damage; // must be public
}
// attached to GameManager
public class GameManager : MonoBehaviour
{
    EnemyScript enemyScript; // class and name of script on other game object
    void Awake() {
        // may be more efficient to save reference in inspector if your scene is large
        enemyScript = GameObject.Find ("Enemy").GetComponent <EnemyScript> ();
        // now we have a reference to the other script
        Debug.Log(enemyScript.damage);
    }
}
```




### 2. [Singleton pattern](http://wiki.unity3d.com/index.php/Singleton)

- Pro(s):
    - Generally reusable.
    - Can exist across multiple scenes with `DontDestroyOnLoad`
    - Classes using this can also have methods
- Con(s):
    - Some complicated aspects.

Follow this tutorial to use Singletons: John French [Singletons in Unity (done right)](https://gamedevbeginner.com/singletons-in-unity-the-right-way) (2021)





### 3. A static variable or class

- Pro(s):
    - Fields on a `public static` class are not an instance and therefore do not need to be recreated for each scene
    - Allows you to make data accessible to all objects, across all scenes (globally)...
- Con(s):
    - Slightly more complicated
    - Mixing and [static and instances](https://www.youtube.com/watch?v=JRRlAzBh-6U&t=2s) (14:30) sometimes creates issues

```c#
public static class Globals
{
    public static int Score = 1000;
    public static float AnotherField = 1.0f;
}
// attached to any class
public class MyScript : MonoBehaviour
{
    void Start() {
        Globals.Score += 100;
        Debug.Log(Globals.Score);
    }
}
```
    
Static classes
    - Can only contains static members (properties & methods)
    - Cannot be instantiated
    - Is sealed
    - Cannot contain instance constructors
    
Static members (properties & methods)
    - Can only be referrenced by the type name (creating an instance to get the prop is not required)
    - Only one copy of the static member exists, regardless of the number of instances of the class created
    - Static methods should be "pure" -> They will always do the same thing and don't care about state (except state passed to them)

    
    
### 4. Multiscene loading

One scene is the "main" and loads / unloads other scenes as needed. Some links to information.

- https://docs.unity3d.com/Manual/MultiSceneEditing.html
- https://www.jambit.com/en/latest-info/toilet-papers/unity-persistent-objects-between-scenes-in-a-simple-way/
- https://www.youtube.com/watch?v=zObWVOv1GlE




### 5. Passing Events (the [Observer design pattern](https://en.wikipedia.org/wiki/Observer_pattern))

- This is not technically a way to share data but a way to send messages between different objects.
- A software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.
- Mainly used to implement distributed event handling systems, in "event driven" software, in a way that encourages "decoupling" of objects (there aren't a lot of dependencies that can be broken if name or position changes)
- See this Unity tutorial [Create a Simple Messaging System with Events](https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events) (also this [variation](https://medium.com/@johntucker_48673/discovering-unity-eventmanager-a040285d0690) using the same EventManager class from Unity)
- MSDN: [Observer design pattern](https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern?redirectedfrom=MSDN)




### 6. [PlayerPrefs](https://docs.unity3d.com/ScriptReference/PlayerPrefs.html)
- also preserves data for the next time game is run




### 7. Scriptable Objects

- (see above) are another way to architect and share data across your game. See:
    - [Achieve better Scene workflow with ScriptableObjects](https://blog.unity.com/technology/achieve-better-scene-workflow-with-scriptableobjects) (2020)
    - [Unity Atoms — Tiny modular pieces utilizing the power of Scriptable Objects](https://medium.com/@adamramberg/unity-atoms-tiny-modular-pieces-utilizing-the-power-of-scriptable-objects-e8add1b95201) (2018)

    
    

### 8. JSON

JSON [provides many advantages over Scriptable Objects](https://answers.unity.com/questions/1447032/what-are-the-pros-and-cons-of-scriptableobjects-vs.html).

See [Unity-Scripting-Collections-JSON.md](Unity-Scripting-Collections-JSON.md) for an in-depth look at using JSON data in your Unity project.



### Sources

- [Unity Tutorial: Preserving Data between Scene Loading/Switching](https://www.youtube.com/watch?v=WchH-JCwVI8) (1:10:49)
- Unity Script Reference: [Array](https://docs.unity3d.com/ScriptReference/Array.html), [Scriptable Objects](https://docs.unity3d.com/Manual/class-ScriptableObject.html), Tutorials [Lists and Dictionaries](https://learn.unity.com/tutorial/lists-and-dictionaries), [Introduction to Scriptable Objects](https://learn.unity.com/tutorial/introduction-to-scriptable-objects)
- TutorialsTeacher: C# [Structs](https://www.tutorialsteacher.com/csharp/csharp-struct), [Arrays](https://www.tutorialsteacher.com/csharp/array-csharp), [ArrayLists](https://www.tutorialsteacher.com/csharp/csharp-arraylist), [Lists](https://www.tutorialsteacher.com/csharp/csharp-list), [Dictionaries](https://www.tutorialsteacher.com/csharp/csharp-dictionary)
- W3Schools: C# [Arrays](https://www.w3schools.com/cs/cs_arrays.asp)
- [How to use arrays, lists, and dictionaries in Unity for 3D game development](https://hub.packtpub.com/arrays-lists-dictionaries-unity-3d-game-development/)
