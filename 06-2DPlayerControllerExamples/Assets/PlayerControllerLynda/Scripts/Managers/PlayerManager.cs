using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private InputState inputState;
    private Walk walkBehavior;
    private Animator animator;
    private CollisionState collisionState;

    void Awake()
    {
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
    }

    private void Update()
    {
        // idle
        if(collisionState.standing)
        {
            ChangeAnimationState(0);
        }
        // walk / run
        if (inputState.absValX > 0)
        {
            ChangeAnimationState(1);
        }
        // walk / run
        if (inputState.absValY > 0)
        {
            ChangeAnimationState(2);
        }

        animator.speed = walkBehavior.running ? walkBehavior.runMultiplier : 1;
    }

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
    }

} 
