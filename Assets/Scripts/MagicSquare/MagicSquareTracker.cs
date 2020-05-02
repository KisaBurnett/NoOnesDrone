using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSquareTracker : MonoBehaviour
{
    Button num01;
    Button num02;
    Button num03;
    Button num04;
    Button num05;
    Button num06;
    Button num07;
    Button num08;
    Button num09;

    public static int currentValue;

    Text row01col01;
    Text row01col02;
    Text row01col03;
    Text row02col01;
    Text row02col02;
    Text row02col03;
    Text row03col01;
    Text row03col02;
    Text row03col03;

    Text sumRow1;
    Text sumRow2;
    Text sumRow3;
    Text sumDiag1;
    Text sumCol1;
    Text sumCol2;
    Text sumCol3;
    Text sumDiag2;

    int row1;
    int row2;
    int row3;
    int diag1;
    int col1;
    int col2;
    int col3;
    int diag2;
    int winningSum = 15;

    AudioSource endSFX;

    bool playedSound;

    void Start()
    {
        // Variable that holds the number the player has selected
        // from the keypad.
        currentValue = 0;

        // Establishes the squares on the game board, where the player
        // places the number they've selected from the keypad.
        num01 = GameObject.Find("NumEntry01").GetComponent<Button>();
        num02 = GameObject.Find("NumEntry02").GetComponent<Button>();
        num03 = GameObject.Find("NumEntry03").GetComponent<Button>();
        num04 = GameObject.Find("NumEntry04").GetComponent<Button>();
        num05 = GameObject.Find("NumEntry05").GetComponent<Button>();
        num06 = GameObject.Find("NumEntry06").GetComponent<Button>();
        num07 = GameObject.Find("NumEntry07").GetComponent<Button>();
        num08 = GameObject.Find("NumEntry08").GetComponent<Button>();
        num09 = GameObject.Find("NumEntry09").GetComponent<Button>();

        // Establishes the content of the squares on the game board.
        row01col01 = GameObject.Find("0101").GetComponent<Text>();
        row01col02 = GameObject.Find("0102").GetComponent<Text>();
        row01col03 = GameObject.Find("0103").GetComponent<Text>();
        row02col01 = GameObject.Find("0201").GetComponent<Text>();
        row02col02 = GameObject.Find("0202").GetComponent<Text>();
        row02col03 = GameObject.Find("0203").GetComponent<Text>();
        row03col01 = GameObject.Find("0301").GetComponent<Text>();
        row03col02 = GameObject.Find("0302").GetComponent<Text>();
        row03col03 = GameObject.Find("0303").GetComponent<Text>();

        // The content of the squares that display the sum of the
        // rows, columns, and diagonals on the game board.
        sumRow1 = GameObject.Find("row1").GetComponent<Text>();
        sumRow2 = GameObject.Find("row2").GetComponent<Text>();
        sumRow3 = GameObject.Find("row3").GetComponent<Text>();
        sumDiag1 = GameObject.Find("dia1").GetComponent<Text>();
        sumCol1 = GameObject.Find("col1").GetComponent<Text>();
        sumCol2 = GameObject.Find("col2").GetComponent<Text>();
        sumCol3 = GameObject.Find("col3").GetComponent<Text>();
        sumDiag2 = GameObject.Find("dia2").GetComponent<Text>();

        endSFX = GameObject.Find("FuseOnSFX").GetComponent<AudioSource>();

        playedSound = false;
    }


    void Update()
    {
        // Add up the contents of the squares in a given row, column, or diagonal.
        row1 = int.Parse(row01col01.text) + int.Parse(row01col02.text) + int.Parse(row01col03.text);
        row2 = int.Parse(row02col01.text) + int.Parse(row02col02.text) + int.Parse(row02col03.text);
        row3 = int.Parse(row03col01.text) + int.Parse(row03col02.text) + int.Parse(row03col03.text);
        col1 = int.Parse(row01col01.text) + int.Parse(row02col01.text) + int.Parse(row03col01.text);
        col2 = int.Parse(row01col02.text) + int.Parse(row02col02.text) + int.Parse(row03col02.text);
        col3 = int.Parse(row01col03.text) + int.Parse(row02col03.text) + int.Parse(row03col03.text);
        diag1 = int.Parse(row03col01.text) + int.Parse(row02col02.text) + int.Parse(row01col03.text);
        diag2 = int.Parse(row01col01.text) + int.Parse(row02col02.text) + int.Parse(row03col03.text);

        // Display the sum of each row, column, or diagonal.
        sumRow1.text = row1.ToString();
        sumRow2.text = row2.ToString();
        sumRow3.text = row3.ToString();
        sumCol1.text = col1.ToString();
        sumCol2.text = col2.ToString();
        sumCol3.text = col3.ToString();
        sumDiag1.text = diag1.ToString();
        sumDiag2.text = diag2.ToString();

        // If all of the rows, columns, and diagonals add up to 15, the player wins, and the
        // game board freezes in the winning configuration.
        if (row1 == winningSum &&
            row2 == winningSum &&
            row3 == winningSum && 
            col1 == winningSum &&
            col2 == winningSum &&
            col3 == winningSum &&
            diag1 == winningSum &&
            diag2 == winningSum)
        {
            num01.interactable = false;
            num02.interactable = false;
            num03.interactable = false;
            num04.interactable = false;
            num05.interactable = false;
            num06.interactable = false;
            num07.interactable = false;
            num08.interactable = false;
            num09.interactable = false;

            if (playedSound == false)
            {
                endSFX.Play();
                playedSound = true;
            }

            // Let the EventManager know the puzzle has been solved.
            EventManager.squareSolved = true;
        }
    }
}
