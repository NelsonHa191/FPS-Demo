using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectTreasure : MonoBehaviour
{
    public int chest;
    public GameObject win;
    public GameObject quit;
    public static int enemyDead;

    [SerializeField] TextMeshProUGUI coinsText;

    [SerializeField] TextMeshProUGUI PowerText;

    [SerializeField] AudioSource treasureSource;

    void Start()
    {
        win.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);   
        enemyDead = 0;
    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "treasure1" || Col.gameObject.tag == "treasure2" || Col.gameObject.tag == "treasure3")
        {
            treasureSource.Play();
            Debug.Log("Treasure Collected!");
            chest += 1;
            Col.gameObject.SetActive(false);
            coinsText.text = "Treasure Chests: " + chest;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (chest == 3)
        {
            PowerUp.Powered = true;
            PowerText.text = "POWERED UP!";
        }

        if (chest == 3 && enemyDead == 3) {
            win.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    IEnumerator Quit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }
}
