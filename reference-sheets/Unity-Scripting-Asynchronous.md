

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - Asynchronous Programming


### Introduction

Making sure all the parts of your game are communicating and have the right data, including data from web servers, is an important part of any game. There are several ways to make sure you can account for latency depending on the situation.


### Terminology

Term | Definition
--- | ---
Latency | The time it takes for an event or communication about an event to occur.
Synchronous | When something happens in real time there is no latency resulting from the execution of code or communication about events.
Asynchronous | When something does not happen in real time. Any latency resulting from data requests from a remote API or a local filesystem, even if only a few milliseconds, means that something is asynchronous and your code needs to know what to do when data it needs isn't yet there.



### Update()

This is probably the least efficient method since it checks events on every frame, but it is possible to account for latency using the `Update()` loop and one more more control variables to wait for events to finish.


### Coroutines

You can use the looping structure of a [Coroutine](https://docs.unity3d.com/Manual/Coroutines.html) with one or more control variables to wait for events to finish. Coroutines allow you to use [WaitForSeconds()](https://docs.unity3d.com/ScriptReference/WaitForSeconds.html) to introduce delays making this a good option for dealing with asynchronicity as well as other code that needs to be spread out over time like animations.


### Event Driven Programming

Using events or an event manager is a good way to create "listeners" to be executed once another event happens or finishes.

- Unity Tutorial: [Practical Event Driven Programming](https://learn.unity.com/tutorial/practical-event-driven-programming)


### Callbacks

Callbacks offer a way to pass a function to be executed when another function completes. Can be used with Coroutines and event driven programming.

- Jason Weimann: [Delegates and Actions](https://www.youtube.com/watch?v=klwEhouBKTc)
- Jason Weimann: [Delegates and Actions as Callbacks](https://www.youtube.com/watch?v=cagSt8Acj40)





### Async/Await

Probably the most complicated of the methods since it is new to Unity / C# as of 2017, Async/Await makes it possible to deal with asynchronous events while continuing to write your code in a more intuitive and simpler synchronous structure.

- [Async-Await instead of coroutines in Unity](http://www.stevevermeulen.com/index.php/2017/09/using-async-await-in-unity3d-2017/)
- [Using async/await in Unity](https://randompoison.github.io/posts/unity-async/), 2019
