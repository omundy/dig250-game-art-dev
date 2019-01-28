

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Performance



### C# Terminology

Term | Definition
--- | ---
Garbage Collection | When you remove objects from your game, their data is no longer needed, so the memory that stored that data is freed up to be reused. Garbage is the term for memory that has been set aside to store data but is no longer in use. Garbage collection is the name of the process that makes that memory available again for reuse. Garbage Collection can cause big performance problems if not properly handled. More: [Optimizing garbage collection in Unity games](https://unity3d.com/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games)
Object Pooling | Object pooling is where you pre-instantiate all the objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. Instead of creating new objects and destroying old ones during gameplay, your game reuses objects from a “pool”. More: [Object Pooling in Unity](https://www.raywenderlich.com/847-object-pooling-in-unity)
