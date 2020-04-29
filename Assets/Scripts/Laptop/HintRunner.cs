using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintRunner : MonoBehaviour
{
    public GameObject scriptUI;
    public GameObject resultUI;

    // Closes one UI panel and opens another.
    public void runThatScript()
    {
        resultUI.gameObject.SetActive(true);
        scriptUI.gameObject.SetActive(false);
    }
}
