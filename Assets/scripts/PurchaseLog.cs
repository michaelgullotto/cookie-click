using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public AudioSource playsound;

    public void StartAutoCookie()
    {
        // sound ques on button presses
        playsound.Play();


        // controls scaling and some varibles of displays and pucases
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;

    }


}    
