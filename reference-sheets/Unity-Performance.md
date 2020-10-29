

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Performance


Increasing performance is a combination of lower the overhead on the CPU, GPU, and bandwidth. Start with the [Profiler Window](https://docs.unity3d.com/Manual/ProfilerWindow.html) and then move on to [other areas](https://docs.unity3d.com/Manual/Profiler.html) (also covered below).

Tutorials to get started:

- Jason Weimann: [Using the Unity Profiler to optimize performance](https://www.youtube.com/watch?v=fROTtgZK-Zs)


### C# Terminology

Term | Definition
--- | ---
Garbage | Memory that has been set aside to store data but is no longer in use.  When you remove objects from your game their data is no longer needed. The memory that stored that data is then freed to be reused.
Garbage Collection | The process that makes previously used memory available again for reuse. Garbage Collection can cause big performance problems if not properly handled.
Object Pooling | A process where you pre-instantiate all objects you’ll need at any specific moment before gameplay — for instance, during a loading screen. Instead of creating new objects and destroying old ones during gameplay, your game reuses objects from a “pool”.
Draw calls | Each command the CPU sends to your GPU to draw geometry on your screen; Effectively, the number of objects being drawn. Keep this number down (<2000 desktop and <200 mobile) to maintain good performance.



## Performance Tips

Following are main focus areas for considering performance. Consider that there is a lot of overlap between these, and changes in one area can affect another, so remember to test everything for each change.



### General Performance Tips

- When you need a reference to a component, camera, or script, do so in `Awake()` or `Start()` and store it in a variable accessible by the entire class. This will help the performance of your game because you won't add performance hit from looking up the reference over and over in `Update()`.
- Use Object Pooling. See [Object Pooling in Unity](https://www.raywenderlich.com/847-object-pooling-in-unity).

### Graphics Performance

- Unity Manual: [Mobile Optimization](https://docs.unity3d.com/Manual/MobileOptimisation.html)
- Unity Manual: [Optimizing graphics performance](https://docs.unity3d.com/Manual/OptimizingGraphicsPerformance.html)



### Draw Calls

- [Unity CPU Optimization: Is Your Game… Draw Call Bound?](https://www.gamasutra.com/blogs/RubenTorresBonet/20200513/362872/Unity_CPU_Optimization_Is_Your_Game_Draw_Call_Bound.php) (2020)



### Garbage Collection

- [Unity Tips - Garbage Collection](https://danielilett.com/2019-08-05-unity-tips-1-garbage-collection/), 2019
- Unity Manual: [Understanding Automatic Memory Management](https://docs.unity3d.com/Manual/UnderstandingAutomaticMemoryManagement.html)
    - Don't concat strings in loops or `Update()`.
- Unity Tutorial: [Optimizing garbage collection in Unity games](https://unity3d.com/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games)





### Handling Data

- [5 Common Misuses of Collections](https://www.jacksondunstan.com/articles/5145)



### Optimizing Unity UI

- Any time you change a RectTransform (or any UI element that needs its quads redrawn) it sets a "dirty" flag on the layout parent (Canvas). Sometime later (probably same frame, or the next), a single function call to update the layouts at the root is called if the layout is dirty - meaning if it even needs to be rebuilt. If you change one thing vs. 1000 things the layout will need to be redrawn.
- Be careful using `Canvas.ForceUpdateCanvases()` because there is a serious performance hit.
- Unity Tutorial: [Optimizing Unity UI](https://learn.unity.com/tutorial/optimizing-unity-ui#5c7f8528edbc2a002053b5a0)
- Unity Create: [Some of the best optimization tips for Unity UI](https://create.unity3d.com/Unity-UI-optimization-tips)



### Other Tips

- Know how the camera frustrum and clipping planes work https://docs.unity3d.com/Manual/UnderstandingFrustum.html
- Did you bake lighting?
- Did you bake your fonts ([change from dynamic to static](https://youtu.be/NY1xKqCIj3c?t=849))
- Consider the [Order of Execution for Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html) and make sure you aren't causing extra work.



### Sources
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
- Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
