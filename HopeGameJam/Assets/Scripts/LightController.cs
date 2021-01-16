using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;
using System;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: 
// DESC: 
// DATE MODIFIED: 1/16/2021
// ===============================

public class LightController : MonoBehaviour
{
    Light2D hopeLight;

    // Start is called before the first frame update
    void Start()
    {
        hopeLight = gameObject.GetComponent<Light2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.F))
        {

            StartCoroutine(DimLights());
        }
    }

    private IEnumerator DimLights()
    {
        var radius = hopeLight.pointLightOuterRadius;
        var intensity = hopeLight.intensity;
        while (intensity > 0 && radius > 0)
        {
            intensity -= 0.001f;
            radius -= 0.005f;
            hopeLight.pointLightOuterRadius = radius;
            hopeLight.intensity = intensity;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
