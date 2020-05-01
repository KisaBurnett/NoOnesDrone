using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForwardCredits : MonoBehaviour
{
    public GameObject thisPage;
    public GameObject nextPage;

    public void nextCredits()
    {
        nextPage.gameObject.SetActive(true);
        thisPage.gameObject.SetActive(false);
    }
}
