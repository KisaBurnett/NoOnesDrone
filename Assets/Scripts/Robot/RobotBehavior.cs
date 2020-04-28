using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBehavior : MonoBehaviour
{
    Animator roboAnim;

    // Start is called before the first frame update
    void Start()
    {
        roboAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (EventManager.talking)
        {
            roboAnim.SetBool("isChatting", true);
        }
        else
        {
            roboAnim.SetBool("isChatting", false);
        }
    }
}
