

![unity logo](images/unity-logo-293w.png)

## Reference Sheet - Assets & Asset Bundles


### Terminology

Term | Definition
--- | ---
[Serialization](https://docs.unity3d.com/Manual/script-Serialization-BuiltInUse.html) | Unity uses serialization to load and save Scenes, Assets, and AssetBundles to and from your computer’s hard drive. This includes data saved in your own scripting API objects such as MonoBehaviour components and ScriptableObjects. In short, serialization is the process of reading data from files into memory in order to use them in Unity. [Read more](https://sometimesicode.wordpress.com/2015/04/11/unity-serialization-part-1-how-it-works-and-examples/)
[.meta files](https://docs.unity3d.com/Manual/BehindtheScenes.html) | Every time you import an asset into Unity a meta file is created (viewable next to the asset in your operating system). These files contain import settings for the asset, including the unique ID so that Unity can locate the asset during runtime. These files must stay with their assets or any reference to the asset will be broken.
File GUID | The File GUID identifies the Asset file where the target resource is stored. For example a Texture asset.
Local ID | A unique Local ID identifies each Object within an Asset file because an Asset file may contain multiple Objects. For example, a multiple sprites in a Texture asset each have a local ID
Instance ID | Unity internally maintains a cache that translates File GUIDs and Local IDs into simple, session-unique integers. These are called Instance IDs, and are assigned in a simple, monotonically-increasing order when new Objects are registered with the cache.



### Sources
* [A guide to AssetBundles and Resources](https://unity3d.com/learn/tutorials/topics/best-practices/guide-assetbundles-and-resources)


