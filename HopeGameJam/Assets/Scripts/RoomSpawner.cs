using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: 
// DESC: 
// DATE MODIFIED: 1/15/2021
//
// *Derived from Blackthornprod's
// Random Dungeon Tutorial Series*
// ===============================


public class RoomSpawner : MonoBehaviour
{
    // 
    [Flags] public enum ValidRoom {LEFT = 1, RIGHT = 2, TOP = 4, BOTTOM = 8};

    public ValidRoom needsRoomOfType;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
