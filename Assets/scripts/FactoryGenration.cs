using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryGenration : MonoBehaviour
{
    public GameObject FactoryAuto;
    public AudioSource playsound;
    
    public void StartFactoryAuto()
    {
        playsound.Play();
        FactoryAuto.SetActive(true);
        GlobalCash.CashCount -= GlobalFactory.factoryValue;
        GlobalFactory.factoryValue *= 2;
        GlobalFactory.factoryturnOffButton = true;
        GlobalFactory.factoryPerSec += 10;
        GlobalFactory.numberOfFactorys += 1;



    }
}
