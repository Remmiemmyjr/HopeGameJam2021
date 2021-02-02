using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Lucas Ferreira
// OTHER EDITORS: Emily Berg
// DESC: A trigger that will activiate
// a method to reset light raidus
// DATE MODIFIED: 1/16/2021
// ===============================


public class HopeController : MonoBehaviour
{

    LightController lightController;

    // help
    void Start()
    {
        //Locating the first object tagged as "Player" in the scene
        //GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        //Finding the child on player that has the script LightController so we arent checking every single child object
        lightController = GameObject.FindGameObjectWithTag("Player").transform.GetComponentInChildren<LightController>();
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