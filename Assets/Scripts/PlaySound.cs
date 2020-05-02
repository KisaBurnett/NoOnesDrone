using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundToPlay;

    public void playTheSound()
    {
        soundToPlay.Play();
    }
}
