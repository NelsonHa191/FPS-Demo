using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "EnemyBullet")
        {
            Destroy(Col.gameObject);
        }
    }
}
