using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuseboxInteraction : MonoBehaviour
{
    public Image fuseClosed;
    public Image fuseOpen;
    public Button goBack;
    public Button openBox;

    private void OnMouseDown()
    {
        if (EventManager.fuseOpen)
        {
            EventManager.inMenu = true;
            fuseOpen.gameObject.SetActive(true);
            goBack.gameObject.SetActive(true);
        }
        else
        {
            EventManager.inMenu = true;
            fuseClosed.gameObject.SetActive(true);
            goBack.gameObject.SetActive(true);
            openBox.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
