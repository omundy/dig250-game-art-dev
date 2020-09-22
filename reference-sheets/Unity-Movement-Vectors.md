

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Movement - Vectors 

For moving GameObjects using physics (collisions, gravity, and other forces) see: [Unity Movement - Physics](Unity-Movement-Physics.md)



### Position vs. Direction vs. Scalar vectors

- Vectors are a set of coordinates `(x,y)` (2D) or `(x,y,z)` (3d) rooted in the origin `(0,0,0)` of the game world). You can think about vectors as representing either "position", "direction", or "magnitude"...
- **Position vectors** represent a position of a GameObject in space. For example, a GameObject could be currently located at the position `(5,7,1)` (5 to the left of center, 7 up from center, and 1 towards the z axis "into" the screen). This example will move or "teleport" a GameObject to a new position:
```c#
void Start()
{
  // create a vector representing a position
  Vector newPosition = new Vector3(5,7,1); 
  // set the position property of the game object to the newPosition vector
  transform.position += newPosition;
}
```
- A **direction vector** (a.k.a. "[unit vector](https://mathworld.wolfram.com/UnitVector.html)") represents a **change** (in position or velocity) that you might apply. They are normalized (meaning their length is `1`). In Unity you will often multiply directional vectors with a scalar value (i.e. a single number, like a `speed` variable) and then **add it to the position vector** to a GameObject's transform.position **over time** to make that object move. This example does exactly that:
```c#
void Update()
{
  // our scalar
  float speed = 10;
  // create a direction vector and store the forward direction (in local space) of the attached game object (0,0,1)
  Vector3 direction = transform.forward;
  // create a direction vectory representing the distance to move each frame 
  // using our normalized direction vector * speed * time since last frame
  Vector3 step = direction * speed * Time.deltaTime
  // move the object forward at the given speed each frame
  transform.position += step;
}
```
- A scalar vector is a representation of the magnitude of a GameObject.
- Quaternions are also vectors, representing a direction and magnitude of change in orientation that you might add to the [`Quaternion.identity`](https://docs.unity3d.com/ScriptReference/Quaternion-identity.html) (an objects zero rotation)



- A vector's magnitude is the length of the distance from the origin. In Unity, [`Vector3.magnitude`](https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html) can be used to find the distance between two game objects.



Some simple vector math 
```c#
Vector3 a = (2,1,9); // some position
Vector3 b = (8,3,6); // some position
Vector3 v = b - a;   // unit vector from a to b
Vector3 b = a + v;   // position vector of b

```







### Other Common Vector Operations

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











### Sources

- [Unity Tutorial - Vector Maths](https://learn.unity.com/tutorial/vector-maths)
* [Vector In Game Development: Understand The Basics Of Vector Math](https://gamedevelopertips.com/vector-in-game-development/)
* See [Unity Movement [RigidBody vs Translate]](https://www.youtube.com/watch?v=ixM2W2tPn6c) (9:00) and [Move in Unity3D - Ultimate Unity Tutorial](https://www.youtube.com/watch?v=fyV77lN1Yl0) (49:23) for discussions of how to move GameObjects with `transform`, `AddForce()`, and `MovePosition()`


