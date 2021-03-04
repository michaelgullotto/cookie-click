using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCookies : MonoBehaviour
{
    // defineing varibles required for score display
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;
  
    void Update()
    {
        //set up of score display 
        InternalCookie = CookieCount;
        CookieDisplay.GetComponent<Text>().text = "Cookies : " + InternalCookie;

    }
}
