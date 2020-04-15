using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a struct to hold all the fields in the relationships between NPCs
public struct NPCRelationship
{
    // fields
    public string npc1; // name
    public string npc2; // name
    public string type; // type of relationship
    public float score;
    public float encounters;
    // constructor
    public NPCRelationship(string _npc1, string _npc2, string _type, float _score)
    {
        npc1 = _npc1;
        npc2 = _npc2;
        type = _type;
        score = _score;
        encounters = 1; // default
    }
}

// manager class
public class NPCRelationshipManager : MonoBehaviour
{
    // dictionary of relationships
    public Dictionary<string, NPCRelationship> NPCRelationships = new Dictionary<string, NPCRelationship>();

    // method called when the hit each other
    public void UpdateRelationship(GameObject npc1, GameObject npc2)
    {
        // create a key from both their names (e.g. "NPC3_NPC7" )
        string key = npc1.name + "_" + npc2.name;

        // if NPC not in dictionary
        if (!NPCRelationships.ContainsKey(key))
        {
            // then add it
            NPCRelationships.Add(key, new NPCRelationship(npc1.name, npc2.name, "good", .02f));
        }
        else
        {
            // otherwise update relationship
            NPCRelationship rel = NPCRelationships[key];
            rel.encounters = rel.encounters + 1;
            NPCRelationships[key] = rel;
        }

    }



}
