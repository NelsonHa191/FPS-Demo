using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunAway : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent = null;
    [SerializeField] private Transform chaser = null;
    [SerializeField] private float displacement = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUp.Powered == true)
        {
            Vector3 normDir = (chaser.position - transform.position).normalized;

            MoveToPos(transform.position - (normDir * displacement));
        }


        
    }

    private void MoveToPos(Vector3 pos)
    {
        agent.SetDestination(pos);
    }
}
