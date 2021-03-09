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
    public void ClickTheButton ()
    
    {

        if (GlobalCookies.CookieCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not Enough Cookies";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
        else
        {
            cashsound.Play();
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
        }




}
