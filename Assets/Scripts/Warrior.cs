﻿using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.AI;

public class Warrior : MonoBehaviour
{
    int health = 100;
    const int range = 2;
    int damage = 20;
    int tolerance = 5;
    float timer = 1f;

    Vector3 targetCoords = new Vector3 (0,0,0);

    GameObject target;


    public NavMeshAgent agent;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


        target = findEnemy();
        if(target != null)
        {
            targetCoords = target.transform.position;
            if(findDistance(this.transform.position, targetCoords) < range)
            {
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    print(attack());
                }
            }
            else
            {
                agent.SetDestination(targetCoords);
            }
        }

    }




    int attack()
    {
            int amount; 
            //print("attacks");
            timer = 1f;
            int addedDmg = UnityEngine.Random.Range(-5, 6);
            amount = damage + addedDmg;
            return amount;
    }

    GameObject findEnemy()
    {
        double min = 100000;
        GameObject nearestEnemy = null;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            // print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - this.transform.position.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - this.transform.position.y, 2) +
                Math.Pow(gameObjects[i].transform.position.z - this.transform.position.z, 2));
            if (value < min)
            {
                min = value;
                nearestEnemy = gameObjects[i];
            }
        }

        return nearestEnemy;
    }

    double findDistance(Vector3 myPos, Vector3 targetPos)
    {
        double distance = Math.Sqrt(Math.Pow(targetPos.x - myPos.x, 2) + Math.Pow(targetPos.z - myPos.z, 2));
        return distance;

    }


}
