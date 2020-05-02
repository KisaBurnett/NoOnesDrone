using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerResetPuzzle : MonoBehaviour
{
    AudioSource fuseSFX;
    InputField entry01;
    InputField entry02;
    InputField entry03;
    InputField entry04;
    string winningCode = "8196";
    string winCheck;
    bool playedSound;

    // Grab the entry fields from the scene and assign them to variables.
    void Start()
    {
        fuseSFX = GameObject.Find("FuseOnSFX").GetComponent<AudioSource>();
        entry01 = GameObject.Find("CodeEntry01").GetComponent<InputField>();
        entry02 = GameObject.Find("CodeEntry02").GetComponent<InputField>();
        entry03 = GameObject.Find("CodeEntry03").GetComponent<InputField>();
        entry04 = GameObject.Find("CodeEntry04").GetComponent<InputField>();
        playedSound = false;
    }

    // Check the entered numbers against the winning code.
    // If the code is correct, tell the EventManager the Magic Square puzzle
    // should now be accessible.
    // If code is incorrect, do nothing.
    void Update()
    {
        if (entry01.text != null &&
            entry02.text != null &&
            entry03.text != null &&
            entry04.text != null)
        {
            winCheck = entry01.text + entry02.text + entry03.text + entry04.text;
            if (winCheck == winningCode)
            {
                EventManager.numHasPower = true;
                entry01.interactable = false;
                entry02.interactable = false;
                entry03.interactable = false;
                entry04.interactable = false;

                if (playedSound == false)
                {
                    // Play sound effect
                    fuseSFX.Play();
                    // Make sure sound effect is not played again.
                    playedSound = true;
                }
            }
        }
    }
}
