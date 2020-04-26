using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPick : MonoBehaviour
{
    public int thisNum;
    
    // Store the selected number in MagicSquareTracker so
    // it can be placed in a chosen square on the game board.
    // Disable button so player can only place this number in
    // one square on the game board.
    public void pickThisNum()
    {
        if (MagicSquareTracker.currentValue == 0)
        {
            MagicSquareTracker.currentValue = thisNum;
            GetComponent<Button>().interactable = false;
        }
    }
}
