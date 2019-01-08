using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		// get the position of our character
		var x = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		var y = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * speed;

		// set the position of character w/RidigBody2D
		rigidBody.MovePosition(new Vector2(x,y));
    }
}
