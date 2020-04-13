

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 04

* Storing and using data in multiples and collections


### Structs

* Useful for holding small data values
* Defined using the struct operator
* Can contain parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events and nested types

```
struct NPC
{
    // fields
    public int NPCId;
    public string FirstName;
    public string LastName;
    public bool GoodGuy;
    
    // constructor function
    public Employee(int _NPCId, string FirstName, string _LastName, bool _GoodGuy)
    {
        EmpId = _NPCId;
        FirstName = _FirstName;
        LastName = _LastName;
        GoodGuy = _GoodGuy;
    }
}
// create instance using constructor
NPC badguy1 = new NPC(1, "Dr.", "Evil", false);
// test 
Console.Write(badguy1.FirstName + " " + badguy1.LastName); // prints Dr. Evil
```


### Arrays

* Can contain elements of any data type
* Stores a sequential collection of values of the same type
* Length is fixed, unchangeable, and can be specified or inferred
* Use index number to access values (below, `colors[1] = "green"`)

```
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

```
IList arrayList = new ArrayList() { 100, "Two", 12.5, 200 };
arrayList.Add("hello");
print (myArryList[4]); // prints "hello"
```


### Lists

* The List<T> collection is the same as an ArrayList except that List<T> is a generic collection
* Stores a sequential collection of values of the same type
* Length is adjustable
* You can easily add and remove elements from a List

```
IList<int> intList = new List<int>();
intList.Add(10);
print (intList[0]); // prints 10
```


### Dictionaries

* Dictionaries store a collection of Keys and Values
* The Dictionary<TKey, TValue> class is a generic collection class in the System.Collection.Generics namespace. 
* TKey denotes the type of key and TValue is the type of TValue.

```
Dictionary<string, string> dict = new Dictionary<string, string>();
dict.Add("greeting","hello world!");
print (dict["greeting"]);
```


### Sources
* Unity Script Reference: [Array](https://docs.unity3d.com/ScriptReference/Array.html), [Lists and Dictionaries](https://learn.unity.com/tutorial/lists-and-dictionaries) 
* TutorialsTeacher: C# [Structs](https://www.tutorialsteacher.com/csharp/csharp-struct), [Arrays](https://www.tutorialsteacher.com/csharp/array-csharp), [ArrayLists](https://www.tutorialsteacher.com/csharp/csharp-arraylist), [Lists](https://www.tutorialsteacher.com/csharp/csharp-list), [Dictionaries](https://www.tutorialsteacher.com/csharp/csharp-dictionary)
* W3Schools: C# [Arrays](https://www.w3schools.com/cs/cs_arrays.asp)
* [How to use arrays, lists, and dictionaries in Unity for 3D game development](https://hub.packtpub.com/arrays-lists-dictionaries-unity-3d-game-development/)

