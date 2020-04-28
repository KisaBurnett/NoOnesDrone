using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveRoom : MonoBehaviour
{
    public Camera mainCam;

    public GameObject goodEnd;
    public GameObject goodEndUI;

    public GameObject badEnd;
    public GameObject badEndUI;

    // Checks to see if player has met end conditions. If they have,
    // allows player to leave and activates appropriate ending.
    private void OnMouseDown()
    {
        if (EventManager.doorOpen)
        {
            if (EventManager.takeRobot)
            {
                mainCam.gameObject.SetActive(false);
                goodEnd.gameObject.SetActive(true);
                goodEndUI.gameObject.SetActive(true);
            }
            else
            {
                mainCam.gameObject.SetActive(false);
                badEnd.gameObject.SetActive(true);
                badEndUI.gameObject.SetActive(true);
            }
        }
    }
}
