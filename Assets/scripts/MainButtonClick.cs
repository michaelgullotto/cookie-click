using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{

    public GameObject textBox;

    // tells game when click cookie to add 1 to score
    public void ClickTheButton ()

    {
        GlobalCookies.CookieCount += 1;
    }


}
