using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWarriorAnimator : MonoBehaviour
{
    float speed = 4;

    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator animator;
    Rigidbody rig;

    void Start() {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
    }


    void Update() {
        Debug.Log(rig.velocity.magnitude);
        animator.SetFloat("Speed", rig.velocity.magnitude);
        if (rig.velocity.magnitude > 0) {
            animator.SetTrigger("Walk Forward");
        }
        else
            animator.ResetTrigger("Walk Forward");
    }
}

