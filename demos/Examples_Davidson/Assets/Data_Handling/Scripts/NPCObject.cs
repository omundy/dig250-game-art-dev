using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// Base object for all NPCs
public class NPCObject : MonoBehaviour
{
    // fields
    public int id;
    public string Name;
    public bool GoodGuy;
    public int encounters; // number of encounters 

    // managers
    CharacterController controller;
    GameObject NPCManager;
    NPCRelationshipManager NPCRelationshipManager;
    public GameObject textObject;
    TMP_Text textComponent;

    // constructor
    public void Initialize(int _id, string _Name, bool _GoodGuy)
    {
        id = _id;
        Name = _Name;
        GoodGuy = _GoodGuy;
        gameObject.name = Name;
        encounters = 0;
    }

    void Awake()
    {
        // get references
        controller = GetComponent<CharacterController>();
        textComponent = textObject.GetComponent<TMP_Text>();
        NPCManager = GameObject.Find("NPCManager");
        NPCRelationshipManager = NPCManager.GetComponent<NPCRelationshipManager>();
    }

    void Update()
    {
        // update text
        textComponent.text = Name + ": " + encounters.ToString();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // ignore self collision
        if (hit.gameObject.GetInstanceID() == gameObject.GetInstanceID()) return;

        // if we touched an NPC
        if (hit.gameObject.tag == "NPC")
        {
            // print(gameObject.name + " hit " + hit.gameObject.name);

            // update encounters 
            encounters++;

            // let relationship manager handle data
            NPCRelationshipManager.UpdateRelationship(gameObject, hit.gameObject);
        }
    }


}
