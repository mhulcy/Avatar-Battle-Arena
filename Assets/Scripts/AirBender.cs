using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.AI;

public class AirBender : MonoBehaviour
{
    int health = 60;
    const int range = 6;
    int damage = 30;
    int tolerance = 5;
    float timer = 1f;
    PlayerController playerControls = new PlayerController();
    Vector3 targetCoords = new Vector3(0, 0, 0);

    Animator anim;
    GameObject target;
    public GameObject projectile;


    public GameObject elementPrefab;
    ParticleSystem air;

    public NavMeshAgent agent;
  //  PlayerController playerControls = new PlayerController();

    void Start()
    {
        anim = GetComponent<Animator>();
        air = elementPrefab.GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        playerControls = this.GetComponent<PlayerController>();
        if (!playerControls.playerBench)
        {
            
            playerControls = this.GetComponent<PlayerController>();
            if (!playerControls.playerBench)
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
                            if (target.GetComponent<Warrior_Enemy>() != null)
                            {
                                Warrior_Enemy instance = target.GetComponent<Warrior_Enemy>();
                                instance.takeDamage(attack());
                            }
                            else if (target.GetComponent<Assasin_Enemy>() != null)
                            {
                                Assasin_Enemy instance = target.GetComponent<Assasin_Enemy>();
                                instance.takeDamage(attack());
                            }
                            else if (target.GetComponent<FireBenderEnemy>() != null)
                            {
                                FireBenderEnemy instance = target.GetComponent<FireBenderEnemy>();
                                instance.takeDamage(attack());
                            }
                            else if (target.GetComponent<WaterBender_Enemy>() != null)
                            {
                                WaterBender_Enemy instance = target.GetComponent<WaterBender_Enemy>();
                                instance.takeDamage(attack());
                            }
                            else if (target.GetComponent<EarthBender_Enemy>() != null)
                            {
                                EarthBender_Enemy instance = target.GetComponent<EarthBender_Enemy>();
                                instance.takeDamage(attack());
                            }
                            else if (target.GetComponent<Airbender_Enemy>() != null)
                            {
                                Airbender_Enemy instance = target.GetComponent<Airbender_Enemy>();
                                instance.takeDamage(attack());
                            }

                        }
                    }
                    else
                    {

                        agent.isStopped = false;
                        agent.SetDestination(targetCoords);
                    }
                }
            }
        }
    }

    int attack() {
        int amount;
        //print("attacks");
        timer = 1f;
        int addedDmg = UnityEngine.Random.Range(-5, 6);
        amount = damage + addedDmg;
        anim.SetTrigger("PunchTrigger");
        air.Play();
        return amount;


        
       //air.Play();
        projectile = Instantiate(elementPrefab, new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z), Quaternion.identity) as GameObject;
        Tornado elementShot = projectile.GetComponent<Tornado>();
        elementShot.setTarget(target);
        //elementShot.transform.position = target.transform.position;

        //projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 10, ForceMode.Impulse);
        //Destroy(projectile);

        
    }

    GameObject findEnemy() {
        double min = 100000;
        GameObject nearestEnemy = null;
        double value;

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy_Piece");
        for (int i = 0; i < gameObjects.Length; ++i) {
            // print("found enemy");
            value = Math.Sqrt(Math.Pow(gameObjects[i].transform.position.x - this.transform.position.x, 2) +
                Math.Pow(gameObjects[i].transform.position.y - this.transform.position.y, 2) +
                Math.Pow(gameObjects[i].transform.position.z - this.transform.position.z, 2));
            if (value < min) {
                min = value;
                nearestEnemy = gameObjects[i];
            }
        }

        return nearestEnemy;
    }

    double findDistance(Vector3 myPos, Vector3 targetPos) {
        double distance = Math.Sqrt(Math.Pow(targetPos.x - myPos.x, 2) + Math.Pow(targetPos.z - myPos.z, 2));
        return distance;

    }
}
