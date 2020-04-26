using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateInteraction : MonoBehaviour
{
    public GameObject crateUI;

    private void OnMouseDown()
    {
        if (EventManager.squareSolved)
        {
            EventManager.inMenu = true;
            crateUI.gameObject.SetActive(true);
        }
    }
}
