using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    // public float to adjust character speed
    public float movementSpeed = 3.0f;

    Vector2 movement = new Vector2();
    Animator animator;
    Rigidbody2D rb2D;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();
        rb2D.velocity = movement * movementSpeed;
    }

    void UpdateState()
    {
		// if player standing still
        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
        }
		// update animator with new movement values
		animator.SetFloat("xDir", movement.x);
		animator.SetFloat("yDir", movement.y);
    }
}
