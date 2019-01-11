

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Physics 



### Terminology

Term | Definition
--- | ---
[Transform](https://docs.unity3d.com/Manual/Transforms.html) | The Transform component determines the Position, Rotation, and Scale of each object in the scene. Every GameObject has a [Transform Component](https://docs.unity3d.com/Manual/class-Transform.html).
[Rigidbody](https://docs.unity3d.com/Manual/RigidbodiesOverview.html) | This component allows GameObjects to respond to physics and gravity. There is a specific [Rigidbody2D](https://docs.unity3d.com/ScriptReference/Rigidbody2D.html) for 2D physics. Since it takes over the movement of the GameObject, do not move the GameObject using code by changing the Transform properties. Instead, use [`velocity`](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) or other forces to push the GameObject and let the [physics engine](https://docs.unity3d.com/Manual/PhysicsSection.html) calculate the results. 
[Collider](https://docs.unity3d.com/Manual/CollidersOverview.html) | Collider components define the shape of objects for physical collisions and triggering behaviors. A Collider is invisible and need not be the exact same shape as the GameObject’s Mesh.
[Prefab](https://docs.unity3d.com/Manual/Prefabs.html) | Unity’s Prefab system allows you to create, configure, and store a GameObject complete with all its components, property values, and child GameObjects as a reusable Asset. The Prefab Asset acts as a template from which you can create new Prefab instances in the Scene.










### RigidBody2D Body Type Settings

Type | Collides with | Description
--- | --- | ---
Dynamic | Everything | The default setting has the full set of properties to make it affected by gravity and forces. It also is the most performance-expensive body type because of its dynamic nature. 
Kinematic | Only Dynamic Rigidbodys | This setting removes the Rigidbody 2D from control of the physics engine and allows it to be moved kinematically from a script. Since it is not affected by gravity and forces it is fast and has a lower demand on system resources than a Dynamic Rigidbody2D.
Static | Only Dynamic Rigidbodys | This Rigidbody 2D is designed to not move under simulation at all. If anything collides with it, a Static Rigidbody 2D behaves like an immovable object.

Source: [Unity Manual: RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)



### Sources
* Unity Manual: [Physics](https://docs.unity3d.com/Manual/PhysicsSection.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 3 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 3 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018. 
* Chapter 3,4 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.


