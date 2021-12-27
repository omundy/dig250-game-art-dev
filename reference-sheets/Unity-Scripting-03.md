

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Unity C# Scripting - 03



### C# Terminology

Term | Definition
--- | ---
[Coroutines](https://docs.unity3d.com/Manual/Coroutines.html) | A coroutine is like a function that has the ability to pause execution and return control to Unity but then to continue where it left off on the following frame. They are handy for timers or scripted animations. All coroutines use the type `IEnumerator`. To set a coroutine running, you need to use `StartCoroutine()`.
`yield` | Coroutines must use a `yield return` statement somewhere in the body to denote the point at which execution will pause and be resumed the following frame. 
[`Time.deltaTime`](https://unity3d.com/learn/tutorials/topics/scripting/delta-time?playlist=17117) | Using Time.deltaTime can help your behaviors run smoothly regardless of frame rate by calculating the amount of time between frames, regardless of the speed of the platform.
`float.Epsilon` | The smallest possible float greater than zero (roughly `1.401298E-45`). Allows a comparison of a floating point value to zero.
[`Rigidbody2D.MovePosition()`](https://docs.unity3d.com/ScriptReference/Rigidbody2D.MovePosition.html) | Moves the rigidbody to the specified position by calculating the appropriate linear velocity required to move the rigidbody to that position during the next physics update. During the move, neither gravity or linear drag will affect the body. This causes the object to rapidly move from the existing position, through the world, to the specified position. It is best used in `FixedUpdate()`.
[`Vector3.zero`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,0,0)`.
[`Vector3.up`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,1,0)`.
[`Vector3.left`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(-1,0,0)`.
[`Vector3.right`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(1,0,0)`.
[`Vector3.forward`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,0,1)`.
[`Vector3.one`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(1,1,1)`.
[`Vector3.x`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Retrieves the `x` component of the `Vector3`.




### World, Viewport, and Screen space

Unity uses 3 different co-ordinate systems, World point system, Viewport point system, and Screen point system. There are functions to find where the particular point will be in another point system.

![coordinate systems](https://answers.unity.com/storage/temp/8053-spaces.jpg)

* **World**: The space where objects live. Uses 3D coordinates and has no limits to its size. The unit size in worldspace is arbitrary. Can be either local (to the game object) or global (to the world).
* **Viewport**: A viewport space point is normalized and relative to the Camera. The bottom-left of the Camera is (0,0); the top-right is (1,1). The z position is in world unity from the camera.
* **Screen**: Used by the UI system and unit size is pixels. The bottom-left of the screen is (0,0); the right-top is (screen.width, screen.height) The z position is in world units from the camera. The mouse position is given in this coordinate system.






### Sources
* Unity Manual: [Animation](https://docs.unity3d.com/Manual/AnimationSection.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
