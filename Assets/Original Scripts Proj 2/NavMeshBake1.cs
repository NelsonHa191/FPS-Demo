using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBake1 : MonoBehaviour
{

    [SerializeField] NavMeshSurface navMeshSurface;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChaseEverywhere.chase == true)
        {
            navMeshSurface.BuildNavMesh();
        }
    }
}
