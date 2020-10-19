

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Performance


Start with the [Profiler](https://docs.unity3d.com/Manual/Profiler.html). There are lots of [videos](https://www.youtube.com/watch?v=fROTtgZK-Zs) to get you started.


### C# Terminology

Term | Definition
--- | ---
Garbage Collection | When you remove objects from your game, their data is no longer needed, so the memory that stored that data is freed up to be reused. Garbage is the term for memory that has been set aside to store data but is no longer in use. Garbage collection is the name of the process that makes that memory available again for reuse. Garbage Collection can cause big performance problems if not properly handled. More: [Optimizing garbage collection in Unity games](https://unity3d.com/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games)
Object Pooling | Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. Instead of creating new objects and destroying old ones during gameplay, your game reuses objects from a “pool”. More: [Object Pooling in Unity](https://www.raywenderlich.com/847-object-pooling-in-unity)
Draw calls | Each command the CPU sends to your GPU to draw geometry on your screen; Effectively, the number of objects being drawn. Keep this number down (<2000 desktop and <200 mobile) to maintain good performance.




## General Performance Tips

* When you need a reference to a component, camera, or script, do so in `Awake()` or `Start()` and store it in a variable accessible by the entire class. This will help the performance of your game because you won't have to get the reference over and over.





## Specific Areas for Improvements


### Reduce Draw Calls

- [Unity CPU Optimization: Is Your Game… Draw Call Bound?](https://www.gamasutra.com/blogs/RubenTorresBonet/20200513/362872/Unity_CPU_Optimization_Is_Your_Game_Draw_Call_Bound.php) (2020)

### Garbage Collection

- [Unity Tips | Part 1 - Garbage Collection](https://danielilett.com/2019-08-05-unity-tips-1-garbage-collection/), 2019
- Unity Manual: [Understanding Automatic Memory Management](https://docs.unity3d.com/Manual/UnderstandingAutomaticMemoryManagement.html) 
    - Don't concat strings in loops or `Update()`.


### Other Topics

- [5 Common Misuses of Collections](https://www.jacksondunstan.com/articles/5145)




## Debugging (this may need to move to its own)

### Loops & Editor Crashes

Be careful with loops! This one for example will cause the editor to crash every time, leaving you no specific line number or clues as to where the cause of the problem lies.

```
// example function with a logic error and "safety" var
Vector3 ReturnNewFloatWithError ()
{
    float newFloat = -1; // default is -1 so loop starts
    int safety = 0; // a var to keep track of how many loops have occurred

    // loop until condition is false
    while (newFloat <= 0) {
        // create new float (this is the logic error, it should be creating a positive value so the loop stops)
        newFloat = Random.Range (-1,0);
        // this is the safety, which realistically should never occur, but can help you find other errors in development
        if (++safety > 10) {
            Debug.Log ("ReturnNewFloatWithError() - Safety first!");
            break;
        }
    }
    return newFloat;
}
```



### Sources
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
- Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.




