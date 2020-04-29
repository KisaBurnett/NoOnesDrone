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

    public Text firstMsg;
    public Text lastMsg;
    public Button goNextMsg;
    public Button thisBtn;

    public bool needsReset;
    
    // Return to the main scene. Reset dialog UI as necessary.
    public void goAwayFromRobot()
    {
        EventManager.talking = false;

        mainC.gameObject.SetActive(true);
        npcC.gameObject.SetActive(false);

        if (needsReset)
        {
            lastMsg.gameObject.SetActive(false);
            firstMsg.gameObject.SetActive(true);
            goNextMsg.gameObject.SetActive(true);
            thisBtn.gameObject.SetActive(false);
        }

        robotUI.gameObject.SetActive(false);
        thisHereUI.gameObject.SetActive(false);
    }
}
