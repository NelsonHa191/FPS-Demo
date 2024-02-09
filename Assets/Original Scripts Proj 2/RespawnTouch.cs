using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTouch : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (PowerUp.Powered == false)
        {
            Player.transform.position = respawnPoint.transform.position;
        }
        
        
    }
}
