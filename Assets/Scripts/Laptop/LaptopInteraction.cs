using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject laptopUI;

    // When player clicks on laptop, open appropriate UI.
    private void OnMouseDown()
    {
        if (EventManager.talking == false)
        {
            EventManager.inMenu = true;
            laptopUI.gameObject.SetActive(true);
        }
    }
}
