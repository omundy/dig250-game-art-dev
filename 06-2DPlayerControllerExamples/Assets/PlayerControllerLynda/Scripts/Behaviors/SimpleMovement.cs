using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {

    public float speed = 5f;
    public Buttons[] input;

    private Rigidbody2D body2d;
    private InputState inputState;

	void Start () {
        body2d = GetComponent<Rigidbody2D>();
        inputState = GetComponent<InputState>();
	}

    void Update()
    {

        var right = inputState.GetButtonValue(input[0]);
        var left = inputState.GetButtonValue(input[1]);

        var velX = 0f;

        if (right > 0)
        {
            velX = speed * right;
        }
        else if (left < 0)
        {
            velX = speed * left;
        }

        body2d.velocity = new Vector2(velX, body2d.velocity.y);

    }
}
