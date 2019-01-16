using System.Collections;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
[RequireComponent(typeof (CircleCollider2D))]
[RequireComponent(typeof (Animator))]
public class Wander : MonoBehaviour {

	// the speed the enemy pursues player
	public float pursuitSpeed;
	// general wandering speed
	public float wanderSpeed;
	// current speed
	float currentSpeed;

	// how often the enemy should change wandering direction
	public float directionChangeInterval;
	// whether or not this enemy will follow player
	public bool followPlayer;

	// reference to coroutine to be able to stop it	
	Coroutine moveCoroutine;

	Rigidbody2D rb2d;
	Animator animator;
	// transform to follow character
	Transform targetTransform = null;
	// destination where the enemy is wandering
	Vector3 endPosition;
	// used to pick a new direction
	float currentAngle = 0;

	void Start()
	{
		animator = GetComponent<Animator>();
		currentSpeed = wanderSpeed;
		rb2d = GetComponent<Rigidbody2D>();
		StartCoroutine(WanderRoutine());
	}

	// wander algorithm
	public IEnumerator WanderRoutine()
	{
		// enemy should wander indefinitely
		while(true){
			// choose a new endpoint
			ChooseNewEndpoint();
			// check if enemy already moving
			if(moveCoroutine != null){
				// stop current coroutine if so
				StopCoroutine(moveCoroutine);
			}
			// start coroutine and save reference to it
			moveCoroutine = StartCoroutine(Move(rb2d,currentSpeed));
			// interval between new directions
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	// choose a new endpoint at random for enemy
	void ChooseNewEndpoint(){
		// add random value between 0-360 to current angle
		currentAngle += Random.Range(0,360);
		// loop the value so its between 0-360
		currentAngle = Mathf.Repeat(currentAngle, 360);
		// convert angle to vector3 and add result
		endPosition += Vector3FromAngle(currentAngle);
	}

	// convert degrees to radians
	Vector3 Vector3FromAngle(float inputAngleDegrees){
		// convert input angle from degrees to radians 
		// by multiplying by the degrees-to-radians constant 
		float inputAngleRadians = inputAngleDegrees * Mathf.Deg2Rad;
		// create normalized directional vector for enemy direction
		return new Vector3(Mathf.Cos(inputAngleRadians), Mathf.Sin(inputAngleRadians),0);
	}

	// move the Rigidbody2D at a given speed from current to endPosition
	public IEnumerator Move(Rigidbody2D rigidBodyToMove, float speed)
	{
		// get the distance between the two Vector3 positions
		// using a quick Vector magnitude calculation
		float remainingDistance = (transform.position - endPosition).sqrMagnitude;

		// check that remaining distance is greater than zero
		while (remainingDistance > float.Epsilon){
			// if the enemy is "in pursuit" the targetTransform will be set
			// to the player's transform, which is constantly updated
			if(targetTransform != null){
				endPosition = targetTransform.position;
			}
			// Rigidbody2D is required
			if(rigidBodyToMove != null){
				// set animation parameter to change animation
				animator.SetBool("isWalking",true);
				// calculates movement using variable fields
				Vector3 newPosition = Vector3.MoveTowards(
					rigidBodyToMove.position, endPosition, speed * Time.deltaTime
				);
				// move the Rigidbody2D to new position
				rb2d.MovePosition(newPosition);
				// update distance
				remainingDistance = (transform.position - endPosition).sqrMagnitude;
			}
			// wait for next fixed frame update (presumably for physics)
			yield return new WaitForFixedUpdate();
		}
		// enemy has reached end position so set animation state
		animator.SetBool("isWalking",false);
	}

	// if player walks into enemy's "trigger collider"
	void OnTriggerEnter2D(Collider2D collision)
	{
		// check that the trigger is the player and followPlayer is set
		if(collision.gameObject.CompareTag("Player") && followPlayer){
			// update current speed
			currentSpeed = pursuitSpeed;
			// set the target to the player's transform
			targetTransform = collision.gameObject.transform;
			// stop current movement
			if(moveCoroutine != null){
				StopCoroutine(moveCoroutine);
			}
			// call move again
			moveCoroutine = StartCoroutine(Move(rb2d,currentSpeed));
		}
	}
	// if player exits enemies "trigger collider"
	void OnTriggerExit2D(Collider2D collision)
	{
		// check that the trigger is the player
		if(collision.gameObject.CompareTag("Player")){
			// make enemy look confused by pausing it for a moment
			animator.SetBool("isWalking", false);
			// update current speed
			currentSpeed = wanderSpeed;
			// stop current movement
			if(moveCoroutine != null){
				StopCoroutine(moveCoroutine);
			}
			// since it is no longer following the player, set to null
			// so that above logic can be used
			targetTransform = null;
		}
	}

}
