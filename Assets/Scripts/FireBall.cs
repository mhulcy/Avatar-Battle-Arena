﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private GameObject target;
    private float _speed = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("ran");
       // this.transform.position = target.transform.position;
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, _speed);
    }
   public void setTarget(GameObject attackMe)
    {
        target = attackMe;
    }
}
