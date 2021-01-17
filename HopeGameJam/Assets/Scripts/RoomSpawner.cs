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
    // words 
    [Flags] public enum ValidRoom {LEFT = 1, RIGHT = 2, TOP = 4, BOTTOM = 8};

    public ValidRoom needsRoomOfType;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (needsRoomOfType)
        {
            case ValidRoom.LEFT:
                // needs to spawn a room of type LEFT Entrance
                break;
            case ValidRoom.RIGHT:
                // needs to spawn a room of type RIGHT Entrance
                break;
            case ValidRoom.TOP:
                // needs to spawn a room of type TOP entrance
                break;
            case ValidRoom.BOTTOM:
                // needs to spawn a room of type BOTTOM entrance
                break;
        }
    }
}
