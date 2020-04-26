using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersGoBack : MonoBehaviour
{
    public GameObject magicNumUI;
    
    public void numbersBck()
    {
        magicNumUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
