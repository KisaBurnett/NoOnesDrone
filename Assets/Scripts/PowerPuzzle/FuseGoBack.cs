using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseGoBack : MonoBehaviour
{
    public Image openDoor;
    public Image closedDoor;

    public void stepBack()
    {
        if (EventManager.fuseOpen)
        {
            openDoor.gameObject.SetActive(false);
        }
        else
        {
            closedDoor.gameObject.SetActive(false);
        }

        this.gameObject.SetActive(false);

        EventManager.inMenu = false;
    }
}
