using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveRobot : MonoBehaviour
{
    public GameObject lastPrompt;
    public GameObject noLeave;

    // If player chooses not to take robot, display appropriate reply.
    // Does not touch EventManager.takeRobot, since this is false by default.
    // Informs EventManager the final choice has been made.
    public void leaveYaBoi()
    {
        lastPrompt.gameObject.SetActive(false);
        noLeave.gameObject.SetActive(true);
        EventManager.lastChoiceMade = true;
    }
}
