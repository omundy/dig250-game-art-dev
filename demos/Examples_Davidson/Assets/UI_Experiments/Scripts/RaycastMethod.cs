using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/**
 *  A method for detecting interaction with GameObjects via raycast
 */
public class RaycastMethod : MonoBehaviour
{
    public Ray ray;
    public RaycastHit hit;
    public bool MouseOverGO;
    public TMP_Text PanelText;
    public ClickManager ClickManager;
    public int ResetAfterInteraction;

    void Awake()
    {
        ClickManager = GameObject.Find("ClickManager").GetComponent<ClickManager>();
    }

    void Update()
    {
        // get a ray to check mouse position in world
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            // if the ray hit something
            if (hit.transform != null)
            {
                // if the mouse button was down
                if (Input.GetMouseButtonDown(0))
                {
                    ShowInteraction(2, ".Update() hit detected on " + hit.transform.gameObject.name + " WITH MOUSE BUTTON 0 DOWN");
                }
                else
                {
                    ShowInteraction(1, ".Update() hit detected on " + hit.transform.gameObject.name);
                }
            }
            else
            {
                // ResetAfterInteraction = 1;
                // ClickManager.InteractionState = 0;
                // // else reset
                // PanelText.text = "RaycastMethod...";
            }
        }

        // reset after interaction
        if (++ResetAfterInteraction > 0)
        {
            PanelText.text = "RaycastMethod...";
        }
    }



    /// <summary>Show interaction in the game</summary>
    /// <param name="state">ClickManager.InteractionState</param>
    /// <param name="text">String</param>
    /// <returns>void</returns>
    void ShowInteraction(int state, string text)
    {
        ClickManager.InteractionState = state;
        ResetAfterInteraction = -10;
        // print("RaycastMethod."+ text);
        PanelText.text = "RaycastMethod." + text;
    }



}
