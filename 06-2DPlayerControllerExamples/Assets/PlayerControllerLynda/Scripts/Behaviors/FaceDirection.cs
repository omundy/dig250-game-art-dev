using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : AbstractBehavior
{



    protected override void Update()
    {
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);

        if (right > 0)
        {
            inputState.direction = Directions.Right;
        }
        else if (left < 0)
        {
            inputState.direction = Directions.Left;
        }

        transform.localScale = new Vector3((float)inputState.direction, 1, 1);
    }
}
