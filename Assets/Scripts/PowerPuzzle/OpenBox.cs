using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBox : MonoBehaviour
{
    public GameObject fuseOpen;
    public GameObject fuseClosed;
    public GameObject fuseDoor;

    // When button is clicked, switch the UI and open the
    // door of the fusebox's model in the scene.
    // Also let the EventManager know that the fusebox is now open.
    public void onOpen()
    {
        fuseDoor.transform.Rotate(0, 90, 0);
        EventManager.fuseOpen = true;
        fuseOpen.gameObject.SetActive(true);
        fuseClosed.gameObject.SetActive(false);
    }
}
