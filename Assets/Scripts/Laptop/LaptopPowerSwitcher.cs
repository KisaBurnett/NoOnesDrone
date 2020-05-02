using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopPowerSwitcher : MonoBehaviour
{
    public GameObject lappieOn;
    public GameObject lappieOff;
    public GameObject lapUIOn;
    public GameObject lapUIOff;
    
    // Changes the view and UI for the laptop when player powers
    // on the laptop.
    public void PowerOn()
    {
        // Switch models.
        lappieOff.gameObject.SetActive(false);
        lappieOn.gameObject.SetActive(true);

        // Let EventManager know the laptop is now on.
        EventManager.laptopOn = true;

        // Switch UIs.
        lapUIOn.gameObject.SetActive(true);
        lapUIOff.gameObject.SetActive(false);
    }
}
