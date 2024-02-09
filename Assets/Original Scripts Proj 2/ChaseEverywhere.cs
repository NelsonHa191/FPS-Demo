using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseEverywhere : MonoBehaviour
{
    public static bool chase = false;
    public static bool chase2 = false;
    public static bool chase3 = false;
    public GameObject delete1;
    public GameObject delete2;
    public GameObject delete3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "treasure1")
        {
            chase = true;
            enemyAIPAtrol.sightRange = 1000;
            delete1.gameObject.SetActive(false);
            

        }
        if (other.gameObject.tag == "treasure2")
        {
            chase2 = true;
            enemyAIPAtrol2.sightRange = 1000;
            delete2.gameObject.SetActive(false);


        }
        if (other.gameObject.tag == "treasure3")
        {
            chase3 = true;
            enemyAIPAtrol3.sightRange = 1000;
            delete3.gameObject.SetActive(false);


        }
    }
}
