using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSlide : StickToWall {

    public float slideVelocity = -5f;
    public float slideMultiplier = 5f;
    public GameObject dustPrefab;
    public float dustSpawnDelay = -.5f;

    private float timeElapsed = 0;

	override protected void Update () {
        base.Update();

        if (onWallDetected && !collisionState.standing)
        {
            var velY = slideVelocity;
            if (inputState.GetButtonValue(inputButtons[0]) < 0)
            {
                velY *= slideMultiplier;
            }
            body2d.velocity = new Vector2(body2d.velocity.x, velY);

            if (timeElapsed > dustSpawnDelay)
            {
                var dust = Instantiate(dustPrefab);
                var pos = transform.position;
                pos.y += 2;
                dust.transform.position = pos;
                dust.transform.localScale = transform.localScale;
                timeElapsed = 0;
            }
            timeElapsed += Time.deltaTime;
        }
    }

    protected override void OnStick()
    {
        body2d.velocity = Vector2.zero;
    }

    protected override void OffWall()
    {
        timeElapsed = 0;
    }

}
