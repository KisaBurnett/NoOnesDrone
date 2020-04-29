using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotAdvanceLine : MonoBehaviour
{
    public Text thisLine;
    public Text nextLine;

    public Button leave;
    public Button goOn;
    public Button nextGoOn;

    public bool isLastLine;

    // Hide the prior line and activate the next line.
    public void advanceDialog()
    {
        thisLine.gameObject.SetActive(false);
        nextLine.gameObject.SetActive(true);
        goOn.gameObject.SetActive(false);

        // Take away the "next" option if there are no further
        // lines, and instead show the "go back" option.
        if (isLastLine)
        {
            leave.gameObject.SetActive(true);
        }
        else
        {
            nextGoOn.gameObject.SetActive(true);
        }
    }
}
