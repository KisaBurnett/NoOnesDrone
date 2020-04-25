using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public static bool inMenu;
    public static bool fuseOpen;
    public static bool laptopOn;
    public static bool talking;
    
    // Start is called before the first frame update
    void Start()
    {
        inMenu = false;
        fuseOpen = false;
        laptopOn = false;
        talking = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
