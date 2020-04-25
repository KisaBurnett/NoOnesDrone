using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersGoBack : MonoBehaviour
{
    public Image numBG;
    
    public void numbersBck()
    {
        numBG.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
