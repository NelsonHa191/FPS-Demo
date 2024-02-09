using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public AudioSource hurting;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "EnemyBullet")
        {
            hurting.Play(); 
            GameManager.health--;
            Destroy(Col.gameObject);
        }
    }
}
