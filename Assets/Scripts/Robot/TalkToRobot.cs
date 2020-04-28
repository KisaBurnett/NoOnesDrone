using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToRobot : MonoBehaviour
{
    public Camera main;
    public Camera closeUp;
    public GameObject robUI;

    private void OnMouseDown()
    {
        EventManager.talking = true;

        main.gameObject.SetActive(false);
        closeUp.gameObject.SetActive(true);
        robUI.gameObject.SetActive(true);
    }
}
