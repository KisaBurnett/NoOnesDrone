using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPlace : MonoBehaviour
{
    // The squares on the game board, which the player clicks
    // to place the number they chose from the keypad.
    public Button numberOne;
    public Button numberTwo;
    public Button numberThree;
    public Button numberFour;
    public Button numberFive;
    public Button numberSix;
    public Button numberSeven;
    public Button numberEight;
    public Button numberNine;
    
    // The value the square is already holding.
    public Text displayValue;
    
    // Holds value being placed on the board by the MagicSquareTracker.
    int thisValue;

    public void placeNumber()
    {
        // If there is already a number stored in this square,
        // turn on the corresponding key on the keypad so the player
        // can go back and select that number again.
        //
        // Without this check, the current value will be overwritten,
        // and the key for the previous value will remain locked out to
        // player, rendering puzzle unsolvable.
        if (displayValue.text != "0")
        {
            if (displayValue.text == "1")
            {
                numberOne.interactable = true;
            }
            else if (displayValue.text == "2")
            {
                numberTwo.interactable = true;
            }
            else if (displayValue.text == "3")
            {
                numberThree.interactable = true;
            }
            else if (displayValue.text == "4")
            {
                numberFour.interactable = true;
            }
            else if (displayValue.text == "5")
            {
                numberFive.interactable = true;
            }
            else if (displayValue.text == "6")
            {
                numberSix.interactable = true;
            }
            else if (displayValue.text == "7")
            {
                numberSeven.interactable = true;
            }
            else if (displayValue.text == "8")
            {
                numberEight.interactable = true;
            }
            else if (displayValue.text == "9")
            {
                numberNine.interactable = true;
            }
        }
        
        // Place the selected number on the selected square.
        thisValue = MagicSquareTracker.currentValue;

        // If a number has been selected, disable the corresponding key
        // on the keypad to prevent the player from placing the same number
        // on more than one space on the game board.
        if (thisValue != 0)
        {
            displayValue.text = thisValue.ToString();
            if (thisValue == 1)
            {
                numberOne.interactable = false;
            }
            else if (thisValue == 2)
            {
                numberTwo.interactable = false;
            }
            else if (thisValue == 3)
            {
                numberThree.interactable = false;
            }
            else if (thisValue == 4)
            {
                numberFour.interactable = false;
            }
            else if (thisValue == 5)
            {
                numberFive.interactable = false;
            }
            else if (thisValue == 6)
            {
                numberSix.interactable = false;
            }
            else if (thisValue == 7)
            {
                numberSeven.interactable = false;
            }
            else if (thisValue == 8)
            {
                numberEight.interactable = false;
            }
            else if (thisValue == 9)
            {
                numberNine.interactable = false;
            }
            MagicSquareTracker.currentValue = 0;
        }
        
        // If no number has been selected, and the square currently
        // holds a number, put the current space back to zero so the
        // player can reselect it from the keypad and place it elsewhere.
        else
        {
            if (displayValue.text == "1")
            {
                numberOne.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "2")
            {
                numberTwo.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "3")
            {
                numberThree.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "4")
            {
                numberFour.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "5")
            {
                numberFive.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "6")
            {
                numberSix.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "7")
            {
                numberSeven.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "8")
            {
                numberEight.interactable = true;
                displayValue.text = "0";
            }
            else if (displayValue.text == "9")
            {
                numberNine.interactable = true;
                displayValue.text = "0";
            }
        }
    }
}
