using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{



    // tells game when click cookie to add remove cookie for cash

    public GameObject statusBox;
    public GameObject textBox;
    public AudioSource cashsound;
    public void ClickTheButton()

    {

        if (GlobalCookies.CookieCount <= 9)
        {
            statusBox.GetComponent<Text>().text = "Not Enough Cookies";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
        else
        {
            cashsound.Play();
            GlobalCookies.CookieCount -= 10;
            GlobalCash.CashCount += 10;
        }

        if (GlobalCookies.CookieCount >= 100)
        {
            cashsound.Play();
            GlobalCookies.CookieCount -= 90;
            GlobalCash.CashCount += 90;
        }
        if (GlobalCookies.CookieCount >= 1000)
        {
            cashsound.Play();
            GlobalCookies.CookieCount -= 900;
            GlobalCash.CashCount += 900;
        }






    }




}
