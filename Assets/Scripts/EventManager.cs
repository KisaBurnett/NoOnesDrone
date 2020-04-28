﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public static bool inMenu;
    public static bool firstTalk;
    public static bool fuseOpen;
    public static bool laptopOn;
    public static bool talking;
    public static bool numHasPower;
    public static bool hasKeyCard;
    public static bool squareSolved;
    public static bool doorUnlocked;
    public static bool doorOpen;
    public static bool takeRobot;

    // Initialize variables that track player's progress.
    // In beginning, player has done nothing, so all should be
    // false.
    void Start()
    {
        inMenu = false;
        fuseOpen = false;
        laptopOn = false;
        talking = false;
        numHasPower = false;
        squareSolved = false;
        hasKeyCard = false;
        doorUnlocked = false;
        doorOpen = false;
        takeRobot = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
