

![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Reference Sheet - Unity Physics 

Pair with 
* Chapter 3 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 3 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018. 



### Terminology

Term | Definition
--- | ---
[Rigidbody](https://docs.unity3d.com/Manual/RigidbodiesOverview.html) | This component allows game objects to respond to physics and gravity. Since it takes over the movement of the GameObject, do not move it using code by changing the Transform properties. Instead, apply forces to push the GameObject and let the physics engine calculate the results. 
[Transform](https://docs.unity3d.com/Manual/Transforms.html) | The Transform is used to store a GameObject’s position, rotation, scale and parenting state. Every GameObject will have a Transform component attached.
[Collider](https://docs.unity3d.com/Manual/CollidersOverview.html) | Collider components define the shape of objects for physical collisions and triggering behaviors. A Collider is invisible and need not be the exact same shape as the GameObject’s Mesh.





### RigidBody2D Body Type Settings

Type | Collides with | Description
--- | --- | ---
Dynamic | Everything | The default setting has the full set of properties to make it affected by gravity and forces. It also is the most performance-expensive body type because of its dynamic nature. 
Kinematic | Only Dynamic Rigidbodys | This setting removes the Rigidbody 2D from control of the physics engine and allows it to be moved kinematically from a script. Since it is not affected by gravity and forces it is fast and has a lower demand on system resources than a Dynamic Rigidbody2D.
Static | Only Dynamic Rigidbodys | This Rigidbody 2D is designed to not move under simulation at all. If anything collides with it, a Static Rigidbody 2D behaves like an immovable object.

Source: [Unity Manual: RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)



