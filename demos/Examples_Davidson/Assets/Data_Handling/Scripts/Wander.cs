using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Wander : MonoBehaviour
{
    public float speed = 5;
    public Vector3 direction;
    // use CharacterController for movement
    // note: Do not mix with RigidBody
    // https://forum.unity.com/threads/proper-collision-detection-with-charactercontroller.292598/#post-1938868
    CharacterController controller;

    void Awake()
    {
        // get character controller
        controller = GetComponent<CharacterController>();
        // start with fresh direction
        NewDirection();
    }

    void Update()
    {
        // face towards direction
        transform.rotation = Quaternion.LookRotation(direction);
        // move with character controller
        controller.SimpleMove(direction * speed);
    }

    void NewDirection()
    {
        // pick new random direction vector
        direction = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // ignore self collision
        if (hit.gameObject.GetInstanceID() == gameObject.GetInstanceID()) return;

        // if we touched a wall or NPC
        if (hit.gameObject.tag == "Wall" || hit.gameObject.tag == "NPC")
        {
            // get a new direction
            NewDirection();
            // print(gameObject.name + " hit " + hit.gameObject.name);
        }
    }

}