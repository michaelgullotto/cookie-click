using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 10;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;



    // showing and hiding fake and real button used to purchase auto genration
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers" + numberOfBakers + "@" + bakePerSec  + "Per Second";
        fakeText.GetComponent<Text>().text = "BuyBaker - $" + bakerValue;
        realText.GetComponent<Text>().text = "BuyBaker - $" + bakerValue;
      
        
        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
