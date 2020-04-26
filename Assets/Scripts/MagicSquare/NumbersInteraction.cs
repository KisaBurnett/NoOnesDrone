using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersInteraction : MonoBehaviour
{
    public GameObject numbersOffUI;
    public GameObject numbersOnUI;

    private void OnMouseDown()
    {
        if (EventManager.numHasPower == false)
        {
            numbersOffUI.gameObject.SetActive(true);
            EventManager.inMenu = true;
        }
        else
        {
            numbersOnUI.gameObject.SetActive(true);
            EventManager.inMenu = true;
        }
    }
}
