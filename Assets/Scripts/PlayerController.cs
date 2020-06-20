﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private bool isSelected = false;

    public Camera cam;

    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        
        if (isSelected)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {


                    //Find a way to get rid of this line
                   // this.transform.position = hit.point;
                    this.transform.position = findBoard(hit.point);
                    
                }
                isSelected = false;
            }
            else if (Input.GetKeyUp("b"))
            {
                sendToBench();
            }
        }
        


    }

    Vector3 findBoard(Vector3 currPos)
    {
        double min = 100000;
        Vector3 nearestBoard = this.transform.position;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Board");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            // print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - currPos.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - currPos.y, 2) +
                Math.Pow(gameObjects[i].transform.position.z - currPos.z, 2));
            if (value < min)
            {
                min = value;
                nearestBoard = new Vector3(gameObjects[i].transform.position.x, gameObjects[i].transform.position.y, gameObjects[i].transform.position.z);
                
            }
        }
        print(nearestBoard);
        return nearestBoard;
    }

    void OnMouseDown()
    {
        
        
            //print("Got into if statement");
            isSelected = true;
        
    }

    void sendToBench()
    {
        int sendX = 0;
        int sendZ = -2;
        int sendY = 0;
        int count = 0;

       GameObject[] benches =  GameObject.FindGameObjectsWithTag("Bench");
        for(int i = 0; i < benches.Length; ++i)
        {
            if (!benches[i].occupancy())
            {

            }
        }


    }

}
