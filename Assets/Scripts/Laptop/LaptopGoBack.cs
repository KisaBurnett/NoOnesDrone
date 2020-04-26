using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopGoBack : MonoBehaviour
{
    public GameObject lappieUI;
    
    // Take player back to main scene, and tell EventManager
    // player is no longer in a menu so the camera can be moved.
    public void laptopBack()
    {
        lappieUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
