using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalCash : MonoBehaviour
{
    // defineing varibles required for score display
    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash;
  
    void Update()
    {
        //set up of score display 
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "$ : " + InternalCash;

    }
}
