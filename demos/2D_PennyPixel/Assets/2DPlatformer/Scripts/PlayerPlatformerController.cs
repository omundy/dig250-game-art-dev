using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

    public float jumpTakeOffSpeed = 7;
    public float maxSpeed = 7;
    public string facing = "right";
    public string previousFacing;
    private Animator animator;

    private void Awake()
    {
        previousFacing = facing;
        animator = GetComponent<Animator>();
    }


    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;
        // set x val of move based on input from player
        move.x = Input.GetAxis("Horizontal");
        // if player jumps
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            // reduce velocity by 1/2 if player releases jump button early
            if (velocity.y > 0)
                velocity.y = velocity.y * 0.5f;
        }

        DetermineFacing(move);

        animator.SetBool("grounded", grounded);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }


    // determine direction of character
    void DetermineFacing(Vector2 move)
    {
        print(move);
        if (move.x < -0.01f)
        {
            facing = "left";
        }
        else if (move.x > 0.01f)
        {
            facing = "right";
        }
        // if there is a change in direction
        if (previousFacing != facing)
        {
            // update direction
            previousFacing = facing;
            // change transform
           transform.Rotate(0, 180, 0);
        }
        print(facing);
    }



}
