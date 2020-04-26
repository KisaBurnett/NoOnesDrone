using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopGoBack : MonoBehaviour
{
    public GameObject lappieUI;
    
    public void laptopBack()
    {
        lappieUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
