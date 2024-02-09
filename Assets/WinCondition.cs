using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static int enemiesDead;
    public GameObject winner;
    public AudioSource enemydown;

    public TextMeshProUGUI Enemieskilled;


    // Start is called before the first frame update
    void Start()
    {
        enemiesDead = 0;
        winner.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemieskilled != null)
            Enemieskilled.SetText(enemiesDead + " killed");
        switch (enemiesDead)
        {
            case 0:
                winner.gameObject.SetActive(false);
                break;
            case 1:
                winner.gameObject.SetActive(false);
                enemydown.Play();
                break;
            case 2:
                winner.gameObject.SetActive(true);
                enemydown.Play();
                break;
            default:
                winner.gameObject.SetActive(false);
                break;
        }
    }
}
