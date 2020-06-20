using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.AI;

public class Bender : MonoBehaviour
{
    int health = 60;
    const int range = 6;
    int damage = 30;
    int tolerance = 5;
    float timer = 1f;

    Vector3 targetCoords = new Vector3(0, 0, 0);

    Animator anim;
    GameObject target;
    public GameObject projectile;


    public GameObject elementPrefab;

    public NavMeshAgent agent;


    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        


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
                    
                       
                        //if (projectile.transform.position == target.transform.position)
                            //Destroy(projectile);
                    
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

        projectile = Instantiate(elementPrefab, new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z), Quaternion.identity) as GameObject;
        FireBall elementShot = projectile.GetComponent<FireBall>();
         elementShot.setTarget(target);
        //elementShot.transform.position = target.transform.position;
        
        //projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.Impulse);
        //Destroy(projectile);

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
