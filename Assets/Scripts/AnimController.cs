using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    float speed = 4;
    float rotSpeed = 80;
    float gravity = 8;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator animator;
    Rigidbody rig;
  
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Debug.Log(rig.velocity.magnitude);
        animator.SetFloat("Speed", rig.velocity.magnitude);
    }
}
