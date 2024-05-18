using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public Animator animator;

    public InputActionProperty pinchAnimtionAction;
    public InputActionProperty gripAnimtionAction;

    void Update()
    {
        float triggerValue = pinchAnimtionAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimtionAction.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);
    }
}
