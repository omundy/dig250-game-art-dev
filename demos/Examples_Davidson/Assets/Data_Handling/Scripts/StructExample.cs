using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct NPC
{
    // fields
    public string Title;
    public bool GoodGuy;
    // constructor
    public NPC(string _Title, bool _GoodGuy)
    {
        Title = _Title;
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
        structDict.Add("badguy1", new NPC("Dr. Evil", false));
        print("StructExample -> structDict['badguy1'].Title = " + structDict["badguy1"].Title);

    }


}
