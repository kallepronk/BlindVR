using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushPan : MonoBehaviour
{
    public UnityEvent onPanPushed;
    public float treshhold = 1f;
    public AudioSource clip1;

    private void Update()
    {
        if (transform.position.z >= treshhold && !clip1.isPlaying)
        {
            Debug.Log("Crash");
            onPanPushed.Invoke();
        }
    }
}
