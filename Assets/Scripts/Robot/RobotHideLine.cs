using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotHideLine : MonoBehaviour
{
    public Text lineToHide;

    // Hides duplicate prior line to avoid jacking up the dialog menus.
    public void robotHideThis()
    {
        lineToHide.gameObject.SetActive(false);
    }
}
