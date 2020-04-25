using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbersInteraction : MonoBehaviour
{
    public Image numbersOverlay;
    public Button numbersBack;

    private void OnMouseDown()
    {
        EventManager.inMenu = true;
        numbersOverlay.gameObject.SetActive(true);
        numbersBack.gameObject.SetActive(true);
    }
}
