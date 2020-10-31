

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

A good way to begin understanding UI performance is by watching this video: [Unite Europe 2017 - Squeezing Unity: Tips for raising performance
](https://www.youtube.com/watch?v=_wxitgdx-UI&index=7&list=PLX2vGYjWbI0Rzo8D-vUCFVb_hHGxXWd9j&ab_channel=Unity)

From the video, the first thing to know about UI performance is that during runtime, if you [change even just one element that needs to be redrawn it sets a "dirty" flag on the (first) Canvas parent of that changed object](https://youtu.be/_wxitgdx-UI?t=1648). When a Canvas is marked dirty then **ALL** the geometries in that Canvas need to be recomputed [on that frame](https://docs.unity3d.com/Manual/ExecutionOrder.html) causing a major performance hit. Several of the tips below help to address this issue.


#### Tips 

- Organize your UI elements into multiple or nested canvases based on when they are updated. These "islands" will [help to isolate elements that need to be redrawn](https://youtu.be/_wxitgdx-UI?t=1680) so you won't have to redraw all elements.
- Use prefabs to nest elements [#20](https://medium.com/@dariarodionovano/unity-ui-best-practices-40964a7a9aba)
- [Disable Raycast Target property for all non-interactive elements](https://medium.com/@dariarodionovano/unity-ui-best-practices-40964a7a9aba) to avoid [the amount of work the raycaster must do on each frame](https://youtu.be/_wxitgdx-UI?t=1944)
- Turn off Images components you don't need to avoid draw calls [#15](https://medium.com/@dariarodionovano/unity-ui-best-practices-40964a7a9aba)
- [Do not use alpha to show / hide elements](https://medium.com/@dariarodionovano/unity-ui-best-practices-40964a7a9aba)
- Be careful using `Canvas.ForceUpdateCanvases()` because there is a serious performance hit.

#### Tutorials and more information

- Unity Tutorial: [Optimizing Unity UI](https://learn.unity.com/tutorial/optimizing-unity-ui#5c7f8528edbc2a002053b5a0)
- Unity Create: [Some of the best optimization tips for Unity UI](https://create.unity3d.com/Unity-UI-optimization-tips)
- [Unity UI Best Practices](https://medium.com/@dariarodionovano/unity-ui-best-practices-40964a7a9aba)


### Other Tips

- Know how the camera frustrum and clipping planes work https://docs.unity3d.com/Manual/UnderstandingFrustum.html
- Did you bake lighting?
- Did you bake your fonts ([change from dynamic to static](https://youtu.be/NY1xKqCIj3c?t=849))
- Consider the [Order of Execution for Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html) and make sure you aren't causing extra work.



### Sources
- [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
- Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
