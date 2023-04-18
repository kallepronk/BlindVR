using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAfterPrev : MonoBehaviour
{
    public RigidBody thisObject;
    public AudioSource actualAudio;
    public AudioSource nextAudio;
    // Start is called before the first frame update
    void Start()
    {
        thisObject = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(actualAudio.isPlaying())
        {
            thisObject.constraints = RigidBodyConstraints.FreezePosition;
        }
        if(!actualAudio.isPlaying())
        {
            nextAudio.Start();
            thisObject.constraints = RigidBodyConstraints.None;
        }
    }
}
