using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private bool isSelected = false;

    private Camera cam;

    private Bench_Script _bench;

    public NavMeshAgent agent;

    private bool playerBench = false;

    private void Start()
    {
        cam = Camera.main;
        _bench = GameObject.Find("Bench").GetComponent<Bench_Script>();
        if(_bench == null)
        {
            Debug.Log("The bench messed up");
        }
        if(playerBench == false)
        {
            sendToBench();
        }
    }



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
                    if (playerBench)
                    {
                        playerBench = false;
                        _bench.unOccupy();

                    }

                    //Find a way to get rid of this line
                   // this.transform.position = hit.point;
                    this.transform.position = findBoard(hit.point);
                    isSelected = false;
                }
                
            }
            else if (Input.GetKeyUp("b"))
            {
                _bench.unOccupy();
                playerBench = false;
                sendToBench();
                isSelected = false;

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
        bool isBenched = false;

       
       GameObject[] temp =  GameObject.FindGameObjectsWithTag("Bench");
        Bench_Script[] benches = new Bench_Script[temp.Length];
        for (int i = 0; i < temp.Length; i++){
            benches[i] = temp[i].GetComponent<Bench_Script>();
            if (!benches[i].occupancy() && !isBenched)
            {
                this.transform.position = benches[i].transform.position;
                benches[i].occupy();
                isBenched = true;
                _bench = benches[i];
                playerBench = true;
            }
        }
       
    }

}
