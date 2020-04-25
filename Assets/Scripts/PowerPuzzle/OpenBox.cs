using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBox : MonoBehaviour
{
    public Image fuseOpen;
    public Image fuseClosed;
    public GameObject fuseDoor;

    public void onOpen()
    {
        fuseOpen.gameObject.SetActive(true);
        fuseClosed.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        fuseDoor.transform.Rotate(0, 90, 0);
        EventManager.fuseOpen = true;
    }
}
