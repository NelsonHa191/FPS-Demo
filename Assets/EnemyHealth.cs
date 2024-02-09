using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public AudioSource hitted;
    public AudioSource died;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            hitted.Play();
            health--;
            
            Destroy(collision.gameObject);
        }
        if (collision.collider.CompareTag("RocketBullet"))
        {
            health = 0;
            Destroy(collision.gameObject);
        }
    }

    public void Update()
    {
        if (health <= 0) {
            died.Play();
            WinCondition.enemiesDead++;
            Destroy(gameObject);
        }
    }






    /*private void Start()
    {
        health = 3;
    }

    private void Update()
    {
        switch (health)
        {
            case 3:
                isDead = false;
                break;
            case 2:
                isDead = false;
                break;
            case 1:
                isDead = false;
                break;
            case 0:
                isDead = true;
                Destroy(gameObject);
                break;
            default:
                isDead = true;
                Destroy(gameObject);
                break;
        }
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Bullet")
        {
            Debug.Log("HIT");
            TakeDamage(1);
        }
        if (Col.gameObject.tag == "RocketBullet")
        {
            TakeDamage(3);
        }
        
    } 

   private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.CompareTag("Bullet"))
        {
            TakeDamage(1);
        }
        if (collision.collider.CompareTag("RocketBullet"))
        {
            TakeDamage(3);
        }
    }


    public void TakeDamage(int damage)
    {
        if (damage == 1)
        {
            health -= 1;
        }
        if (damage == 3)
        {
            health -= 3;
        }
        if (health == 0)
        {
            isDead = true;
        } else
        {
            isDead = false;
        }
    }*/
}
