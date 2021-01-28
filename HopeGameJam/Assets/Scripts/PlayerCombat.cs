using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: 
// DESC: 
// DATE MODIFIED: 1/20/2021
// ===============================


public class PlayerCombat : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 hitPoint;
    public float radius = 0.1f;
    public float rangeScalar = 0.5f;
    public LayerMask Enemy;

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;

        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

    }
    void Attack()
    {
        hitPoint = mousePos - gameObject.transform.position;
        Collider2D hitCollider = Physics2D.OverlapCircle(hitPoint.normalized * rangeScalar, radius, Enemy);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(hitPoint.normalized * rangeScalar, radius);
    }
}
