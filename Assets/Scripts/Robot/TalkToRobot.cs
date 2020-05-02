using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkToRobot : MonoBehaviour
{
    public Camera main;
    public Camera closeUp;

    public AudioSource roboSound;

    public GameObject robUI;

    // Dialog options.
    public GameObject spch01;
    public GameObject spch02;
    public GameObject spch03;
    public GameObject spch04;
    public GameObject spch05;
    public GameObject spch06;
    public GameObject spch07;
    public GameObject spch08;
    public GameObject spch09;

    // Display appropriate robot lines based on what player has
    // accomplished thus far in the game.
    private void OnMouseDown()
    {
        // Check to make sure this isn't an accidental click
        // while in a menu.
        if (EventManager.inMenu == false)
        {
            // Let EventManager know the player is talking to NPC.
            EventManager.talking = true;

            // Switch cameras and bring up UI.
            main.gameObject.SetActive(false);
            closeUp.gameObject.SetActive(true);
            robUI.gameObject.SetActive(true);
            
            // Play robot SFX.
            roboSound.Play();

            // Bring up appropriate dialog, based on what player has done.
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
                    if (EventManager.numHasPower == false)
                    {
                        spch03.gameObject.SetActive(true);
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
                                if (EventManager.lastChoiceMade == false)
                                {
                                    spch07.gameObject.SetActive(true);
                                }
                                else
                                {
                                    if (EventManager.takeRobot)
                                    {
                                        spch08.gameObject.SetActive(true);
                                    }
                                    else
                                    {
                                        spch09.gameObject.SetActive(true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
    }
}
