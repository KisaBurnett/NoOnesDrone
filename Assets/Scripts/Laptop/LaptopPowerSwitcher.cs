using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopPowerSwitcher : MonoBehaviour
{
    public GameObject lappieOn;
    public GameObject lappieOff;
    public GameObject lapUIOn;
    public GameObject lapUIOff;
    
    public void PowerOn()
    {
        lappieOff.gameObject.SetActive(false);
        lappieOn.gameObject.SetActive(true);
        EventManager.laptopOn = true;
        lapUIOn.gameObject.SetActive(true);
        lapUIOff.gameObject.SetActive(false);
    }
}
