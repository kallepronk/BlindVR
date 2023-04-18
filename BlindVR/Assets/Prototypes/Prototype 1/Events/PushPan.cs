using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;
using UnityEngine.Events;

public class PushPan : MonoBehaviour
{
    public UnityEvent onPanPushed;
    public float treshhold = 1f;
    public AudioSource clip1;

    private void Update()
    {
        if (!clip1.isPlaying)
        {
            GetComponent<Grabbable>().enabled = true;
            if (transform.position.z > treshhold)
            {
                Debug.Log("Crash");
                onPanPushed.Invoke();
            }
        }
    }
}
