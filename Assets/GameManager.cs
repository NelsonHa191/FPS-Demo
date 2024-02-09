using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver, heart1, heart2, heart3, dead;
    public static int health;
    public GameObject quit;
    public AudioSource loser;

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        dead.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            loser.Play();
        }
 
        switch (health)
        {

            case 3:
                dead.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;

            case 2:
                dead.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;

            case 1:
                dead.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

            case 0:
                dead.gameObject.SetActive(true);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                quit.gameObject.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log("Game Over!");
                Time.timeScale = 0;
                


                break;

            default:
                dead.gameObject.SetActive(true);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                quit.gameObject.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log("Game Over!");
                Time.timeScale = 0;
                



                break;
               
        }
    }
}
