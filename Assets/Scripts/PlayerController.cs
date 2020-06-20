using System;
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
                    this.transform.position = hit.point;
                    this.transform.position = findBoard();
                    
                }
                isSelected = false;
            }
        }
        


    }

    Vector3 findBoard()
    {
        double min = 100000;
        Vector3 nearestBoard = this.transform.position;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Board");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            // print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - this.transform.position.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - this.transform.position.y, 2) +
                Math.Pow(gameObjects[i].transform.position.z - this.transform.position.z, 2));
            if (value < min)
            {
                min = value;
                nearestBoard = new Vector3(gameObjects[i].transform.position.x, gameObjects[i].transform.position.y, gameObjects[i].transform.position.z);
            }
        }

        return nearestBoard;
    }

    void OnMouseDown()
    {
        
        
            print("Got into if statement");
            isSelected = true;
        
    }
}
