using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] waypoints;  // Array of waypoints
    public float speed = 3f;       // Movement speed
    private int currentWaypointIndex = 0;  // Current waypoint index

    // Update is called once per frame
    void Update()
    {
        if (waypoints.Length == 0) return;

        // Move towards the next waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Check if we have reached the waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            // Move to the next waypoint (looping back to the first waypoint after the last one)
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
