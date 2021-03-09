using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gamble : MonoBehaviour
{
    public int gamble;
    public int roll;
    public GameObject GambleDisplay;
    public AudioSource lose;
    public AudioSource win;
    public void ClickTheButton()
        //rolls to either gamble half of cash
    {
        roll = Random.Range(1, 11);
        if (roll > 5)
        {
            GlobalCash.CashCount = GlobalCash.CashCount - gamble;
            lose.Play();
        }
        else
        {
            GlobalCash.CashCount = GlobalCash.CashCount + gamble;
            win.Play();
        }


    }

    void Update()

    {
        gamble = GlobalCash.CashCount / 2;

      GambleDisplay.GetComponent<Text>().text =( "Gamble cash: " + gamble );

    }



}
