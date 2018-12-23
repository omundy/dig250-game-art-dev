using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionState : MonoBehaviour {

    public LayerMask collisionLayer;
    public bool standing;
    public Vector2 bottomPosition = Vector2.zero;
    public float collisionRadius = 10f;
    public Color debugCollisionColor = Color.red;

    private void FixedUpdate()
    {
        var pos = bottomPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        // is there overlap?
        standing = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = debugCollisionColor;

        var pos = bottomPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;

        Gizmos.DrawWireSphere(pos,collisionRadius);
    }

}
