using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateInteraction : MonoBehaviour
{
    public GameObject crateUI;

    // Allows player to collect the key card from the crate.
    private void OnMouseDown()
    {
        if (EventManager.squareSolved &&
            EventManager.talking == false &&
            EventManager.inMenu == false)
        {
            EventManager.inMenu = true;
            crateUI.gameObject.SetActive(true);
        }
    }
}
