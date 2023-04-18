using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class PushedPanBehavior : MonoBehaviour
{
    [SerializeField] private Animator Animator;

    public void WhenCalled()
    {
        Animator.SetBool("Pushed", true);
        GetComponent<Grabbable>().enabled = false;
    }

}
