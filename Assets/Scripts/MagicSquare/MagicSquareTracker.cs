using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSquareTracker : MonoBehaviour
{
    public Button num01;
    public Button num02;
    public Button num03;
    public Button num04;
    public Button num05;
    public Button num06;
    public Button num07;
    public Button num08;
    public Button num09;

    public static int currentValue;

    public Text row01col01;
    public Text row01col02;
    public Text row01col03;
    public Text row02col01;
    public Text row02col02;
    public Text row02col03;
    public Text row03col01;
    public Text row03col02;
    public Text row03col03;

    public Text sumRow1;
    public Text sumRow2;
    public Text sumRow3;
    public Text sumDiag1;
    public Text sumCol1;
    public Text sumCol2;
    public Text sumCol3;
    public Text sumDiag2;

    int row1;
    int row2;
    int row3;
    int diag1;
    int col1;
    int col2;
    int col3;
    int diag2;
    int winningSum = 15;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        row1 = int.Parse(row01col01.text) + int.Parse(row01col02.text) + int.Parse(row01col03.text);
        row2 = int.Parse(row02col01.text) + int.Parse(row02col02.text) + int.Parse(row02col03.text);
        row3 = int.Parse(row03col01.text) + int.Parse(row03col02.text) + int.Parse(row03col03.text);
        col1 = int.Parse(row01col01.text) + int.Parse(row02col01.text) + int.Parse(row03col01.text);
        col2 = int.Parse(row01col02.text) + int.Parse(row02col02.text) + int.Parse(row03col02.text);
        col3 = int.Parse(row01col03.text) + int.Parse(row02col03.text) + int.Parse(row03col03.text);
        diag1 = int.Parse(row03col01.text) + int.Parse(row02col02.text) + int.Parse(row01col03.text);
        diag2 = int.Parse(row01col01.text) + int.Parse(row02col02.text) + int.Parse(row03col03.text);

        sumRow1.text = row1.ToString();
        sumRow2.text = row2.ToString();
        sumRow3.text = row3.ToString();
        sumCol1.text = col1.ToString();
        sumCol2.text = col2.ToString();
        sumCol3.text = col3.ToString();
        sumDiag1.text = diag1.ToString();
        sumDiag2.text = diag2.ToString();

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
            EventManager.squareSolved = true;
        }
    }
}
