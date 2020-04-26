using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPick : MonoBehaviour
{
    public int thisNum;
    
    public void pickThisNum()
    {
        if (MagicSquareTracker.currentValue == 0)
        {
            MagicSquareTracker.currentValue = thisNum;
            GetComponent<Button>().interactable = false;
        }
    }
}
