

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Unity Animation





### Terminology

Term | Definition
--- | ---
Animation Frame | A single moment in time, where properties or different sprites could be displayed.
[Animation Clips](https://docs.unity3d.com/Manual/class-AnimationClip.html) | A single clip, with either a sprite frame by frame animation or changes to properties, viewable on a timeline. These represent isolated pieces of motion, such as Run, Jump, or Crawl, and are controlled by the Animation Controller.
[Animator Controller](https://docs.unity3d.com/Manual/class-AnimatorController.html) | The “brain” or “state machine” where you control which animation clip is playing and the conditions for how transitions between animation clips happen.
[Animation States](https://docs.unity3d.com/Manual/StateMachineBasics.html) | Every character will always be engaged in some kind of action at a given time. The actions available will depend on the type of gameplay but typical actions include things like idling, walking, running, jumping, etc. These actions are referred to as states.
[Animation Transitions](https://docs.unity3d.com/Manual/class-Transition.html) | The switch or blend from one animation to another in the state machine and under what conditions the change should occur.
[Animation Parameters](https://docs.unity3d.com/Manual/AnimationParameters.html) | Variables defined within an Animator Controller that allow script control over the flow of the state machine. For example, if a player makes a character jump, we can use code to set a `grounded` property to false. We can set the state machine to transition to a jump animation in this case.


### Advanced Terminology

Term | Definition
--- | ---
[Exit Time](https://docs.unity3d.com/Manual/class-Transition.html) | When `Has Exit Time` is checked, the `Exit Time` property tells the animator after what percentage of the animation has played should the transition take effect. If set to `1` then the entire animation will play before transitioning.
[Transition Duration](https://docs.unity3d.com/Manual/class-Transition.html) | The duration of the transition, in normalized time or seconds depending on the Fixed Duration mode, relative to the current state’s duration. This is visualized in the transition graph as the portion between the two blue markers.
[Blend Tree](https://docs.unity3d.com/Manual/class-BlendTree.html) | Allow multiple animations to be blended smoothly by incorporating parts of them all to varying degrees. Blend Trees can bundle various motions into a single node, making your game architecture more manageable.
Blend Tree Types | Blend Types are used to describe how the Blend Tree should blend motions. You can configure the Blend Tree for [1D](https://docs.unity3d.com/Manual/BlendTree-1DBlending.html), [2D](https://docs.unity3d.com/Manual/BlendTree-2DBlending.html) or [Direct blending](https://docs.unity3d.com/Manual/BlendTree-DirectBlending.html). 
[Blend Tree Motion](https://docs.unity3d.com/Manual/BlendTree-2DBlending.html) | The motion property in a blend tree is for animation clips that will be blended.
[Animation Layer](https://docs.unity3d.com/Manual/AnimationLayers.html) | Unity uses Animation Layers for managing complex state machines for different body parts. An example of this is if you have a lower-body layer for walking-jumping, and an upper-body layer for throwing objects / shooting.


### Sources
* Unity Manual: [Animation](https://docs.unity3d.com/Manual/AnimationSection.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 5 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 4 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018.
* Chapter 2 in Godbold, Ashley, and Simon Jackson. Mastering Unity 2D Game Development (2nd Edition). Packt, 2016. 
* Chapter 3 and 8 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.

