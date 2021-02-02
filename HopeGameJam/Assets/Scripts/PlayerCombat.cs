using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: 
// DESC: Creates a collider on the
// circumference of a circle around
// the player depending on the
// direction of the click, which will
// harm enemies on collision.
// DATE MODIFIED: 1/20/2021
// ===============================


public class PlayerCombat : MonoBehaviour
{

    public LayerMask Enemy;

    public float radius = 0.1f;

    public float rangeScalar = 0.5f;

    Vector3 mousePos;

    Vector3 hitPoint;

    Vector3 playerPos;


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
        playerPos = gameObject.transform.position;
        hitPoint = mousePos - playerPos;
        Collider2D hitCollider = Physics2D.OverlapCircle(hitPoint.normalized * rangeScalar + playerPos, radius, Enemy);
        StartCoroutine(Disable(hitCollider));
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(hitPoint.normalized * rangeScalar + playerPos, radius);
    }

    private IEnumerator Disable(Collider2D hitCollider)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(hitCollider);
        Debug.Log("Disabled Collider");
    }
}
