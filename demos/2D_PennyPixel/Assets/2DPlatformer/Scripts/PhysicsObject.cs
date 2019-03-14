using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{

    public float minGroundNormalY = 0.65f;
    public float gravityModifier = 1f;

    protected Vector2 targetVelocity; // store input from outside class
    protected bool grounded;
    protected Vector2 groundNormal;
    protected Vector2 velocity;
    protected Rigidbody2D rb2d;
    protected ContactFilter2D contactFilter;
    protected const float minMoveDistance = 0.001f;
    protected const float shellRadius = 0.01f;
    protected RaycastHit2D[] hitBuffer = new RaycastHit2D[16];
    protected List<RaycastHit2D> hitBufferList = new List<RaycastHit2D>(16);

    private void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // don't detect collissions against filters
        contactFilter.useTriggers = false;
        // use physics2d settings to determine what layers to check against
        contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));
        contactFilter.useLayerMask = true;
    }

    // for character controller
    protected virtual void ComputeVelocity()
    {

    }
    private void Update()
    {
        targetVelocity = Vector2.zero;
        ComputeVelocity();
    }

    private void FixedUpdate()
    {
        if (rb2d)
        {
            // get velocity
            velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
            // get horizontal movement
            velocity.x = targetVelocity.x;
            // reset grounded variable
            grounded = false;
            // apply to object
            Vector2 deltaPosition = velocity * Time.deltaTime;
            // accommodate for slopes
            Vector2 moveAlongGround = new Vector2(groundNormal.y, -groundNormal.x);
            // calculate y movement
            Vector2 move = moveAlongGround * deltaPosition.x;
            Movement(move, false);
            // calculate Y movement
            move = Vector2.up * deltaPosition.y;
            Movement(move, true);
        }

    }


    void Movement(Vector2 move, bool yMovement)
    {
        // use magnitude to determine distance we will move
        float distance = move.magnitude;

        // if it is moving
        if (distance > minMoveDistance)
        {
            // check if our rigidbody2d will overlap
            int count = rb2d.Cast(move, contactFilter, hitBuffer, distance + shellRadius);
            // clear list
            hitBufferList.Clear();
            // copy only indexes from hitBuffer[] that actually hit something
            for (int i = 0; i < count; i++)
            {
                hitBufferList.Add(hitBuffer[i]);
            }
            // check normal of each rayCastHit2d object to determine angle of thing we are colliding with
            for (int i = 0; i < hitBufferList.Count; i++)
            {
                Vector2 currentNormal = hitBufferList[i].normal;
                // only set the player's grounded state, will not allow them to slide down slope
                if (currentNormal.y > minGroundNormalY)
                {
                    grounded = true;
                    if (yMovement)
                    {
                        groundNormal = currentNormal;
                        currentNormal.x = 0;
                    }
                }
                // get difference between velocity and currentNormal to determine whether we need to subtract from velocity
                // to avoid hitting sloped ceiling
                float projection = Vector2.Dot(velocity, currentNormal);
                if (projection < 0)
                {
                    // cancel out the velocity
                    velocity = velocity - projection * currentNormal;
                }

                float modifiedDistance = hitBufferList[i].distance - shellRadius;
                // set distance
                distance = modifiedDistance < distance ? modifiedDistance : distance;
            }
        }

        // set new position
        rb2d.position = rb2d.position + move.normalized * distance;
    }


}
