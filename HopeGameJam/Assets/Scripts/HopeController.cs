using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Weak Baby Man
// OTHER EDITORS:
// DESC:
// DATE MODIFIED: 1/16/2021
// ===============================

public class HopeController : MonoBehaviour
{
    LightController light;
    // help
    void Start()
    {
        light = LightController.GetComponent<LightController>();
    }
    // dont cri dont cri dont cri dont cri dont criiiiiiiiiiiiiiiiii
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameobject.tag == "Player")
        {
            light.StartCoroutine(DimLights);
            this.GameObject.SetActive(False);
        }
    }
}