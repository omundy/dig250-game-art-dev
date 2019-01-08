using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Buttons
{
    Right,
    Left,
    Up,
    Down,
    A,
    B
}

public enum Condition
{
    GreaterThan,
    LessThan
}

// record the state value of input manager
[System.Serializable]
public class InputAxisState
{
    public string axisName; // the name of the axis
    public float offValue; // axis values return to zero when they are off
    public Buttons button;
    public Condition condition;

    /// <summary>
    /// Gets a value indicating whether this <see cref="T:InputAxisState"/> is value.
    /// </summary>
    /// <value><c>true</c> if value; otherwise, <c>false</c>.</value>
    public float value
    {
        get
        {
            var val = Input.GetAxis(axisName);
            //Debug.Log("axisName: " + axisName + ", val: " + val);
            switch (condition)
            {
                case Condition.GreaterThan:
                    return val;
                case Condition.LessThan:
                    return val;
            }
            return 0;
        }
    }
}

public class InputManager : MonoBehaviour
{

    public InputAxisState[] inputs;
    public InputState inputState;

    void Update()
    {
        //if (inputs.Length > 0) 
            //print(inputs);
        // loop through all the InputAxisStates
        foreach (var input in inputs)
        {
            // set value in InputState class
            inputState.SetButtonValue(input.button, input.value);
        }
    }
}
