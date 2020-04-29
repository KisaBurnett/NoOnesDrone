using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeRobot : MonoBehaviour
{
    public GameObject priorPrompt;
    public GameObject yesTake;

    // If player chooses to take robot, display appropriate reply.
    // Informs EventManager the player is taking the robot and the
    // final choice has been made.
    public void takeYaBoi()
    {
        priorPrompt.gameObject.SetActive(false);
        yesTake.gameObject.SetActive(true);
        EventManager.takeRobot = true;
        EventManager.lastChoiceMade = true;
    }
}
