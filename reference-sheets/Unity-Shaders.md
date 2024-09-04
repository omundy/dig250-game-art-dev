<!-- paginate: true -->

[<](../README.md)

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

# Unity + Shaders


<!--
Presentation comments ...
-->


---

## Introduction

- A shader is a set of graphics and image manipulation instructions run on the GPU
- A CPU runs serial operations while a GPU runs parallel operations (at the same time=faster)


---

## Shader Types

1. Vertex - Draws the vertices of the geometry
1. Geometry - Use to manipulate the geometry
1. Pixel (or fragment) - Fills the area in the geometry (fragment contributes to the final color of the pixel)
1. Compute - General purpose (outside of the shader pipeline)
1. Tesselation / Hull - Used to subdivide a mesh (fixed function shaders embedded in the hardware)



---

## Basic Operation

If you draw an object, say a triangle, on the screen...

1. First you draw the vertices
1. Mesh then primitives



---

## Vertex Shaders

---

## Pixel Shaders



---

## References

Tutorial Series

- Wilmer Lin [Unity SHADERGRAPH](https://www.youtube.com/watch?v=xj3Wm1EclAw&list=PL-05SQhI5rIZszELEnlWowy0L0nskmcF0&ab_channel=WilmerLinGASchool)
- [What is a shader? (Shaderdev.com)](https://www.youtube.com/watch?v=V0E5WH7JRLo&ab_channel=ChayanVinayak)


Topics

- [How to create a gradient with Unity's Shader Graph?](https://abbabon.github.io/2020-07-22-shader-graph-gradient/) 2020
- Brackeys [Basics of Shader Graph](https://www.youtube.com/watch?v=Ar9eIn4z6XE&t=63s&ab_channel=Brackeys)
