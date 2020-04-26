using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseGoBack : MonoBehaviour
{
    public GameObject fuseMenu;

    // When clicked, take player back to the main scene.
    // Tell EventManager the player is no longer in menu,
    // to allow player to move the camera.
    public void stepBack()
    {
        fuseMenu.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
