using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/**
 *  A collection of different listeners that can be attached to GameObjects
 */
public class GameObjectListeners : MonoBehaviour
{
    public Renderer rend;
    public TMP_Text PanelText;
    public bool MouseOverGO;
    public ClickManager ClickManager;
    public int ResetAfterInteraction;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        ClickManager = GameObject.Find("ClickManager").GetComponent<ClickManager>();
    }

    void OnMouseEnter()
    {
        ShowInteraction(1, Color.red, "OnMouseEnter() called from " + gameObject.name);
    }
    void OnMouseOver()
    {
        if (!MouseOverGO) // only let this run once
        {
            MouseOverGO = true;
            ShowInteraction(1, Color.red, "OnMouseOver() called from " + gameObject.name);
        }
    }
    void OnMouseExit()
    {
        MouseOverGO = false;
        ShowInteraction(0, Color.white, "OnMouseExit() called from " + gameObject.name);
    }
    void OnMouseDown()
    {
        ShowInteraction(2, Color.green, "OnMouseDown() called from " + gameObject.name);
    }
    void OnMouseUp()
    {
        ShowInteraction(1, Color.red, "OnMouseUp() called from " + gameObject.name);
    }

    void Update()
    {
        // reset after interaction
        if (++ResetAfterInteraction > 0)
        {
            PanelText.text = "GameObjectListeners...";
        }
    }



    /// <summary>Show interaction in the game</summary>
    /// <param name="state">ClickManager.InteractionState</param>
    /// <param name="color">Color</param>
    /// <param name="text">String</param>
    /// <returns>void</returns>
    void ShowInteraction(int state, Color color, string text)
    {
        ClickManager.InteractionState = state;
        ResetAfterInteraction = -10;
        rend.material.color = color;
        // print("GameObjectListeners." + text);
        PanelText.text = "GameObjectListeners." + text;
    }


}
