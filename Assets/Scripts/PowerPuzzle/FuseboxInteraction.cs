using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseboxInteraction : MonoBehaviour
{
    public GameObject fuseCl;
    public GameObject fuseOp;

    // When clicked, take player to appropriate UI, based
    // on whether or not fusebox door is open.
    private void OnMouseDown()
    {
        if (EventManager.talking == false)
        {
            EventManager.inMenu = true;
            if (EventManager.fuseOpen)
            {
                fuseOp.gameObject.SetActive(true);
            }
            else
            {
                fuseCl.gameObject.SetActive(true);
            }
        }
    }
}
