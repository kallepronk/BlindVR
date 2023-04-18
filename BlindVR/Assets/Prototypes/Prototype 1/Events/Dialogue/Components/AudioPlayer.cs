using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public NarrationLine gameEvent;
    public int allowActionSecondsEarlier = 0;
    private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audio.clip = gameEvent.clip;
        audio.Play();
    }
}
