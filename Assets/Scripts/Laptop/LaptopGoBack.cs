using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopGoBack : MonoBehaviour
{
    public Image laptopOn;
    public Image laptopOff;
    
    public void laptopBack()
    {
        if (EventManager.laptopOn)
        {
            laptopOn.gameObject.SetActive(false);
        }
        else
        {
            laptopOff.gameObject.SetActive(false);
        }
        this.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
