using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseGoBack : MonoBehaviour
{
    public GameObject fuseMenu;

    public void stepBack()
    {
        fuseMenu.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
