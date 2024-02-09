using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUp : MonoBehaviour
{
    public static bool Powered = false;
    int PowerUps = 0;
    public float TimeLeft = 10;

    [SerializeField] TextMeshProUGUI powerText;

    [SerializeField] AudioSource PowerGrab;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUps == 3)
        {
            
            
            Powered = true;
            
            TimeLeft -= Time.deltaTime;
            updateTimer(TimeLeft);
            StartCoroutine(SetFalse());

            
        }

       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Power")
        {
            PowerUps += 1;
            PowerGrab.Play();
            other.gameObject.SetActive(false);

        }
    }

    IEnumerator SetFalse()
    {;
        yield return new WaitForSeconds(10);
        Powered = false;
        PowerUps = 0;
        powerText.text = "Powered Up Time: ";
        TimeLeft = 10;
        
    }

    void updateTimer(float currentTime)
    {
        powerText.text = currentTime + " seconds left!";
    }

    
}
