using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

	// public float to adjust character speed
	public float movementSpeed = 3.0f;
	
	Vector2 movement = new Vector2();
	Animator animator;
	string animationState = "AnimationState";
	Rigidbody2D rb2D;

	enum CharStates{
		walkEast = 1,
		walkSouth = 2,
		walkWest = 3,
		walkNorth = 4,
		idleSouth = 5
	}

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateState();
	}

	void FixedUpdate()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
	
		movement.Normalize();
		rb2D.velocity = movement * movementSpeed;
	}

	void UpdateState(){
		if (movement.x > 0){
			animator.SetInteger(animationState, (int)CharStates.walkEast);
		} 
		else if (movement.x < 0){
			animator.SetInteger(animationState, (int)CharStates.walkWest);
		}
		else if (movement.y > 0){
			animator.SetInteger(animationState, (int)CharStates.walkNorth);
		}
		else if (movement.y < 0){ 
			animator.SetInteger(animationState, (int)CharStates.walkSouth);
		}
		else {
			animator.SetInteger(animationState, (int)CharStates.idleSouth);
		}
	}
}
