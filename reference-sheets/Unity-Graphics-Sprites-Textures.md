

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Graphics > Sprites and Textures


##### Table of Contents  
- [Terms](#terms)
- [Sprites](#sprites)
- [Textures](#textures)



### Terms

Term | Definition
--- | ---
[Texture](https://docs.unity3d.com/Manual/Textures.html) | Any bitmap image in Unity. Can be added to a scene directly by setting its mode to sprite, or by placing it on a [Material](https://docs.unity3d.com/Manual/Materials.html) and attaching it to a 3D object.
[Sprite](https://docs.unity3d.com/Manual/Sprites.html) | A bitmap image that can be used directly in a (usually 2D) game. Can be repositioned, scaled, and rotated like any other game object in Unity. All Sprites in your Scene contain at least the Transform and Sprite Renderer components.
[Sprite Renderer](https://docs.unity3d.com/Manual/class-SpriteRenderer.html) | The component that renders 2D sprites and controls how they appear in the scene. The Sprite property of a SpriteRenderer determines which sprite will be shown in the game and can be manipulated in code.
Sprite Sheet | A texture (bitmap image) containing multiple, smaller images, usually frame-by-frame animations, for 2D games. By packing multiple files into a single texture it reduces the number of images that must be drawn in each frame (a.k.a. "draw calls") thus increasing performance. [View examples](https://www.google.com/search?q=sprite+sheet&safe=off&tbm=isch).
Texture Atlas | A texture (bitmap image) containing multiple, smaller images, usually tileable textures for walls and other environmental components for 3D games. Essentially the same as a sprite sheet but used in different contexts. [View examples](https://www.google.com/search?q=texture+atlas&safe=off&tbm=isch).
Lossy | When a file is compressed and data is lost (i.e. it loses quality). Lossless is when every single bit of data remains. Lossy compression results in smaller file sizes but again, with a loss in quality.
Pixels Per Unit (PPU) | Pixels per unit is a sprite import setting that determines the relationship between pixels (the image scale) and Unity's units. For pixel art you typically use a low PPU, allowing you to easily snap tiles together in a scene, while you want a higher PPU for high resolution graphics. The default is 100.



### Power of 2

Ideally, [Texture dimension sizes](https://docs.unity3d.com/Manual/ImportingTextures.html#TextureSizes) should be powers of two on each side. This ensures hardware can efficiently compress images in your game, decreasing required memory thus increasing overall performance. The Textures do not have to be square; that is the width can be different from height.

Power | 2<sup>1</sup> | 2<sup>2</sup> | 2<sup>3</sup> | 2<sup>4</sup> | 2<sup>5</sup> | 2<sup>6</sup> | 2<sup>7</sup> | 2<sup>8</sup> | 2<sup>9</sup> | 2<sup>10</sup> | 2<sup>11</sup> | 2<sup>12</sup>
--- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | ---
Pixels | 2 | 4 | 8 | 16 | 32 | 64 | 128 | 256 | 512 | 1024 | 2048 | 4096





### Unity image formats

Type | Lossless | Alpha | Description
--- | :--- | --- | ---
PNG | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | Commonly used on the web. Lossless compression; has an alpha channel.
JPG | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | Commonly used on the web. Lossy compression; no alpha channel.
GIF | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | Commonly used on the web. Lossy compression; no alpha channel.
BMP | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | Default image format on Windows. No compression; no alpha channel.
TGA | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | Commonly used for 3D graphics; obscure everywhere else. No or lossless compression; has an alpha channel.
TIFF | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | Commonly used for digital photography and publishing. No or lossless compression; no alpha channel.
PICT | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | ![#ff0000](https://placehold.it/15/ff0000/000000?text=+) | Default image format on old Macs. Lossy compression; no alpha channel.
PSD | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | ![#00ff00](https://placehold.it/15/00ff00/000000?text=+) | Native file format for Photoshop. No compression; has an alpha channel. The main reason to use this file format would be the advantage of using Photoshop files directly.








## Sprites


### Terms

Term | Definition
--- | ---
[Sprite Tags](https://docs.unity3d.com/Manual/Tags.html) | Tags help you identify GameObjects for scripting purposes. For example, you might define “Player” Tags for player-controlled characters or items the player can collect in a Scene with a “Collectable” Tag.
[Sprite Sorting Layers](https://docs.unity3d.com/Manual/class-TagManager.html) | Sorting Layers and Order in Layer are used by the Sprite Renderer to determine the render order of sprites in a scene. You can add and arrange Sorting Layers, and change the order of sprites in the layer (both positive and negative values) to affect how sprites overlay. See [this video](https://unity3d.com/learn/tutorials/topics/2d-game-creation/sorting-layers) for a demonstration.
[Layers](https://docs.unity3d.com/Manual/Layers.html) | Layers are most commonly used by Cameras and Lights to render or illuminate only parts of the scene. They can also be used by raycasting to selectively ignore colliders or to create collisions. If you want to change the overlay of Sprites you should use Sorting Layers (above).


### Tools

Tool | Description
--- | ---
[Sprite Editor](https://docs.unity3d.com/Manual/SpriteEditor.html) | A tool for slicing sprite sheets into individual sprites. To use it set Texture Type to Sprite and Sprite Mode to Multiple in the Inspector.
[Sprite Creator](https://docs.unity3d.com/Manual/SpriteCreator.html) | A tool for creating temporary placeholder sprites you can use in your project during development.
[Sprite Packer](https://docs.unity3d.com/Manual/SpritePacker.html) | A tool in Unity to pack individual sprites and increase the performance of your game.






## Textures



### Terms

Term | Definition
--- | ---
[UV mapping](https://en.wikipedia.org/wiki/UV_mapping) | Projecting a 2D image onto a 3D model's surface mapping using UV coordinates. Think about it as either "wrapping" a 3D model with a texture (e.g. 🎁 ), or "unwrapping" or "unfolding" a 3D model to lay it flat onto a 2D texture. See also: [Intro to UV Mapping video](https://www.youtube.com/watch?v=iIvTUDgaXik)
UV coordinates | The coordinates (`U`,`V`) that control where a texture is positioned on an unwrapped 3D model. The letters (`U`,`V`) denote the axes of the 2D texture because (`X`,`Y`,`Z`) are already used to denote the axes of the 3D object in model space.
[Bump map](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterNormalMap.html) | A special kind of texture that adds surface detail. Normal maps can represent fine surface detail much more efficiently than using additional polygons.
[Normal map](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterNormalMap.html) | A type of bump map that adds surface detail such as bumps, grooves, and scratches to a model which catch the light as if they are represented by real geometry.
[Height map](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterNormalMap.html) | A greyscale Texture that stores height data for an object. Each pixel stores the height difference perpendicular to the face that pixel represents.
[Surface normals](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterNormalMap.html) | The vector (a.k.a. "normal") representing a line perpendicular to the angle of an object's surface relative to the light.


![uv map](https://docs.unity3d.com/uploads/Main/BumpMapColourMapAstrellaExample.jpg)

A character texture atlas, and its corresponding normal map texture atlas







### Sources
* [Unity Manual](https://docs.unity3d.com/Manual/index.html) and [Unity Scripting Reference](https://docs.unity3d.com/ScriptReference/index.html)
* Chapter 2 in Ferro, Lauren S., and Francesco Sapio. Unity 2017 Game Development. Packt, 2018.
* Chapter 4 in Hocking, Joseph. Unity in Action: Multiplatform Game Development in C # (2nd Edition). Manning, 2018.
* Chapter 1 in Godbold, Ashley, and Simon Jackson. Mastering Unity 2D Game Development (2nd Edition). Packt, 2016.
* Chapter 3 in Halpern, Jared. Developing 2D Games with Unity. APress, 2019.
