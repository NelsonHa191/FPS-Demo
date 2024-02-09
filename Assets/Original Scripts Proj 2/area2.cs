using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class area2 : MonoBehaviour
{
    NavMeshAgent agent;
    public NavMeshSurface surface;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChaseEverywhere.chase == true)
        {

            int area = agent.areaMask;
            
        }
    }
}
