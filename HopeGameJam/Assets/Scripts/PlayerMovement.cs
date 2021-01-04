using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed; // Motion Speed
    public float walk = 5f; // Walk Speed
    public float sprint = 8f; // Sprint Speed
    Vector2 movement = new Vector2();

    void Update()
    {
        /*if (Input.GetKey(KeyCode.W)) // Move Up
        {
            movement.y += 1;
        }
        if (Input.GetKey(KeyCode.S)) // Move Down
        {
            movement.y -= 1;
        }
        if (Input.GetKey(KeyCode.D)) // Move Right
        {
            movement.x += 1;
        }
        if (Input.GetKey(KeyCode.A)) // Move Left
        {
            movement.x -= 1;
        }*/

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprint;
        }
        else
        {
            speed = walk;
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + movement * speed * Time.fixedDeltaTime);
    }
}
