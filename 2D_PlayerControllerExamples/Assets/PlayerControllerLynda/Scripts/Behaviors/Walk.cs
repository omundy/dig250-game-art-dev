using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior
{

    public float speed = 50f;
    public float runMultiplier = 2f;
    public bool running;


    // Update is called once per frame
    void Update()
    {
        running = false;
        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var run = inputState.GetButtonValue(inputButtons[2]);
        var velX = 0f;

        if (right > 0 || left < 0)
        {
            var tmpSpeed = speed;

            if (right > 0)
                tmpSpeed *= right;
            else if (left < 0)
                tmpSpeed *= left;

            if (run > 0 && runMultiplier > 0)
            {
                tmpSpeed *= runMultiplier;
                running = true;
            }

            velX = tmpSpeed;

            body2d.velocity = new Vector2(velX, body2d.velocity.y);

        }
    }
}
