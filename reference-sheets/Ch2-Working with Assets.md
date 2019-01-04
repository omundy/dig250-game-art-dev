

![unity logo](https://raw.githubusercontent.com/omundy/dig250-game-development/master/reference-sheets/images/unity-logo-293w.png)

## Ch2 - Reference Sheet - Working with Assets




### Terminology

Term | Definition
--- | ---
[Texture](https://docs.unity3d.com/Manual/Textures.html) | Any bitmap image in Unity. Can be added to a scene directly by setting its mode to sprite, or by placing it on a [Material](https://docs.unity3d.com/Manual/Materials.html) and attaching it to a 3D object.
[Mesh Renderer](https://docs.unity3d.com/Manual/class-MeshRenderer.html) | The component that displays the geometry and material of a 3D game object.
[Sprite](https://docs.unity3d.com/Manual/Sprites.html) | A bitmap image that can be used directly in a (usually 2D) game. Can be repositioned, scaled, and rotated like any other game object in Unity.
[Sprite Renderer](https://docs.unity3d.com/Manual/class-SpriteRenderer.html) | The component that renders 2D sprites and controls how they appear in the scene.
Sprite Sheet | A texture (bitmap image) containing multiple, smaller images, usually frame-by-frame animations, for 2D games. By packing multiple files into a single texture it reduces the number of images that must be drawn in each frame (a.k.a. "draw calls") thus increasing performance. [View examples](https://www.google.com/search?q=sprite+sheet&safe=off&tbm=isch).
Texture Atlas | A texture (bitmap image) containing multiple, smaller images, usually tileable textures for walls and other environmental components for 3D games. Essentially the same as a sprite sheet but used in different contexts. [View examples](https://www.google.com/search?q=texture+atlas&safe=off&tbm=isch).
[Sprite Editor](https://docs.unity3d.com/Manual/SpriteEditor.html) | A tool for slicing sprite sheets into individual sprites. To use it set Texture Type to Sprite and Sprite Mode to Multiple in the Inpsector.
[Sprite Creator](https://docs.unity3d.com/Manual/SpriteCreator.html) | A tool for creating temporary placeholder sprites you can use in your project during development.
[Sprite Packer](https://docs.unity3d.com/Manual/SpritePacker.html) | A tool in Unity to pack individual sprites and increase the performance of your game.



https://docs.unity3d.com/Manual/AssetTypes.html
  
  

Image format | The most common image files types are BMP, TIF, TGA, PNG, JPG, and PSD (photoshop file).

  

Each file format serves a different purpose, with different settings, and varying file sizes. For example,

  
  

PNG file formats allow you to have an alpha channel, which allows part of an image to be transparent, where a JPG does not. These are important things to keep in mind when deciding on what image format that you will need to export from your graphics program. We will cover how to import images with alpha channels, as well as



## Power of 2

Ideally, Texture dimension sizes should be powers of two on each side. This ensures that the hardware can compress the image and increases overall performance. The Textures do not have to be square; that is the width can be different from height. [Unity Manual](https://docs.unity3d.com/Manual/ImportingTextures.html#TextureSizes) 

Power | 2<sup>1</sup> | 2<sup>2</sup> | 2<sup>3</sup> | 2<sup>4</sup> | 2<sup>5</sup> | 2<sup>6</sup> | 2<sup>7</sup> | 2<sup>8</sup> | 2<sup>9</sup> | 2<sup>10</sup> | 2<sup>11</sup> | 2<sup>12</sup>
--- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | ---
Pixels | 2 | 4 | 8 | 16 | 32 | 64 | 128 | 256 | 512 | 1024 | 2048 | 4096












