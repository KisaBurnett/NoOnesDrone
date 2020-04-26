using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopInteraction : MonoBehaviour
{
    public GameObject laptopUI;

    private void OnMouseDown()
    {
        EventManager.inMenu = true;
        laptopUI.gameObject.SetActive(true);
    }
}
