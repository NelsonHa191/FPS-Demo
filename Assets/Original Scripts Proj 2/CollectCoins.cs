using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoins : MonoBehaviour
{
    public int chest;
    public GameObject win;


    [SerializeField] TextMeshProUGUI coinsText;

    void Start()
    {
        win.gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            chest += 1;
            Col.gameObject.SetActive(false);
            coinsText.text = "Treasure Chests: " + chest;
        }
    }

    // Update is called once per frame
    void Update()
    {
        


        if (chest == 6)
        {
            win.gameObject.SetActive (true);
            Debug.Log("You collected all 6 coins!");
            Debug.Log("You win!");
            chest = 7;
            Time.timeScale = 0;
            StartCoroutine(Quit());
            Application.Quit();
        }
    }
    IEnumerator Quit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }
}
