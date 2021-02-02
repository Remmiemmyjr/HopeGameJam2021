using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Lucas Ferreira
// OTHER EDITORS: Emily Berg
// DESC: Simple top down movement
// controller for the player
// DATE MODIFIED: 1/23/2021
// ===============================

public class PlayerMovement : MonoBehaviour
{
    float speed = 5f; 

    Vector2 movement = new Vector2();

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        GetComponent<Rigidbody2D>().velocity = movement.normalized * speed;
    }
}
