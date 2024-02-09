using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchArea : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (ChaseEverywhere.chase == false)
        {
            if (collision.gameObject.tag == "area")
            {
                
                enemyAIPAtrol.playerInSight = true;
                enemyAIPAtrol.sightRange = 1000;

            }

        }
        if (ChaseEverywhere.chase2 == false)
        {
            if (collision.gameObject.tag == "area2")
            {
                enemyAIPAtrol2.sightRange = 1000;

            }

        }
        


    }
    public void OnTriggerExit(Collider collision)
    {
        if (ChaseEverywhere.chase == false)
        {
            if (collision.gameObject.tag == "area")
            {
                
                enemyAIPAtrol.playerInSight = false;
                enemyAIPAtrol.sightRange = 0;

            }
            
        }
        if (ChaseEverywhere.chase2 == false)
        {
            if (collision.gameObject.tag == "area2")
            {
                enemyAIPAtrol2.sightRange = 0;

            }

        }

        if (ChaseEverywhere.chase3 == false)
        {
            if (collision.gameObject.tag == "area3")
            {
                enemyAIPAtrol3.sightRange = 0;

            }

        }
    }
    
}
