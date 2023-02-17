using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//따라가야 할 waypoint 전달 + 리스트에서 looping

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    
    void Start()
    {
        PrintWaypointName();
    }

    void PrintWaypointName()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
        }
    }
}
