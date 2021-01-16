using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;
using System;

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
        while (radius > 0)
        {
            radius -= 0.1f;
            hopeLight.pointLightOuterRadius = radius;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
