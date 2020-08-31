

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Physics 



### Introductions to game engine physics

* [Unity Tutorial: 3D Physics](https://learn.unity.com/tutorial/3d-physics)
* [Vector In Game Development: Understand The Basics Of Vector Math](https://gamedevelopertips.com/vector-in-game-development/)
* Video Game Physics Tutorial: [Part I: An Introduction to Rigid Body Dynamics](https://www.toptal.com/game/video-game-physics-part-i-an-introduction-to-rigid-body-dynamics)





### General Physics Terminology

Term | Definition
--- | ---
[Rigid body dynamics](https://en.wikipedia.org/wiki/Rigid_body_dynamics) | Movement and interaction of solid, inflexible objects
[Physics engine](https://en.wikipedia.org/wiki/Physics_engine) | The software component that performs the physics simulation
[Newton's Three Laws of Motion](https://en.wikipedia.org/wiki/Newton%27s_laws_of_motion) | Describe the relationship between a body and the forces acting upon it, and its motion in response to those forces
[Inertia](https://en.wikipedia.org/wiki/Newton%27s_laws_of_motion#Newton's_first_law) | First law of motion: If no force is applied on an object, its velocity (speed and direction of motion) shall not change
[Force, Mass, and Acceleration](https://en.wikipedia.org/wiki/Newton%27s_laws_of_motion#Newton's_second_law) | Second law of motion: The force acting on an object is equal to the mass of the object multiplied by its acceleration (rate of change of velocity). This is given by the formula F = ma
[Action and Reaction](https://en.wikipedia.org/wiki/Newton%27s_laws_of_motion#Newton's_third_law) | Third law of motion: “For every action there is an equal and opposite reaction.” In other words, whenever one body exerts a force on another, the second body exerts a force of the same magnitude and opposite direction on the first.
[Vector](https://gamedevelopertips.com/vector-in-game-development/) | A vector is an entity that has a length (or, more formally, a magnitude) and a direction. It can be represented by x and y in 2D, or x, y, and z, in 3-dimensional space. Vectors can describe the position of a static object inside the game world, as well as physical simulations, like the motion of a rigid body in a 3D world.




### Common Vector Operations
A table of common operations for vectors and their Unity references. See also the [Vector Cookbook](https://docs.unity3d.com/Manual/VectorCookbook.html) and [Unity Tutorial: 3D Physics](https://learn.unity.com/tutorial/3d-physics)

Term | Definition
--- | ---
Multiplications by a scalar | Changes the `magnitude` of the vector.  Multiply each component of the vector with the scalar value. For example, the vector A: `(2x, 3y,5z)` multiplied by 2 = `A * 2` = `(4x,6x,10z)`
Addition and subtraction | For example, to increase or find the distance between 2 game objects: To add two vectors A and B, sum the single components of each vector: `a + b = [(a.x + b.x), (a.y + b.y), (a.z + b.z)]` and subtraction is simply `a - b = [(a.x – b.x), (a.y – b.y), (a.z – b.z)]`
Dot.product | A float value equal to the magnitudes of two vectors multiplied together and then multiplied by the cosine of the angle between them. Examples: Find the angle between 2 vectors, and determine if they are parallel; [find](https://gamedevelopertips.com/vector-in-game-development/) degree to which an object’s velocity is in the direction of gravity; find how long until a movement crosses a threshold, and more. In Unity use [`Vector3.Dot`](https://docs.unity3d.com/ScriptReference/Vector3.Dot.html). See also: [Vector Calculus: Understanding the Dot Product](https://betterexplained.com/articles/vector-calculus-understanding-the-dot-product/)
Cross.product | Takes two vectors as input and returns another vector that is perpendicular to the two input vectors. In Unity use [`Vector3.Cross`](https://docs.unity3d.com/ScriptReference/Vector3.Cross.html)
Linear interpolation (LERP) | [Linear interpolation](https://en.wikipedia.org/wiki/Linear_interpolation) is a mathematical operation to find an intermediate point `β` between two known points. For example, to animate from point A to point B over the course of two seconds at 30 frames per seconds, we would need to find 60 intermediate positions between A and B. In Unity use [`Vector3.Lerp`](https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html)
Raycasting | Used to find when a line (ray) has hit a specific target. A common example is when a bullet is shot from a gun.










### Unity Terminology

Term | Definition
--- | ---
[Transform](https://docs.unity3d.com/Manual/Transforms.html) | The Transform component determines the Position, Rotation, and Scale of each object in the scene. Every GameObject has a [Transform Component](https://docs.unity3d.com/Manual/class-Transform.html).
[Rigidbody](https://docs.unity3d.com/Manual/RigidbodiesOverview.html) | This component allows GameObjects to respond to physics and gravity. Since it takes over the movement of the GameObject, do not move the GameObject using code by changing the Transform. Instead, use [`velocity`](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) or other forces to push the GameObject and let the [physics engine](https://docs.unity3d.com/Manual/PhysicsSection.html) calculate the results. Note the specific [Rigidbody2D](https://docs.unity3d.com/ScriptReference/Rigidbody2D.html) for 2D physics.  
[Collider](https://docs.unity3d.com/Manual/CollidersOverview.html) | Collider components define the shape of objects for physical collisions and triggering behaviors. A Collider is invisible and need not be the exact same shape as the GameObject’s Mesh.
[Triggers](https://docs.unity3d.com/Manual/CollidersOverview.html) | Normally colliders detect collisions and initiate the `OnCollisionEnter()` function, but you can also simply detect when another collider overlaps using the `Is Trigger` property without causing physics interactions. This will allow other colliders to pass through and will call the `OnTriggerEnter()` function on the trigger object’s scripts.
[Layer Collision Matrix](https://docs.unity3d.com/Manual/LayerBasedCollision.html) | Located in `Edit > Project Settings > Physics 2D`, Layer-based collision detection is a way to make a GameObject collide with another GameObject that is set up to a specific Layer or Layers.
[Prefab](https://docs.unity3d.com/Manual/Prefabs.html) | Unity’s Prefab system allows you to create, configure, and store a GameObject complete with all its components, property values, and child GameObjects as a reusable Asset. The Prefab Asset acts as a template from which you can create new Prefab instances in the Scene.












### RigidBody2D Body Type Settings

Type | Collides with | Description
--- | --- | ---
Dynamic | Everything | The default setting has the full set of properties to make it affected by gravity and forces. It also is the most performance-expensive body type because of its dynamic nature. 
Kinematic | Only Dynamic Rigidbodys | This setting removes the Rigidbody 2D from control of the physics engine and allows it to be moved kinematically from a script. Since it is not affected by gravity and forces it is fast and has a lower demand on system resources than a Dynamic Rigidbody2D.
Static | Only Dynamic Rigidbodys | This Rigidbody 2D is designed to not move under simulation at all. If anything collides with it, a Static Rigidbody 2D behaves like an immovable object.

Source: Unity Manual: [RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html)





### Sources
* Unity Manual: [Physics](https://docs.unity3d.com/Manual/PhysicsSection.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 3 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 3 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018. 
* Chapter 3,4,5 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.


