using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Based on code by user Johaneto on answers.unity.com
    // https://answers.unity.com/users/575168/johaneto.html
    // https://answers.unity.com/questions/548794/how-to-move-a-camera-only-using-the-arrow-keys.html

    public float rotateSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventManager.inMenu == false && EventManager.talking == false)
        {
            var horizontalDir = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
            transform.Rotate(0, horizontalDir, 0);
        }
    }
}
