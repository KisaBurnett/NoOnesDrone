using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopInteraction : MonoBehaviour
{
    public Image laptopUI;
    public Button lapGoBack;

    private void OnMouseDown()
    {
        EventManager.inMenu = true;
        laptopUI.gameObject.SetActive(true);
        lapGoBack.gameObject.SetActive(true);
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
