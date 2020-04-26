using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersGoBack : MonoBehaviour
{
    public GameObject magicNumUI;
    
    // Take player back to main scene, and tell EventManager
    // player is no longer in a menu so camera can be moved.
    public void numbersBck()
    {
        magicNumUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
