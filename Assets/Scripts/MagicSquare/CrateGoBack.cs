using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateGoBack : MonoBehaviour
{
    public GameObject crateInsideUI;

    // Steps back to the main view when player clicks to go back.
    public void crateBack()
    {
        crateInsideUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
