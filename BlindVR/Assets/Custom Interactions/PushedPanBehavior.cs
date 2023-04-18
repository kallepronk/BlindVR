using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushedPanBehavior : MonoBehaviour
{
    [SerializeField] private Animator Animator;

    public void WhenCalled()
    {
        Animator.SetBool("Base Layer", true);
    }

}
