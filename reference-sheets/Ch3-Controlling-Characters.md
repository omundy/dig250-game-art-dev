

![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Ch3 - Reference Sheet - Controlling Characters




### Terminology

Term | Definition
--- | ---
[Audio Source](https://docs.unity3d.com/Manual/class-AudioSource.html) | The Audio Source plays back an Audio Clip in the scene.
[Rigidbody](https://docs.unity3d.com/Manual/class-Rigidbody.html) | This component allows game objects to move using physics and gravity. Since it takes over the movement of the GameObject, do not move it from a script by changing the Transform properties. Instead, apply forces to push the GameObject and let the physics engine calculate the results. 
[Transform](https://docs.unity3d.com/Manual/Transforms.html) | The Transform is used to store a GameObject’s position, rotation, scale and parenting state. Every GameObject will have a Transform component attached.
[Collider](https://docs.unity3d.com/Manual/Collider2D.html) | Collider components define the shape of objects for physical collisions and triggering behaviors. A Collider is invisible and need not be the exact same shape as the GameObject’s Mesh.





### RigidBody2D Body Type Settings

Type | Collides with | Description
--- | --- | ---
Dynamic | Everything | The default setting has the full set of properties to make it affected by gravity and forces. It also is the most performance-expensive body type because of its dynamic nature. 
Kinematic | Only Dynamic Rigidbodys | This setting removes the Rigidbody 2D from control of the physics engine and allows it to be moved kinematically from a script. Since it is not affected by gravity and forces it is fast and has a lower demand on system resources than a Dynamic Rigidbody2D.
Static | Only Dynamic Rigidbodys | This Rigidbody 2D is designed to not move under simulation at all. If anything collides with it, a Static Rigidbody 2D behaves like an immovable object.

Source: [Unity Manual: RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)




### C# Terms

Term | Definition
--- | ---
[Awake()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html) | Awake is called just once, when the script instance is being loaded.
[Start()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html) | Start is called just once, on the frame when a script is enabled [just before](https://docs.unity3d.com/Manual/ExecutionOrder.html) any of the Update methods are called the first time. 
[Update()](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html) | The Monobehavior method that runs every frame. 




## Audio formats for Unity

Type | Lossless | Alpha | Description
--- | :--- | --- | ---
PNG | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) yes | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) yes | Commonly used on the web. Lossless compression; has an alpha channel.










