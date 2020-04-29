using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotFinalChoice : MonoBehaviour
{
    public Text currentLine;
    public Text choicePrompt;

    public Button nxtBtn;
    public Button takeRbt;
    public Button dontTake;

    public void finalChoice()
    {
        currentLine.gameObject.SetActive(false);
        choicePrompt.gameObject.SetActive(true);

        nxtBtn.gameObject.SetActive(false);
        takeRbt.gameObject.SetActive(true);
        dontTake.gameObject.SetActive(true);
    }
}
