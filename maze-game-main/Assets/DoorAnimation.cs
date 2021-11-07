using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    private Animator Animator;

    void Awake()
    {
       Animator = GetComponent<Animator>();
    }

    void TurnOn()
    {
        Animator.SetBool("ButtonPressed", true);
    }

    void TurnOff()
    {
        Animator.SetBool("ButtonPressed", false);
    }
}
