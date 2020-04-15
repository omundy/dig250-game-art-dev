using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// responsible for adding and initializing NPCs
public class NPCObjectManager : MonoBehaviour
{
    public int NPCCount;
    public GameObject NPCPrefab;

    void Start()
    {
        // instantiate, then initialize all NPCs
        for (int i = 0; i < NPCCount; i++)
        {
            // instantiate GameObject
            NPCObject NPC = Object.Instantiate(NPCPrefab, Vector3.zero, Quaternion.identity).GetComponent<NPCObject>();
            // call initialize function on NPCObject
            NPC.Initialize(i, "NPC" + i, false);
        }

    }

}
