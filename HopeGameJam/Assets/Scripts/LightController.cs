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
    const float maxRadius = 4f;
    public float r_modifier = 0.005f;
    public float i_modifier = 0.001f;

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
        hopeLight.pointLightOuterRadius = maxRadius;
        var radius = maxRadius;
        var intensity = hopeLight.intensity;
        while (intensity > 0 && radius > 0)
        {
            radius -= r_modifier;
            intensity -= i_modifier;
            hopeLight.pointLightOuterRadius = radius;
            hopeLight.intensity = intensity;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
