using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float threshold;

    public Vector3 spawnPoint;

    [SerializeField] AudioSource KillEnemy;
    [SerializeField] AudioSource DieToEnemy;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < threshold)
        {
            transform.position = spawnPoint;
            GameManager.health -= 1;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PowerUp.Powered == false)
        {
            if (other.gameObject.tag == "Object")
            {
                GameManager.health -= 1;
                DieToEnemy.Play();
            }
        }
        
        if (PowerUp.Powered == true)
        {
            if (other.gameObject.tag == "Object")
            {
                other.gameObject.SetActive(false);
                KillEnemy.Play();
                CollectTreasure.enemyDead += 1;

            }
        }
    }


}
