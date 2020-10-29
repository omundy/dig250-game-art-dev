

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Lighting

### Outline

- [Lighting](#Lighting Introduction)
	- [Terminology](#Lighting-Terminology)
	- [Types](#Lighting-Types)
	- [Fog](#Fog)
- [Rendering Pipelines](#Rendering-Pipelines)


### Lighting Introduction

Lighting in Unity depends on many factors. A sprite or mesh (2D or 3D object) uses textures (raster images) to define the image on its surface, a material and shader to determine how that surface is rendered. The effect of lighting results from rendering pixels [at the end of each frame](https://docs.unity3d.com/Manual/ExecutionOrder.html) to represent the **surfaces** of all objects in the scene that are visible in the [camera frustrum](https://docs.unity3d.com/Manual/UnderstandingFrustum.html) using their meshes, textures, and settings in the materials and shaders attached to them.

See these introductions to get started:
- Unity Docs: [Lighting in Unity](https://docs.unity3d.com/Manual/LightingOverview.html) works by approximating how light behaves in the real world.
- Unity Tutorial: [Introduction to Lighting and Rendering](https://learn.unity.com/tutorial/introduction-to-lighting-and-rendering-2019-3) Unity 2019
- Unity Tutorial: [Lighting - Lights & Shading Basics](https://learn.unity.com/tutorial/lighting-lights-shading-basics#)



### Lighting Terminology

Term | Definition
--- | ---
[Global illumination](https://docs.unity3d.com/Manual/LightingInUnity.html) | Modeling both direct and indirect lighting to provide realistic lighting. Unity has two global illumination systems, which combine direct and indirect lighting.
Direct light | Light that is emitted, hits a surface once, and is then reflected directly into a sensor (for example, the eye’s retina or a camera).
Indirect light | All other light, including sky light, that hits several surfaces before being reflected into a sensor.
Real-time lighting | Lighting calculated (a.k.a. "dynamic lighting") at runtime. In Unity, you can use real-time lighting, baked lighting, or a mix of the two.
[Baked Lighting](https://docs.unity3d.com/Manual/LightMode-Baked.html) | Lighting that is calculated in advance by simulating (a.k.a. [lightmapping](https://docs.unity3d.com/Manual/Lightmappers.html)) the lighting bouncing off [static objects](https://docs.unity3d.com/Manual/StaticObjects.html) (those which do not move) and storing the result in texture files called lightmaps. These textures are then mapped directly on objects during runtime. Pre-computed lighting improves CPU performance and lighting quality but lowers the number of dynamic light effects possible and increases the draw calls.
[Lightmap](https://en.wikipedia.org/wiki/Lightmap) | A texture that results from baking indirect lighting on static objects. Areas on an object which are in shadow are saved as darker pixels and lit areas are saved as lighter colored pixels. Examples: [lightmap](https://twitter.com/yuriyodonnell/status/880374951160803328)
[Shadowmap](https://en.wikipedia.org/wiki/Shadow_mapping) | A texture that stores the shadows. Unity uses shadow mapping for [real-time shadows](https://docs.unity3d.com/Manual/shadow-mapping.html) on dynamic/moving objects. Examples: [shadowmap](https://viktorpramberg.com/baked-lighting)
Lightmap UV | Similar to a [texture UV](Unity-Sprites-and-Textures.md#textures) except it is used to store baked lighting and shadow information to wrap over objects.


[![Alt text](https://img.youtube.com/vi/u5RTVMBWabg/0.jpg)](https://www.youtube.com/watch?v=u5RTVMBWabg)

Unite Europe 2017 - Bake it 'til you make it: An intro to Lightmaps (42:17)

[![Alt text](https://img.youtube.com/vi/VnG2gOKV9dw/0.jpg)](https://www.youtube.com/watch?v=VnG2gOKV9dw)

Brackeys: LIGHTING in Unity (16:12)




### Lighting Types

The following [types of lights](https://docs.unity3d.com/Manual/Lighting.html) are available.


Term | Definition
--- | ---
Point light | A Light that is located at a point in the Scene and emits light in all directions equally
Spot light | A Light that is located at a point in the Scene and emits light in a cone shape
Directional | A Light that emits light in one direction only ("the sun")
Area light | A Light that is defined by a rectangle in the Scene, and emits light all directions uniformly across its surface area but only from one side of the rectangle





### Fog

Unity offers three different kinds of fog, linear, exponential, and exponential squared.

Setting | Notes
--- | ---
Color | Change fog color to reflect the mood of your scene. For example white/grey may feel like regular fog, purple fog could seem "magical", while yellow fog may communicate "contamination."
Mode | `Linear` mode increases fog `density` based on a `start` and `end` parameter. `Exponential` mode increases `density`, exponentially, based on distance. Exponential squared increases `density` faster.
Density | The density of the fog, only available in exponential modes.
Fog halo texture | Halo textures are used to draw an effect around objects to simulate a concentration of atmospherics around it. While this can be used for anything, it’s more commonly used to draw the “halo of light” around a light source, or something that simulates a light source (like a light bulb model).
Fog cookie texture | [Cookie textures](https://docs.unity3d.com/Manual/Cookies.html) are used as masks in lighting to simulate the frames of windows or other shadows of silhouettes reflected on surfaces.


### Fog notes & references

- An often overlooked requirement: To be drawn, fog needs an object behind it. If no object is found, the game will draw the empty background (using either the camera’s background color, or the scene’s sky). Avoiding this is very easy, though. All you have to do is create a big plane that covers the entire camera’s field of vision, so there’s something to draw fog on top of.
- You must switch to the [HDRP](https://unity.com/how-to/getting-started-high-definition-render-pipeline-hdrp-games) to use [volumetric fog](https://learn.unity.com/tutorial/creating-volumetric-fog-19)
- [Catlike Coding - Rendering 14 - Fog](https://catlikecoding.com/unity/tutorials/rendering/part-14/), Unity 5.5
- [Taking a look at Unity Fog](https://magazine.renderosity.com/article/5204/taking-a-look-at-unity-fog), Unity 2019
- Fog examples [Islands](https://carlburton.itch.io/islands); this presentation on fog at GDC, [Creating the Art of ABZU](https://www.youtube.com/watch?v=l9NX06mvp2E&lc=UgwWzcN89QNIX2tywXx4AaABAg&ab_channel=GDC) [google](https://www.google.com/search?q=fog+in+unity+2019&tbm=isch&ictx=1&tbs=rimg:Ccpsg4JjRmFaIgjKbIOCY0ZhWioSCcpsg4JjRmFaERYmXh2YOZ7l&safe=off&hl=en&sa=X&ved=2ahUKEwjMvLPIreTrAhUOVFMKHYLcCYcQiRx6BAgAEAQ&biw=1440&bih=766)


### More information about graphics in Unity

- [How to get Good Graphics in Unity](https://www.youtube.com/watch?v=owZneI02YOU&ab_channel=Brackeys) (8:13)
- [Realtime Lighting in Unity](https://www.youtube.com/watch?v=wwm98VdzD8s&ab_channel=Brackeys) (15:47)
- [Linear or gamma workflow](https://docs.unity3d.com/Manual/LinearRendering-LinearOrGammaWorkflow.html)






## Rendering Pipelines


### Introduction

Currently (October 2020), Unity makes available three different rendering pipelines. There are specific differences in how you use lighting, materials, shaders depending on which rendering pipeline you use. As you look for resources and information on lighting consider that these pipelines use different lighting models which make their settings and shaders incompatible. While you can change which pipeline your project uses at any time, it is **much** easier to create a new project and have Unity automatically set all the pipeline options when you start development.



### Universal Rendering Pipeline (URP)

The [Universal Rendering Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/) (URP) (formerly known as the [Lightweight Render Pipeline](https://docs.unity3d.com/Packages/com.unity.render-pipelines.lightweight@6.5/manual/index.html) (LWRP)) is a prebuilt Scriptable Render Pipeline, made by Unity. The technology offers graphics that [can scale to any platform](https://blogs.unity3d.com/2020/02/10/achieve-beautiful-scalable-and-performant-graphics-with-the-universal-render-pipeline/) (mobile to higher-end consoles and PCs). URP uses simplified, physically based Lighting and Materials and is the new default rendering pipeline for all projects in Unity, replacing the older, built in renderer.

- Unity Tutorial: [Introduction to URP](https://learn.unity.com/tutorial/introduction-to-urp)


### High Definition Render Pipeline (HDRP)

If you are still learning Unity you should use the Universal Rendering Pipeline (URP).
