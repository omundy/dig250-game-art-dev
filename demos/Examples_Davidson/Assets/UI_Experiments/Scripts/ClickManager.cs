using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    // references
    public Image PanelImage;
    public TMP_Text PanelText;
    public GameObject BottomPanel;

    // logic
    public int ResetAfterInteraction;
    public int InteractionState;

    void Awake()
    {
        PanelImage = BottomPanel.GetComponent<Image>();
    }

    void Update()
    {
        // nothing
        if (InteractionState == 0)
        {
            PanelImage.color = Color.black;
            // PanelText.text = "Click something...";
        }
        // mouse over
        else if (InteractionState == 1)
        {
            PanelImage.color = Color.red;
            // PanelText.text = "MouseOver";
        }
        // click
        else if (InteractionState == 2)
        {
            PanelImage.color = Color.green;
            // PanelText.text = "Click";
        }

        // reset after click
        if (++ResetAfterInteraction > 0)
        {
            PanelText.text = "ClickManager...";
            InteractionState = 0;
        }

    }

    // called from button OnClick() listener
    public void OnClickListener(GameObject go)
    {
        ResetAfterInteraction = -10;
        InteractionState = 2;
        // print("ClickManager.OnClickListener() called");
        PanelText.text = "ClickManager.OnClickListener() called from " + go.name;
    }



}
