

<img width="275" src="../assets/img/logos/logo-unity-b-w.png">

## Reference Sheet - Loading Assets

- Assets
- Resources
- Asset Bundles
- Addressables




### Basic Asset Terminology

Term | Definition
--- | ---
Asset | Any file or folder that Unity can use.
[Serialization](https://docs.unity3d.com/Manual/script-Serialization.html) | The process of converting the state of an object to a set of bytes in order to store the object into memory, a database or a file. Unity uses serialization to load and save Scenes, Assets, and AssetBundles to and from your computer’s hard drive. This includes data saved in your own scripting API objects such as MonoBehaviour components and ScriptableObjects. In short, [serialization](https://docs.unity3d.com/Manual/script-Serialization-BuiltInUse.html) is the process of reading data from files into memory in order to use them in Unity. [Read more](https://sometimesicode.wordpress.com/2015/04/11/unity-serialization-part-1-how-it-works-and-examples/)
[Deserialization](https://www.gamasutra.com/blogs/VivekTank/20180731/323248/Introduction_to_Unity_Serialization_and_Game_Data.php) | The reverse process of building an object out of a file, converting text/binary data into usable datatypes in code.
[.meta files](https://docs.unity3d.com/Manual/BehindtheScenes.html) | Every time you import an asset into Unity a meta file is created (viewable next to the asset in your operating system). These files contain import settings for the asset, including the unique ID so that Unity can locate the asset during runtime. These files must stay with their assets or any reference to the asset will be broken.
File GUID | The File GUID identifies the Asset file where the target resource is stored. For example a Texture asset.
Local ID | A unique Local ID identifies each Object within an Asset file because an Asset file may contain multiple Objects. For example, a multiple sprites in a Texture asset each have a local ID
Instance ID | Unity internally maintains a cache that translates File GUIDs and Local IDs into simple, session-unique integers. These are called Instance IDs, and are assigned in a simple, monotonically-increasing order when new Objects are registered with the cache.




### The Resources folder

`/Resources` is a special folder from where you can load assets (even if they’re not referenced in the Scene). For example, `Resources.LoadAll<Sprite>("FolderName")`. Despite offering a useful option for loading assets, using the Resources folder is, generally, not recommended.

Uses
- Prototyping, where performance is less important than being able to rapidly create ideas
- Small projects, relatively few assets, that are not memory intensive, and are unlikely to change between platforms

Problems
- Increased memory usage and a bigger application size: as everything inside the Resources folder is packaged and loaded, whether you need it or not.
- Assets are more difficult to manage: as using filename paths can make it more likely that a connection will be broken if a file name or string is changed.



### Addressables

The Addressable Asset system provides an easy way to load assets by “address”. It handles asset management overhead by simplifying content pack creation and deployment. The Addressable Asset system uses asynchronous loading to support loading from any location with any collection of dependencies. Whether you use direct references, traditional asset bundles, or Resource folders for asset management, Addressable Assets provide a simpler way to make your game more dynamic.

- Unity [Simplify your content management with Addressables](https://unity.com/how-to/simplify-your-content-management-addressables)
- Unity [Getting started with Addressable Assets](https://docs.unity3d.com/Packages/com.unity.addressables@0.4/manual/AddressableAssetsGettingStarted.html)
- [Unity Addressables & SpriteAtlas: How to Efficiently Use Sprites](https://thegamedev.guru/unity-addressables/spriteatlas-save-memory/)
- [Unity Addressables Pooling: Jump In!](https://www.gamasutra.com/blogs/RubenTorresBonet/20191104/353294/Unity_Addressables_Pooling_Jump_In.php), 2019
- [Unity-Technologies/Addressables-Sample](https://github.com/Unity-Technologies/Addressables-Sample)
- [Unity Forum Loading SpriteSheet Sprites With AssetReference](https://forum.unity.com/threads/loading-spritesheet-sprites-with-assetreference.548155/)





### Unity Project Architecture

Folder | Description | Check into source control | Notes
--- | --- | --- | ---
/Assets | Where Unity stores all your project files | ✅ | Do not delete
/Library | Cached files Unity generates when opening your project the first time. | ❌  | It is fine to delete this entire folder (to save space), but do not delete individual files contained within.


### Sources
* [A guide to AssetBundles and Resources](https://unity3d.com/learn/tutorials/topics/best-practices/guide-assetbundles-and-resources)
* [How to change a Sprite from a script in Unity ](https://gamedevbeginner.com/how-to-change-a-sprite-from-a-script-in-unity-with-examples/) (2020)
