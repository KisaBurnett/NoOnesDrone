using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoboGoBack : MonoBehaviour
{
    public Camera mainC;
    public Camera npcC;

    public GameObject robotUI;
    public GameObject thisHereUI;
    
    public void goAwayFromRobot()
    {
        EventManager.talking = false;

        mainC.gameObject.SetActive(true);
        npcC.gameObject.SetActive(false);
        robotUI.gameObject.SetActive(false);
        thisHereUI.gameObject.SetActive(false);
    }
}
