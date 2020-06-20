using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWarriorAnimator : MonoBehaviour
{
    float speed = 4;

    Vector3 OgPosition = Vector3.zero;
    CharacterController controller;
    Animator animator;
    Rigidbody rig;
    
    void Start() {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
        OgPosition = this.transform.position;
    }


    void Update() {
        print(rig.velocity.magnitude);
        //animator.SetFloat("Speed", rig.velocity.magnitude);
        /*
        if (OgPosition != transform.position) {
            print("made it");
            animator.SetTrigger("Walk Forward");
            OgPosition = transform.position;
        }
        */
        if (OgPosition != this.transform.position) {
            animator.SetBool("IsWalking", true);
            OgPosition = transform.position;
        }
        else
            animator.SetTrigger("IdleNow");
    }
}

