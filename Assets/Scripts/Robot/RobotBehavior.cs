using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBehavior : MonoBehaviour
{
    Animator roboAnim;

    // Initialize the variable referencing the robot's animator.
    void Start()
    {
        roboAnim = GetComponent<Animator>();
    }

    // Animate robot appropriately according to whether or not the
    // player is speaking to the robot.
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
