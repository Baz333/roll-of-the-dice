using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;
    //public Vector3 walkPoint;
    public Vector3[] waypoints;
    public int currentWaypoint = 0;
    //bool walkPointSet;
    //public float walkPointRange;
    public float sightRange;
    public bool playerInSightRange;

    private void Awake()
    {
        player = GameObject.Find("PlayerCapsule").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        if(!playerInSightRange)
        {
            Patrol();
            Debug.Log("Player not in range");
        } 
        else
        {
            agent.Stop();
            transform.LookAt(player);
            Debug.Log("Player in range");
        }
    }

    private void Patrol()
    {
        /*if(!walkPointSet)
        {
            SearchWalkPoint();
        } else
        {
            agent.SetDestination(walkPoint);
        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        if(distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }*/
        agent.SetDestination(waypoints[currentWaypoint]);
        Vector3 distanceToWaypoint = transform.position - waypoints[currentWaypoint];
        if(distanceToWaypoint.magnitude < 1f)
        {
            currentWaypoint++;
            if(currentWaypoint >= waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }
    }

    private void SearchWalkPoint()
    {
        /*float randomX = Random.Range(-walkPointRange, walkPointRange);
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }*/
    }

}
