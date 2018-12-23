using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Button state.
/// </summary>
public class ButtonState
{
    public float value;
    public float holdTime = 0;
}

/// <summary>
/// Directions.
/// </summary>
public enum Directions
{
    Right = 1,
    Left = -1
}

public class InputState : MonoBehaviour
{
    public Directions direction = Directions.Right;
    public float absValX = 0f;
    public float absValY = 0f;

    private Rigidbody2D body2d;


    /// <summary>
    /// The button states.
    /// </summary>
    private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();

    private void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        absValX = Mathf.Abs(body2d.velocity.x);
        absValY = Mathf.Abs(body2d.velocity.y);
    }


    /// <summary>
    /// Sets the button value.
    /// </summary>
    /// <param name="key">Key.</param>
    /// <param name="value">If set to <c>true</c> value.</param>
    public void SetButtonValue(Buttons key, float value)
    {
        // before setting make sure it exists
        if (!buttonStates.ContainsKey(key))
            buttonStates.Add(key, new ButtonState());
        // now set value of state, get reference
        var state = buttonStates[key];
        if(state.value > 0 || state.value < 0)
        {
            state.holdTime += Time.deltaTime;
            //print("Button " + key + " down " + state.holdTime + "," + state.value);
        }
        else  // reset it
        {
            state.holdTime = 0;
            //print("Button " + key + " release " + state.holdTime + "," + state.value);
        }
        state.value = value;
    }

    /// <summary>
    /// Gets the button value out of input state for keys being pressed.
    /// </summary>
    /// <returns><c>true</c>, if button value was gotten, <c>false</c> otherwise.</returns>
    /// <param name="key">Key.</param>
    public float GetButtonValue(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].value;
        else
            return 0;
    }


    public float GetButtonHoldTime(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
            return buttonStates[key].holdTime;
        else
            return 0;
    }

}
