

![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Ch3 - Reference Sheet - Controlling Characters




### Terminology

Term | Definition
--- | ---
[Audio Source](https://docs.unity3d.com/Manual/class-AudioSource.html) | The Audio Source plays back an Audio Clip in the scene.
[Rigidbody](https://docs.unity3d.com/Manual/class-Rigidbody.html) | This component allows game objects to move using physics and gravity. Since a Rigidbody takes over the movement of the GameObject, you shouldn't try to move it from a script by changing the Transform properties (position, rotation, or scale). Instead, you should apply forces to push (for example, other characters, objects, projectiles) the GameObject and let the physics engine calculate the results. See below for more details.
[Transform](https://docs.unity3d.com/Manual/Transforms.html) | The Transform is used to store a GameObject’s position, rotation, scale and parenting state. Every GameObject will have a Transform component attached.
[Collider](https://docs.unity3d.com/Manual/Collider2D.html) | Collider components define the shape of objects for the purposes of physical collisions. A Collider, which is invisible, need not be the exact same shape as the GameObject’s Mesh; in fact, a rough approximation is often more efficient and indistinguishable in gameplay. Colliders for 2D GameObjects all have names ending “2D”. A Collider that does not have “2D” in the name is intended for use on a 3D GameObject. 



### [RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) Body Type Settings

Body Type | Definition
--- | ---
Dynamic | (Default) This setting has the full set of properties available to it such as finite mass and drag, and is affected by gravity and forces. A Dynamic body will collide with every other body type, and is the most interactive of body types. It also is the most performance-expensive body type, because of its dynamic nature and interactivity with everything around it. 
Kinematic | A Rigidbody2D marked `Kinematic` behaves like an immovable object during collisions. 



The Rigidbody component has a property called Is
Kinematic that removes it from the control of the physics engine and allows it to be moved
kinematically from a script. It is possible to change the value of Is Kinematic from a script
to allow physics to be switched on and off for an object, but this comes with a performance
overhead and should be used sparingly.


A Kinematic Rigidbody 2D is designed to move under simulation, but only under very explicit user control. While a 

a Kinematic Rigidbody 2D isn’t
Dynamic | A Rigidbody2D is affected by gravity and forces, . For this reason, it is fast and has a lower demand on system resources than a Dynamic Rigidbody 2D. Kinematic Rigidbody 2D is designed to be repositioned explicitly via Rigidbody2D.MovePosition or Rigidbody2D.MoveRotation. Use physics queries to detect collisions, and scripts to decide where and how the Rigidbody 2D should move.









## Audio formats for Unity

Type | Lossless | Alpha | Description
--- | :--- | --- | ---
PNG | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) yes | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) yes | Commonly used on the web. Lossless compression; has an alpha channel.










