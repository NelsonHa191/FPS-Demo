using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    public GameObject winnner;
    public GameObject quit;
    public AudioSource bgmusic;
    public AudioSource winwin;



    private void Start()
    {
        bgmusic.Play();
        winnner.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            winnner.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
            bgmusic.Stop();
            winwin.Play();
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
