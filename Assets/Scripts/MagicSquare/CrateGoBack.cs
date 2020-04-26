using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateGoBack : MonoBehaviour
{
    public GameObject crateInsideUI;

    public void crateBack()
    {
        crateInsideUI.gameObject.SetActive(false);
        EventManager.inMenu = false;
    }
}
