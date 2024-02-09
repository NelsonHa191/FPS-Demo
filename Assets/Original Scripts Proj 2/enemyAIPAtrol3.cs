using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class enemyAIPAtrol3 : MonoBehaviour
{
    GameObject player;

    NavMeshAgent agent;

    public static float sightRange;
    

    [SerializeField] LayerMask groundLayer, playerLayer;

    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    [SerializeField] float attackRange;
    bool playerInSight, playerInAttackRange;
    


    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        
}

    // Update is called once per frame
    void Update()
    {
        if (ChaseEverywhere.chase3 == true)
        {
            playerInSight = true;
            playerInAttackRange = false;

        }
        else
        {
            playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
            playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);
        }

        if (!playerInSight && !playerInAttackRange) Patrol();
        if (playerInSight && !playerInAttackRange && PowerUp.Powered == false) Chase();
        if (playerInSight && playerInAttackRange && PowerUp.Powered == false) Attack();
    }

    void Chase()
    {
        if (PowerUp.Powered == false)
        {
            agent.SetDestination(player.transform.position);
        }
        
    }

    void Attack()
    {

    }

    void Patrol()
    {
        if (!walkpointSet) SearchForDest();
        if (walkpointSet)
        {
            agent.SetDestination(destPoint);

        }
        if(Vector3.Distance(transform.position, destPoint) < 1)
        {
            walkpointSet = false;
        }




    }

    void SearchForDest()
    {
        float z = Random.Range(-range, range);
        float x = Random.Range(-range, range);

        destPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer))
        {
            walkpointSet = true;
        }
    }




}
