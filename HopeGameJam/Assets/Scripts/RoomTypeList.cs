using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTypeList : MonoBehaviour
{
    // public game object lists to store each type of room that have the specified entrances
    public GameObject[] LeftRooms;
    public GameObject[] RightRooms;
    public GameObject[] TopRooms;
    public GameObject[] BottomRooms;

    public List<GameObject> roomList;
}
