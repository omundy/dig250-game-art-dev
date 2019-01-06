using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : AbstractBehavior {

    public Vector2 jumpVelocity = new Vector2(50, 200);
    public bool jumpingOffWall;
    public float resetDelay = .2f;

    private float timeElapsed = 0;

    private void Update()
    {
        if(collisionState.onWall && !collisionState.standing)
        {
            var canJump = inputState.GetButtonValue(inputButtons[0]);

            if (canJump > 0 && !jumpingOffWall)
            {
                inputState.direction = inputState.direction == Directions.Right ? Directions.Left : Directions.Right;
                body2d.velocity = new Vector2(jumpVelocity.x * (float)inputState.direction, jumpVelocity.y);

                ToggleScripts(false);
                jumpingOffWall = true;
            }
        }

        if (jumpingOffWall)
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed > resetDelay)
            {
                ToggleScripts(true);
                jumpingOffWall = false;
                timeElapsed = 0;
            }
        }
    }


}
