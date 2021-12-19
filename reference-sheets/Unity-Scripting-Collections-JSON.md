

![unity logo](../assets/img/logos/unity-logo-293w.png)

## Reference Sheet - Unity C# Scripting - Collections - JSON

- Storing and using data in multiples and collections


### Terminology

Term | Definition
--- | ---



### JSON

[Many to choose from](https://docs.google.com/spreadsheets/d/1NoIYASJR9uUT-kZxjb54zWX2Lr3EXp8F7t7N62yo7J8/edit#gid=0)

- [JsonUtility](https://docs.unity3d.com/Manual/JSONSerialization.html) - Unity's internal serializer. See also [Persistent Data – How to save your game states and settings | Unite Now 2020](https://youtu.be/uD7y4T4PVk0?t=1051) (05:46 – 18:00)
- [JSON.net](https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347) - A fully-featured JSON serializer (free)
    - Built into Unity
- [EasySave](https://assetstore.unity.com/packages/tools/utilities/easy-save-the-complete-save-data-serialization-asset-768) - Easy to use (not free)





### Using JSON.net with Unity

JSON.net
- A Popular high-performance JSON framework for .NET
- Created by [Newtonsoft](https://www.newtonsoft.com/json)

JSON.net for Unity

- On Github [jilleJr/Newtonsoft.Json-for-Unity](https://github.com/jilleJr/Newtonsoft.Json-for-Unity), forked from [JamesNK/Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) (the original)
- [forum](https://forum.unity.com/threads/json-net-for-unity.200336/), [Asset Store](https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347), [Home Page](https://www.parentelement.com/assets/json_net_unity)


You can use the original (which as of Unity 2020 is built in, though outdated)
See example uses here: https://github.com/sneakaway-studio/tally-tracker-explorer/search?q=JSON


#### Installation

Via [UPM](https://github.com/jilleJr/Newtonsoft.Json-for-Unity/wiki/Installation-via-OpenUPM)

1. In Package Manager, [remove Version Control (only needed for Unity Collaborate anyway) and then the original Newtonsoft reference](https://github.com/jilleJr/Newtonsoft.Json-for-Unity/discussions/135#discussioncomment-1207770).
1. Run `openupm add jillejr.newtonsoft.json-for-unity`


#### Using JSON.net

Add this JSON file

```json
{
    "boss1": {
        "name": "Big Boss #1",
        "health": 100
    },
    "boss2": {
        "name": "Big Boss #2",
        "health": 95
    }
}
```

Add this script as `JsonNetTest.cs` and drag to a gameobject. Drag the above JSON file to it and then press play.

```csharp
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

// create serializable (viewable in Inspector) object to hold data
[System.Serializable]
public class Boss
{
    public string name { get; set; }
    public int health { get; set; }
}

public class JsonNetTest : MonoBehaviour
{
    // reference to json file
    public TextAsset jsonFile;
    public Dictionary<string, Boss> bosses;

    void Awake()
    {
        // create instance of bosses dict and parse json
        bosses = new Dictionary<string, Boss>();
        // parse the string as JObject
        JObject jsonData = JObject.Parse(jsonFile.text);
        Debug.Log("jsonData.Count: " + jsonData.Count);

        // loop through each, accessing it as a string:JToken
        foreach (KeyValuePair<string, JToken> item in jsonData)
        {
            // the key and value
            Debug.Log(item.Key + " => " + item.Value);
            // store the value in the dict by its key
            bosses.Add(item.Key, item.Value.ToObject<Boss>());
        }
    }
}
```





### Sources

- Unity Script Reference:
