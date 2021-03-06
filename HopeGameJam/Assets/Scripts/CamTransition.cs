﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Lucas Ferreira
// OTHER EDITORS: 
// DESC: Boundary/move logic for the
// main camera
// DATE MODIFIED: 1/15/2021
//
// *Derived from BenBonks' Celeste
// Camera Follow-Unity Cinemachine
// Tutorial*
// ===============================


public class CamTransition : MonoBehaviour
{

    public GameObject cam;

    //Switch when entering room
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            cam.SetActive(true);
        }
    }
    //Switch when leaving room
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            cam.SetActive(false);
        }
    }
}
