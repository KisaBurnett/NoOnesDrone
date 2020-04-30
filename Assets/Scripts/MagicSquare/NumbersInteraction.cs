using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersInteraction : MonoBehaviour
{
    public GameObject numbersOffUI;
    public GameObject numbersOnUI;

    // On click, open appropriate UI based on whether or
    // not the power puzzle has been solved. Tell EventManager
    // player is currently in a menu to freeze camera movement.
    private void OnMouseDown()
    {
        if (EventManager.numHasPower == false &&
            EventManager.talking == false &&
            EventManager.inMenu == false)
        {
            numbersOffUI.gameObject.SetActive(true);
            EventManager.inMenu = true;
        }
        else if (EventManager.numHasPower &&
            EventManager.talking == false &&
            EventManager.inMenu == false)
        {
            numbersOnUI.gameObject.SetActive(true);
            EventManager.inMenu = true;
        }
    }
}
