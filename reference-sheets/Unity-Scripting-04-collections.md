

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 04

* Storing and using data in multiples and collections


### Terminology

Term | Definition
--- | ---
[Serialization](https://docs.unity3d.com/Manual/script-Serialization.html) | The process of converting the state of an object to a set of bytes in order to store the object into memory, a database or a file.
[Deserialization](https://www.gamasutra.com/blogs/VivekTank/20180731/323248/Introduction_to_Unity_Serialization_and_Game_Data.php) | The reverse process of building an object out of a file, converting text/binary data into usable datatypes in code.




### Classes

* Like a blueprint for a specific object
* Helps group and define data and the functionality for an object
* Can hold all types of properties, fields, events, method etc.
* Reference type (not copied). When you pass a class (or object from it) it is passed as a reference


### Structs

* Useful for holding small data values
* Structs are value types (so faster than a class object). When you pass a struct, it creates a copy of the data.
* Easier to transfer a class object than a struct so do not use struct when you are passing data across the wire or to other classes
* Can contain parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events and nested types

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

* Can contain elements of any data type
* Stores a sequential collection of values of the same type
* Length is fixed, unchangeable, and can be specified or inferred
* Use index number to access values (below, `colors[1] = "green"`)

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

* A non-generic type of collection
* Stores objects of any type like an array
* Unlike an array, you don't need to specify the size as it grows automatically as you add items in it

```C#
IList arrayList = new ArrayList() { 100, "Two", 12.5, 200 };
arrayList.Add("hello");
print (myArryList[4]); // prints "hello"
```


### Lists

* The List<T> collection is the same as an ArrayList except that List<T> is a generic collection
* Stores a sequential collection of values of the same type
* Length is adjustable
* You can easily add and remove elements from a List

```C#
IList<int> intList = new List<int>();
intList.Add(10);
print (intList[0]); // prints 10
```


### Dictionaries

* Dictionaries store a collection of Keys and Values
* The Dictionary<TKey, TValue> class is a generic collection class in the System.Collection.Generics namespace. 
* TKey denotes the type of key and TValue is the type of TValue.

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

* Data containers specific to Unity that can be saved as assets in a project
* Can also be used to help serialize objects and can be instantiated in a scene 

```C#
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ThingManagerScriptableObject", order = 1)]
public class ThingManagerScriptableObject : ScriptableObject
{
    public int numberOfThings;
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












### Sources
* Unity Script Reference: [Array](https://docs.unity3d.com/ScriptReference/Array.html), [Scriptable Objects](https://docs.unity3d.com/Manual/class-ScriptableObject.html), Tutorials [Lists and Dictionaries](https://learn.unity.com/tutorial/lists-and-dictionaries), [Introduction to Scriptable Objects](https://learn.unity.com/tutorial/introduction-to-scriptable-objects)
* TutorialsTeacher: C# [Structs](https://www.tutorialsteacher.com/csharp/csharp-struct), [Arrays](https://www.tutorialsteacher.com/csharp/array-csharp), [ArrayLists](https://www.tutorialsteacher.com/csharp/csharp-arraylist), [Lists](https://www.tutorialsteacher.com/csharp/csharp-list), [Dictionaries](https://www.tutorialsteacher.com/csharp/csharp-dictionary)
* W3Schools: C# [Arrays](https://www.w3schools.com/cs/cs_arrays.asp)
* [How to use arrays, lists, and dictionaries in Unity for 3D game development](https://hub.packtpub.com/arrays-lists-dictionaries-unity-3d-game-development/)

