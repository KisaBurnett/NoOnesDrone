using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAccess : MonoBehaviour
{
    public ParticleSystem exitBlock;
    public GameObject exitRed;
    public GameObject exitGreen;

    // If player has collected the key card from the crate,
    // the red block disappears and the exit sign turns green.
    // Also advises EventManager that player should be permitted to leave.
    private void OnMouseDown()
    {
        if (EventManager.hasKeyCard)
        {
            EventManager.doorUnlocked = true;
            exitBlock.gameObject.SetActive(false);
            exitRed.gameObject.SetActive(false);
            exitGreen.gameObject.SetActive(true);
            EventManager.doorOpen = true;
        }
    }
}
