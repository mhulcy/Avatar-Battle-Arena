using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPathfinder : MonoBehaviour
{ 
    public NavMeshAgent agent;
    private Enemy _Enemy;



    void Start()
    {
        /*
        _Enemy = GameObject.Find("Enemy_Piece").GetComponent<Enemy>();
        if(_Enemy == null)
        {
           print("WE messed up badly");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {


        agent.SetDestination(findEnemy());
    }

    Vector3 findEnemy()
    {
        double min = 100000;
        Vector3 nearestEnemy = this.transform.position;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - this.transform.position.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - this.transform.position.y, 2) + 
                Math.Pow(gameObjects[i].transform.position.z - this.transform.position.z, 2));
            if(value < min)
            {
                min = value;
                nearestEnemy = new Vector3(gameObjects[i].transform.position.x, gameObjects[i].transform.position.y, gameObjects[i].transform.position.z);
            }
        }
        
        return nearestEnemy;
    }

}
