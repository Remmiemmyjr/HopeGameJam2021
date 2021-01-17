using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Weak Baby Man
// OTHER EDITORS: Emily Berg
// DESC:
// DATE MODIFIED: 1/16/2021
// ===============================

public class HopeController : MonoBehaviour
{
    LightController lightController;

    // help
    void Start()
    {
        //Locating the first object tagged as "Player" in the scene
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        //Finding the child on player that has the script LightController so we arent checking every single child object
        lightController = player.transform.GetComponentInChildren<LightController>();
    }
    // dont cri dont cri dont cri dont cri dont criiiiiiiiiiiiiiiiii
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("Collided");
            StartCoroutine(lightController.DimLights());
        }
    }
}