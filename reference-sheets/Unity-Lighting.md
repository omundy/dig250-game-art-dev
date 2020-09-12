

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Lighting

Lighting in Unity works by approximating how light behaves in the real world.



### Terminology

Term | Definition
--- | ---
[Global illumination](https://docs.unity3d.com/Manual/LightingInUnity.html) | Modeling both direct and indirect lighting to provide realistic lighting. Unity has two global illumination systems, which combine direct and indirect lighting.
Direct light | Light that is emitted, hits a surface once, and is then reflected directly into a sensor (for example, the eye’s retina or a camera). 
Indirect light | All other light, including sky light, that hits several surfaces before being reflected into a sensor. 
Real-time lighting | When Unity calculates lighting at runtime. In Unity, you can use real-time lighting, baked lighting, or a mix of the two.
[Baked Lighting](https://docs.unity3d.com/Manual/LightMode-Baked.html) | Lighting that is calculated in advance. This improves performance but lowers the number of dynamic light effects possible. Unity does this by simulating the lighting bouncing off [static objects](https://docs.unity3d.com/Manual/StaticObjects.html) and storing the result in texture files, which are then layered over the object. 
lightmap | A texture that results from baking indirect lighting ([an example lightmap](https://twitter.com/yuriyodonnell/status/880374951160803328))
shadowmask | A texture that stores the shadows after baking indirect lighting ((an example shadowmask)[https://viktorpramberg.com/baked-lighting])
