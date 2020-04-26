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
        EventManager.inMenu = true;
        laptopUI.gameObject.SetActive(true);
    }
}
