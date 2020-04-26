using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseboxInteraction : MonoBehaviour
{
    public GameObject fuseBox;

    private void OnMouseDown()
    {
        EventManager.inMenu = true;
        fuseBox.gameObject.SetActive(true);
    }
}
