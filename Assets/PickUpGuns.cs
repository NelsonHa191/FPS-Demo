using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGuns : MonoBehaviour
{
    public int slot = 0;
    public GameObject Pistol;
    public GameObject RPG;
    public bool hasPistol = false;
    public bool hasRPG = false;
    public ProjectileGunPistol scriptPistol;
    public ProjectileGunRPG scriptRPG;
    public float switchWeapon;
    public Image pistolimage;
    public Image rpgimage;
    // public TextMeshProUGUI weapons; old idea


    private void Start()
    {
        Pistol.SetActive(false);
        RPG.SetActive(false);
        scriptPistol.enabled = false;
        scriptRPG.enabled = false;
        pistolimage.enabled = false;
        rpgimage.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Pistol"))
        {
            hasPistol = true;
            collision.gameObject.SetActive(false);
        }
        if (collision.collider.CompareTag("RPG"))
        {
            hasRPG = true;
            collision.gameObject.SetActive(false);
        }
        if (collision.collider.CompareTag("AmmoBox"))
        {
            ProjectileGunPistol.ammo += 1;
            collision.gameObject.SetActive(false);
        }

    }

    private void Update()
    {
       // if (weapons != null)
          //  weapons.SetText(slot + " weapons collected"); looks boring 



        if ((Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E)) && hasPistol == true && hasRPG == true)
        {
            
            if (slot == 2)
            {
                slot--;
                Invoke ("Equip", switchWeapon);
            }
            else if (slot == 1)
            {
                slot++;
                Invoke ("Equip", switchWeapon);
            }
        }

        if (hasPistol == true && hasRPG == true)
        {
            pistolimage.enabled = true;
            rpgimage.enabled = true;
        }

        if (hasPistol == true && hasRPG == false)
        {
            pistolimage.enabled = true;
            rpgimage.enabled = false;
            slot = 1;
            Equip();

        }

        if (hasPistol == false && hasRPG == true)
        {
            pistolimage.enabled = false;
            rpgimage.enabled = true;
            slot = 2;
            Equip();
        }

        if (hasPistol == false && hasRPG == false)
        {
            slot = 0;
            Equip();
        }
    }

    private void Equip()
    {
        if (slot == 0)
        {
            Pistol.SetActive(false);
            RPG.SetActive(false);
            scriptPistol.enabled = false;
            scriptRPG.enabled = false;
        }

        if (slot == 1)
        {
            Pistol.SetActive(true);
            RPG.SetActive(false);
            scriptPistol.enabled = true;
            scriptRPG.enabled = false;
        }
        if (slot == 2)
        {
            Pistol.SetActive(false);
            RPG.SetActive(true);
            scriptPistol.enabled = false;
            scriptRPG.enabled = true;
        }
    }
}
