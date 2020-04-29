using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintOneGoTo : MonoBehaviour
{
    public GameObject hintUI;

    public Button thisBtn;
    public Button mainBckBtn;

    // Goes to the next hint UI.
    public void goToHint1()
    {
        hintUI.gameObject.SetActive(true);

        mainBckBtn.gameObject.SetActive(false);
        thisBtn.gameObject.SetActive(false);
    }
}
