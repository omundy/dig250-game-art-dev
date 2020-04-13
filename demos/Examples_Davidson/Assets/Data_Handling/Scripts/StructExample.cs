using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct NPC
{
    // fields
    public int NPCId;
    public string Name;
    public bool GoodGuy;
    // constructor
    public NPC(int _NPCId, string _Name, bool _GoodGuy)
    {
        NPCId = _NPCId;
        Name = _Name;
        GoodGuy = _GoodGuy;
    }
}

public class StructExample : MonoBehaviour
{
    // dictionary of strings
    public Dictionary<string, string> stringDict = new Dictionary<string, string>();
    // dictionary of structs
    public Dictionary<string, NPC> structDict = new Dictionary<string, NPC>();



    void Start()
    {
        // add string and print
        stringDict.Add("greeting", "hello world!");
        print("StructExample -> stringDict['greeting'] = " + stringDict["greeting"]);

        // add struct and print
        structDict.Add("badguy1", new NPC(1, "Dr. Evil", false));
        print("StructExample -> structDict['badguy1'].Name = " + structDict["badguy1"].Name);

    }


}
