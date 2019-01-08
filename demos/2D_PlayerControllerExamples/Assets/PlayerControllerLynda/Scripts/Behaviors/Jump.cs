using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : AbstractBehavior
{

    public float jumpSpeed = 200f;
    public float jumpDelay = .1f;
    public int jumpCount = 2;
    public GameObject dustEffectPrefab;

    protected float lastJumpTime = 0;
    protected int jumpsRemaining = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        var canJump = inputState.GetButtonValue(inputButtons[0]);
        var holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

        if (collisionState.standing)
        {
            // only let them jump if they are on the ground and haven't just jumped
            if (canJump > 0 && holdTime < 0.1f)
            {
                jumpsRemaining = jumpCount -1;
                OnJump();
            }
        }
        else
        {
            // double jump logic
            if (canJump > 0 && holdTime < 0.1f && Time.time - lastJumpTime > jumpDelay)
            {
                if (jumpsRemaining > 0)
                {
                    OnJump();
                    jumpsRemaining --;
                    var clone = Instantiate(dustEffectPrefab);
                    clone.transform.position = transform.position;
                }

            }
        }
    }

    protected virtual void OnJump()
    {
        var vel = body2d.velocity;
        lastJumpTime = Time.time;
        body2d.velocity = new Vector2(vel.x, jumpSpeed);

    }

}
