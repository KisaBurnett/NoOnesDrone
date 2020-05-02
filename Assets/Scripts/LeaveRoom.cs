using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveRoom : MonoBehaviour
{
    public Camera mainCam;

    public GameObject goodEnd;
    public GameObject goodEndUI;

    public GameObject badEnd;
    public GameObject badEndUI;

    public AudioSource mainMusic;
    public AudioSource exteriorSFX;
    public AudioSource end1Music;
    public AudioSource end2Music;

    // Checks to see if player has met end conditions. If they have,
    // allows player to leave and activates appropriate ending.
    private void OnMouseDown()
    {
        if (EventManager.doorOpen &&
            EventManager.talking == false &&
            EventManager.inMenu == false)
        {
            mainMusic.Stop();
            exteriorSFX.Play();
            
            if (EventManager.takeRobot)
            {
                mainCam.gameObject.SetActive(false);
                goodEnd.gameObject.SetActive(true);
                goodEndUI.gameObject.SetActive(true);
                end1Music.Play();
            }
            else
            {
                mainCam.gameObject.SetActive(false);
                badEnd.gameObject.SetActive(true);
                badEndUI.gameObject.SetActive(true);
                end2Music.Play();
            }
        }
    }
}
