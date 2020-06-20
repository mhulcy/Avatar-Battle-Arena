using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.AI;

public class Assasin : MonoBehaviour
{
    int health = 50;
    const int range = 3;
    int damage = 40;
    int tolerance = 20;
    float timer = 1f;

    bool usedMove = false;

    Vector3 targetCoords = new Vector3(0, 0, 0);

    Animator anim;
    GameObject target;


    public NavMeshAgent agent;


    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if (!usedMove)
        {
            GameObject farEnemy = findFarEnemy();
            usedMove = true;
            superMove(farEnemy.transform.position);
        }


        target = findEnemy();
        if (target != null)
        {
           
            targetCoords = target.transform.position;
            anim.SetBool("IsWalking", true);
            if (findDistance(this.transform.position, targetCoords) < range)
            {
                anim.SetBool("IsWalking", false);
                agent.isStopped = true;
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    print(attack());
                }
            }
            else
            {

                agent.isStopped = false;
                agent.SetDestination(targetCoords);
            }
        }

    }




    int attack()
    {
        anim.SetTrigger("PunchTrigger");
        int amount;
        print("attacks");
        timer = 1f;
        int addedDmg = UnityEngine.Random.Range(-20, 21);
        amount = damage + addedDmg;
        return amount;
    }


    void superMove(Vector3 coords)
    {
        this.transform.position = coords;
    }


    GameObject findFarEnemy()
    {
        double max = 0;
        GameObject farthestEnemy = null;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            // print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - this.transform.position.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - this.transform.position.y, 2) +
                Math.Pow(gameObjects[i].transform.position.z - this.transform.position.z, 2));
            if (value > max)
            {
                max = value;
                farthestEnemy = gameObjects[i];
            }
        }

        return farthestEnemy;
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
