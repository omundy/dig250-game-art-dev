

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Performance



### C# Terminology

Term | Definition
--- | ---
Garbage Collection | When you remove objects from your game, their data is no longer needed, so the memory that stored that data is freed up to be reused. Garbage is the term for memory that has been set aside to store data but is no longer in use. Garbage collection is the name of the process that makes that memory available again for reuse. Garbage Collection can cause big performance problems if not properly handled. More: [Optimizing garbage collection in Unity games](https://unity3d.com/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games)
Object Pooling | Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. Instead of creating new objects and destroying old ones during gameplay, your game reuses objects from a “pool”. More: [Object Pooling in Unity](https://www.raywenderlich.com/847-object-pooling-in-unity)
Draw calls | Each command the CPU sends to your GPU to draw geometry on your screen; Effectively, the number of objects being drawn. Keep this number down (<2000 desktop and <200 mobile) to maintain good performance.




### General Performance Tips

* When you need a reference to a component, camera, or script, do so in `Awake()` or `Start()` and store it in a variable accessible by the entire class. This will help the performance of your game because you won't have to get the reference over and over.



### Garbage Collection

* [Don't concat strings](https://docs.unity3d.com/Manual/UnderstandingAutomaticMemoryManagement.html) in loops or `Update()`.



### Sources
* Unity Manual: [Animation](https://docs.unity3d.com/Manual/AnimationSection.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
* [Unity CPU Optimization: Is Your Game… Draw Call Bound?](https://www.gamasutra.com/blogs/RubenTorresBonet/20200513/362872/Unity_CPU_Optimization_Is_Your_Game_Draw_Call_Bound.php) (2020)
* [Unity Tips | Part 1 - Garbage Collection](https://danielilett.com/2019-08-05-unity-tips-1-garbage-collection/), 2019


