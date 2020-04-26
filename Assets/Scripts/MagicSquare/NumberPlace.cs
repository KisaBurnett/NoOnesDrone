using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPlace : MonoBehaviour
{
    public Button numberOne;
    public Button numberTwo;
    public Button numberThree;
    public Button numberFour;
    public Button numberFive;
    public Button numberSix;
    public Button numberSeven;
    public Button numberEight;
    public Button numberNine;
    public Text displayValue;

    int thisValue;

    public void placeNumber()
    {
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
        thisValue = MagicSquareTracker.currentValue;
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
