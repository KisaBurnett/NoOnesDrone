using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToRobot : MonoBehaviour
{
    public Camera main;
    public Camera closeUp;
    public GameObject robUI;
    public GameObject spch01;
    public GameObject spch02;
    public GameObject spch03;
    public GameObject spch04;
    public GameObject spch05;
    public GameObject spch06;
    public GameObject spch07;
    public GameObject spch08;
    public GameObject spch09;

    private void OnMouseDown()
    {
        EventManager.talking = true;

        main.gameObject.SetActive(false);
        closeUp.gameObject.SetActive(true);
        robUI.gameObject.SetActive(true);

        if (EventManager.firstTalk == false)
        {
            spch01.gameObject.SetActive(true);
            EventManager.firstTalk = true;
        }
        else
        {
            if (EventManager.fuseOpen == false)
            {
                spch02.gameObject.SetActive(true);
            }
            else
            {
                if (EventManager.laptopOn == false)
                {
                    spch03.gameObject.SetActive(true);
                }
                else
                {
                    if (EventManager.numHasPower == false)
                    {
                        spch04.gameObject.SetActive(true);
                    }
                    else
                    {
                        if (EventManager.squareSolved == false)
                        {
                            spch05.gameObject.SetActive(true);
                        }
                        else
                        {
                            if (EventManager.hasKeyCard == false)
                            {
                                spch06.gameObject.SetActive(true);
                            }
                            else
                            {
                                spch07.gameObject.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }
}
