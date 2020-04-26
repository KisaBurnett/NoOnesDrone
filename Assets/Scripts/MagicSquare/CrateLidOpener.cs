using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateLidOpener : MonoBehaviour
{
    // When the Magic Square puzzle has been solved, open
    // the crate lid for player.
    void Update()
    {
        if (EventManager.squareSolved)
        {
            this.gameObject.SetActive(false);

        }
    }
}
