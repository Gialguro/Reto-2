using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;



public class IA_Cars : MonoBehaviour
{
    private NavMeshAgent agent;
    private int currentWaypoint=0;
    public GameObject[] Waypoints;
   
 
 
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Waypoints[0].transform.position;
    }
 
    void Update () {
       
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("WayPoint")){
            currentWaypoint = (currentWaypoint + 1) % Waypoints.Length;
            agent.speed = Random.Range(7,10);
            agent.destination = (Waypoints[currentWaypoint].transform.position);
            print(gameObject.name+" "+currentWaypoint);
        }
    }

   

   
    
}
