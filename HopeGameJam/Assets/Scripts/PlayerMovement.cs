using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Lucas Ferreira
// OTHER EDITORS: 
// DESC: 
// DATE MODIFIED: 1/03/2021
// ===============================

public class PlayerMovement : MonoBehaviour
{
    float speed; // Motion Speed
    public float walk = 5f; // Walk Speed
    public float sprint = 8f; // Sprint Speed
    Vector2 movement = new Vector2();

    void Update()
    {
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
        
        GetComponent<Rigidbody2D>().velocity = movement.normalized * speed;
    }

    void FixedUpdate()
    {
    }
}
