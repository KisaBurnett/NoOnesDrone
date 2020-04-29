using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintOneGoBack : MonoBehaviour
{
    public GameObject hintOneUI;

    public Button mainGoBack;
    public Button hintBtn;

    // Returns to the main laptop UI.
    public void hintOneBck()
    {
        mainGoBack.gameObject.SetActive(true);
        hintBtn.gameObject.SetActive(true);

        hintOneUI.gameObject.SetActive(false);
    }
}
