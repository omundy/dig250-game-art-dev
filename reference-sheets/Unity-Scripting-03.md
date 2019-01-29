

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 03



### C# Terminology

Term | Definition
--- | ---
[`Time.deltaTime`](https://unity3d.com/learn/tutorials/topics/scripting/delta-time?playlist=17117) | Using Time.deltaTime can help your behaviors run smoothly regardless of frame rate by calculating the amount of time between frames, regardless of the speed of the platform.
`float.Epsilon` | The smallest possible float greater than zero (roughly `1.401298E-45`). Allows a comparison of a floating point value to zero.
[Rigidbody2D.MovePosition()](https://docs.unity3d.com/ScriptReference/Rigidbody2D.MovePosition.html) | Moves the rigidbody to the specified position by calculating the appropriate linear velocity required to move the rigidbody to that position during the next physics update. During the move, neither gravity or linear drag will affect the body. This causes the object to rapidly move from the existing position, through the world, to the specified position. It is best used in `FixedUpdate()`.
[`Vector3.zero`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,0,0)`.
[`Vector3.up`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,1,0)`.
[`Vector3.left`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(-1,0,0)`.
[`Vector3.right`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(1,0,0)`.
[`Vector3.forward`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(0,0,1)`.
[`Vector3.one`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Shorthand for writing `Vector3(1,1,1)`.
[`Vector3.x`](https://docs.unity3d.com/ScriptReference/Vector3.html) | Retrieves the `x` component of the `Vector3`.
