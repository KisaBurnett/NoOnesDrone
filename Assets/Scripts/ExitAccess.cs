using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAccess : MonoBehaviour
{
    public ParticleSystem exitBlock;

    private void OnMouseDown()
    {
        if (EventManager.hasKeyCard)
        {
            EventManager.doorUnlocked = true;
            exitBlock.gameObject.SetActive(false);
        }
    }
}
