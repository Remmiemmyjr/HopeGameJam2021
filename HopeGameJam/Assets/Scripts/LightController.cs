using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;
using System;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: Lucas Ferreira
// DESC: 
// DATE MODIFIED: 1/16/2021
// ===============================

public class LightController : MonoBehaviour
{
    Light2D hopeLight;
    const float maxRadius = 3.5f;
    float currRadius = maxRadius; 
    public float r_modifier = 0.005f;
    
    void Start()
    {
        hopeLight = gameObject.GetComponent<Light2D>();
    }

    void FixedUpdate()
    {
        // Debugger
        if(Input.GetKey(KeyCode.F))
        {
            StartCoroutine(DimLights());
        }
    }

    // Coroutine is not running when script first runs, so boolean is set to false
    bool activeCoroutine = false;

    public IEnumerator DimLights()
    {
        //hopeLight.pointLightOuterRadius = maxRadius;

        // Whatever the current radius is in here, is reset to max radius
        currRadius = maxRadius;
        // All of this ensures that there is not a second co-routine running causing conflicts
        if (!activeCoroutine)
        {
            // Coroutine is running so bool is set to true
            activeCoroutine = true;
            //While the current
            while (currRadius > 0)
            {
                currRadius -= r_modifier;
                hopeLight.pointLightOuterRadius = currRadius;
                yield return new WaitForSeconds(0.01f);
            }
            // Coroutine is done, so bool is reset to false
            activeCoroutine = false;
        }
    }
}