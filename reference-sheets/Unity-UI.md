

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Unity UI





### Terminology

Term | Definition
--- | ---
[Canvas](https://docs.unity3d.com/Manual/class-Canvas.html) | A Game Object with a Canvas component on it. All UI elements should be the children of the Canvas. If a Canvas doesn't exist when you add a new UI element one will be created. The Canvas is shown as a rectangle in the Scene View to make it easy to position UI elements. You can [control](https://docs.unity3d.com/Manual/UICanvas.html) how the Canvas will align to and fill the screen of the user's device with the `Render Mode` setting.
Panel | This is a basic panel for the UI. You can change the Sprite that is shown as its background.
[Button](https://docs.unity3d.com/Manual/script-Button.html) | The Button control responds to a click from the user and is used to initiate or confirm an action.
[Text](https://docs.unity3d.com/Manual/script-Text.html) | The Text component displays text. It is possible to set the font, font style, font size, and other parameters.
[Image](https://docs.unity3d.com/Manual/script-Image.html) | An Image has a Rect Transform component and an Image component. A sprite can be applied to the Image component under the Target Graphic field.
[Rect Transform](https://docs.unity3d.com/Manual/class-RectTransform.html) | The Rect Transform is a transform component for 2D and UI elements. In addition to position, rotation, and scale, it also has width and height.  
Rect Tool | The Rect Tool is used to adjust the Rect Transform on 2D and UI elements in the Scene View.
Anchor Points | Anchors are used with Rect Transforms to anchor a UI element in relation to its parent. Anchors are shown as four small triangular handles in the Scene View, and can be used to create a variety of different responsive layouts. Each diamond in the Anchor Points corresponds to a corner of the Rect Transform of the UI Element.

![example of anchor](https://docs.unity3d.com/uploads/Main/UI_Anchored2.gif)


### UI Performance

- Find lots of UI performance tips inside the [class reference sheet on performance](Unity-Performance.md)


### Sources
* Unity Manual: [UI System](https://docs.unity3d.com/Manual/UISystem.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 4 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 5 & 7 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018.
* Chapter 6 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
