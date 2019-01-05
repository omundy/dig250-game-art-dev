


![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - 01


## MonoBehaviour

[MonoBehaviour](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) is the base class from which every Unity script derives. When you use C#, you must explicitly derive from MonoBehaviour.


### Methods

Term | Definition
--- | ---
[Awake()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html) | Awake is called just once, when the script instance is being loaded.
[Start()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html) | Start is called just once, on the frame when a script is enabled, [just before](https://docs.unity3d.com/Manual/ExecutionOrder.html) any of the Update methods are called the first time. This makes it a better place to store references to the game object's components needed in the script.
[Update()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html) | The Monobehavior method that runs every frame. 
[FixedUpdate()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html) | This method, like `Update()` runs every frame, but is frame rate independent. This means it is better for physics calculations because the character movement will happen at the same rate regardless of hardware performance. 


