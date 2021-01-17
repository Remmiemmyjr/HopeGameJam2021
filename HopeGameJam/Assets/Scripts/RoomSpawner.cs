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
// ===============================


public class RoomSpawner : MonoBehaviour
{
    [Flags] public enum OpeningSide {LEFT = 1, RIGHT = 2, TOP = 4, BOTTOM = 8};

    public OpeningSide typeOfRoom;

    RoomTypeList template;

    const int roomSize = 6;

    private int random;

    int xMap = -1;

    int yMap = -1;

    static GameObject[,] roomMap = new GameObject[roomSize, roomSize];

    static Vector3 heightOffset = new Vector2(0, 10);

    static Vector3 widthOffset = new Vector2(10, 0);
    
    private bool spawned = false;


    private void Start()
    {
        template = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTypeList>();

        // Allows us to call a method with a delay. Collision would not be detected properly if spawned at the same time.
        Invoke("SpawnRooms", 0.1f);
    }
    
    bool CanSpawn(int x, int y)
    {
        // If rooms spawns out of bounds
        if (x < 0 || y < 0 || x >= roomSize || y >= roomSize)
        {
            return false;
        }

        // If theres already a room there
        if (roomMap[x,y] != null)
        {
            return false;
        }

        // If theres no conflicts, room can spawn in passed in location
        return true;
    }

    void SpawnRooms()
    {
        //Debug.Log($"Spawning... {spawned}, {typeOfRoom}");

        // Make sure we only spawn one room in a spot
        if (spawned == false)
        {
            // Identifying the first room with this script (the entry room, already placed)
            if (xMap == -1 || yMap == -1)
            {
                // This room goes in the middle of the map 
                xMap = roomSize / 2;
                yMap = roomSize / 2;
                // adding this to the array
                PlaceRoom(xMap, yMap, this.gameObject);
            }

            // Check if theres anything to the right, to spawn "lefts". Added one to check the next spot in the array
            if (typeOfRoom.HasFlag(OpeningSide.LEFT) && CanSpawn(xMap - 1, yMap))
            {
                // needs to spawn a room of type Right Entrance
                random = UnityEngine.Random.Range(0, template.RightRooms.Length);
                PlaceRoom(xMap - 1, yMap, Instantiate(template.RightRooms[random], transform.position - widthOffset, Quaternion.identity));
            }

            // Check if theres anything to the left, to spawn "rights". Subtract one to check the next prev in the array
            if (typeOfRoom.HasFlag(OpeningSide.RIGHT) && CanSpawn(xMap + 1, yMap))
            {
                // needs to spawn a room of type RIGHT Entrance
                random = UnityEngine.Random.Range(0, template.LeftRooms.Length);
                PlaceRoom(xMap + 1, yMap, Instantiate(template.LeftRooms[random], transform.position + widthOffset, Quaternion.identity));
            }

            // Check if theres anything below, to spawn "tops". Subtract one to check the next prev in the array
            if (typeOfRoom.HasFlag(OpeningSide.TOP) && CanSpawn(xMap, yMap + 1))
            {
                // needs to spawn a room of type TOP entrance
                random = UnityEngine.Random.Range(0, template.BottomRooms.Length);
                PlaceRoom(xMap, yMap + 1, Instantiate(template.BottomRooms[random], transform.position + heightOffset, Quaternion.identity));
            }

            // Check if theres anything above, to spawn "bottoms". Add one to check the next prev in the array
            if (typeOfRoom.HasFlag(OpeningSide.BOTTOM) && CanSpawn(xMap, yMap - 1))
            {
                // needs to spawn a room of type BOTTOM entrance
                random = UnityEngine.Random.Range(0, template.TopRooms.Length);
                PlaceRoom(xMap, yMap - 1, Instantiate(template.TopRooms[random], transform.position - heightOffset, Quaternion.identity));
            }
            spawned = true;
        }
    }

    void PlaceRoom(int xMap, int yMap, GameObject room)
    {
        //Debug.Log($"Place Room: {xMap}, {yMap}");

        // stored the room passed in within our array
        roomMap[xMap, yMap] = room;
        RoomSpawner spawner = room.GetComponent<RoomSpawner>();
        // telling the room where its at (re-setting -1)
        spawner.xMap = xMap;
        spawner.yMap = yMap;
    }
}
