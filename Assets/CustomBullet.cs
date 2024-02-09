using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBullet : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;

    public float bounciness;
    public bool useGravity;

    public int explosionDamage;
    public float explosionRange;

    public int maxCollisions;
    public float maxLifetime;
    public bool explodeOnTouch = true;

    public GameObject Kaboom;

    int collisions;
    PhysicMaterial physics_mat;

    private void Start()
    { 
        Setup();
    }

    private void Update()
    {
        if (collisions > maxCollisions)
        {
            Explode();
        }

        maxLifetime -= Time.deltaTime;
        if (maxLifetime <= 0)
        {
            Explode();
        }
    }


    private void Explode()
    {
        
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            
        }
        if (Kaboom != null)
        {
            Instantiate(Kaboom, transform.position, Quaternion.identity);

        }

        /* Collider[] enemies = Physics.OverlapSphere(transform.position, explosionRange, whatIsEnemies);
         for (int i = 0; i < enemies.Length; i++)
         {
             enemies[i].GetComponent<EnemyHealth>().TakeDamage(explosionDamage);
         } */
        Invoke("Delay", 0.05f);
    }

    private void Delay()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisions++;
        
        if (collision.collider.CompareTag("Enemy") && explodeOnTouch)
        {
            Debug.Log("Enemy hit!");
            Explode();
           // Destroy(gameObject);

        }
        if (collision.collider.CompareTag("Environment") && explodeOnTouch)
        {
            Debug.Log("Environment hit!");
            Explode();
            // Destroy(gameObject);
        }
    }


    private void Setup()
    {
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;

        GetComponent<SphereCollider>().material = physics_mat;

        rb.useGravity = useGravity;
    }
}
