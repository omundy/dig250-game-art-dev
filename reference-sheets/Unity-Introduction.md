

![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Reference Sheet - Intro to Unity 





### Terminology

Term | Definition
--- | ---
[Scene](https://docs.unity3d.com/Manual/CreatingScenes.html) | A collection of game objects. Think of a scene like a level.
[Scene view](https://docs.unity3d.com/Manual/UsingTheSceneView.html) | The editable view of the scene; Your “working space” where you build and edit objects in your game.
[Game view](https://docs.unity3d.com/Manual/GameView.html) | What your players see when they run your game. Shows what is rendered from the Camera(s) in your game.
[Asset](https://docs.unity3d.com/Manual/AssetWorkflow.html) | A game file (texture, scripts, etc.). All assets are stored in a project’s Assets folder and are visible in the [Project window](https://docs.unity3d.com/Manual/ProjectView.html).
[Project window](https://docs.unity3d.com/Manual/ProjectView.html) | The Project is where you can access and manage all the assets that belong to your project. You can add them by dragging them to the Scene or the Hierarchy.
[Hierarchy window](https://docs.unity3d.com/Manual/Hierarchy.html) | The Hierarchy contains a list of every GameObject in the current Scene. As objects are added and removed in the Scene, they will appear and disappear from the Hierarchy as well.
Parenting | In the Hierarchy, when you drag a game object onto another, the former ("child") will be nested under the one you dragged it to ("parent"). This allows you to organize and group game objects in your scene, and to move, enable (or disable) multiple game objects together.
[Game Object](https://docs.unity3d.com/Manual/class-GameObject.html) | The objects in your scene. These are the containers for components and are viewable in the Scene and Game views and the [Hierarchy window](https://docs.unity3d.com/Manual/Hierarchy.html).
[Component](https://docs.unity3d.com/Manual/Components.html) | A modular piece of behavior, such as a Collider or Script. Components can be added, edited, and removed in the Inspector.
[Inspector](https://docs.unity3d.com/Manual/UsingTheInspector.html) | Displays detailed information about the currently selected game object, including all attached components and their properties, and allows you to modify the functionality of GameObjects in your Scene.
Play Mode | When the editor enters play mode the project begins to run and simulate game play. In play mode changes you make are not saved so leave play mode before resuming work.
[Camera](https://docs.unity3d.com/Manual/CamerasOverview.html) | A game object with a Camera component that renders your players’ view of the game. Can be moved and repositioned (e.g. a "first-person shooter").




### Hotkeys & Buttons


**Scene Movement (2D Mode)**
* Pan - Right Click + Drag
* Zoom - Mouse scroll wheel
* Select - F key or double click
* Arrow Keys - Move around

**[Transform Tools](https://docs.unity3d.com/Manual/SceneViewNavigation.html)** 

![toolbar](https://docs.unity3d.com/uploads/Main/UI-ViewTool.png)

* Q, Hand - Pan / orbit around
* W, Translate - Move game object
* E, Rotate - Rotate object
* R, Scale - Resize object
* T, Rect - Modify 2D sprites
* Y, Composite - Modify 3D sprites

**Miscellaneous**

* Save - Ctrl or Cmd + S
* Duplicate - Ctrl or Cmd + D
* Delete (OSX) - Cmd + Backspace

**[Play Controls](https://docs.unity3d.com/Manual/Toolbar.html)**

![toolbar](https://docs.unity3d.com/uploads/Main/Editor-PlayButtons.png)

* Play -  Enter play mode
* Pause - Pause play mode
* Step - Step forward one frame


### Sources
* [Unity Manual](https://docs.unity3d.com/Manual/index.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 1 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 1 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018. 










