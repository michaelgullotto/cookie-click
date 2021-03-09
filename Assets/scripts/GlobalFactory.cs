using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFactory : MonoBehaviour
{
    public GameObject factoryfakeButton;
    public GameObject factroyfakeText;
    public GameObject factoryrealButton;
    public GameObject factoryrealText;
    public int factorycurrentCash;
    public static int factoryValue = 100;
    public static bool factoryturnOffButton = false;
    public GameObject factoryStats;
    public static int numberOfFactorys;
    public static int factoryPerSec;



    // showing and hiding fake and real button used to purchase auto genration
    void Update()
    {
        factorycurrentCash = GlobalCash.CashCount;
        factoryStats.GetComponent <Text>().text = "Factorys: " + numberOfFactorys + " @ " + factoryPerSec + "Per Second";
        factroyfakeText.GetComponent<Text>().text = "BuyFactroy - $" + factoryValue;
        factoryrealText.GetComponent<Text>().text = "BuyFactroy - $" + factoryValue;


        if (factorycurrentCash >= factoryValue)
        {
            factoryfakeButton.SetActive(false);
            factoryrealButton.SetActive(true);
        }

        if (factoryturnOffButton == true)
        {
            factoryrealButton.SetActive(false);
            factoryfakeButton.SetActive(true);
            factoryturnOffButton = false;
        }
        if (factorycurrentCash < factoryValue)
        {
            factoryrealButton.SetActive(false);
            factoryfakeButton.SetActive(true);
            factoryturnOffButton = false;
        }





    }
}
