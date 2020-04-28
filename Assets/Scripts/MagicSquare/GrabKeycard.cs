using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabKeycard : MonoBehaviour
{
    public Image crateWithCard;
    public Image crateNoCard;
    public Button thisGuy;

    // When player picks up the key card, let the EventManager
    // know and display the appropriate image.
    public void getThatCard()
    {
        EventManager.hasKeyCard = true;
        crateWithCard.gameObject.SetActive(false);
        crateNoCard.gameObject.SetActive(true);
        thisGuy.gameObject.SetActive(false);
    }
}
