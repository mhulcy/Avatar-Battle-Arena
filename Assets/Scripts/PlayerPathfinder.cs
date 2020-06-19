using Boo.Lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPathfinder : MonoBehaviour
{ 
    public NavMeshAgent agent;
    private Enemy _Enemy;
    private bool boolVal = true;


    void Start()
    {
        _Enemy = GameObject.Find("Enemy_Piece").GetComponent<Enemy>();
        if(_Enemy == null)
        {
           print("WE messed up badly");
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(getClosest());
        print(getClosest());
    }

Vector3 getClosest()
    {
        Vector3 min = new Vector3(0,0,0);
        double minVal = 1000000;
        double distance;

       GameObject[] objectArray =  GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for(int i=  0; i < objectArray.Length; ++i)
        {
           distance = Math.Sqrt(
                Math.Pow(objectArray[i].transform.position.x - this.transform.position.x, 2)+
                 Math.Pow(objectArray[i].transform.position.y - this.transform.position.y,2) + 
                 Math.Pow(objectArray[i].transform.position.z - this.transform.position.z, 2));
            

            if(distance < minVal)
            {
                minVal = distance;
                min = new Vector3(objectArray[i].transform.position.x, objectArray[i].transform.position.y, objectArray[i].transform.position.z);
            }
        }
        return min;
    }


}
