﻿using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.AI;

public class FireBenderEnemy : MonoBehaviour
{
    bool combatState = false;
    int health = 60;
    const int range = 6;
    int damage = 30;
    int tolerance = 5;
    float timer = 1f;

    Vector3 targetCoords = new Vector3(0, 0, 0);

    Animator anim;
    GameObject target;
    public GameObject projectile;

    public HealthBar healthBar;

    public GameObject getHealth;

    public GameObject elementPrefab;

    public NavMeshAgent agent;
    PlayerController playerControls = new PlayerController();


    void Start()
    {
        healthBar = getHealth.GetComponent<HealthBar>();
        anim = GetComponent<Animator>();
        healthBar.setMaxHealth(health);
        healthBar.setHealth(health);
    }

    // Update is called once per frame
    void Update()
    {


        if (combatState) {



            target = findEnemy();
            if (target != null) {
                targetCoords = target.transform.position;
                anim.SetBool("IsWalking", true);
                if (findDistance(this.transform.position, targetCoords) < range) {
                    anim.SetBool("IsWalking", false);
                    agent.isStopped = true;
                    timer -= Time.deltaTime;
                    if (timer < 0) {
                        if (target.GetComponent<AirBender>() != null) {
                            AirBender instance = target.GetComponent<AirBender>();
                            instance.takeDamage(attack());
                        }
                        else if (target.GetComponent<Assasin>() != null) {
                            Assasin instance = target.GetComponent<Assasin>();
                            instance.takeDamage(attack());
                        }
                        else if (target.GetComponent<EarthBender>() != null) {
                            EarthBender instance = target.GetComponent<EarthBender>();
                            instance.takeDamage(attack());
                        }
                        else if (target.GetComponent<FireBender>() != null) {
                            FireBender instance = target.GetComponent<FireBender>();
                            instance.takeDamage(attack());
                        }
                        else if (target.GetComponent<Warrior>() != null) {
                            Warrior instance = target.GetComponent<Warrior>();
                            instance.takeDamage(attack());
                        }
                        else if (target.GetComponent<WaterBender>() != null) {
                            WaterBender instance = target.GetComponent<WaterBender>();
                            instance.takeDamage(attack());
                        }

                    }
                }
                else {

                    agent.isStopped = false;
                    agent.SetDestination(targetCoords);
                }

            }


        }
    }



    public void takeDamage(int amount)
    {
        health -= amount;
        healthBar.setHealth(health);
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    int attack()
    {
        anim.SetTrigger("PunchTrigger");

        projectile = Instantiate(elementPrefab, new Vector3(this.transform.position.x, this.transform.position.y - 1.2f, this.transform.position.z), Quaternion.identity) as GameObject;
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

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player_Piece");
        for (int i = 0; i < gameObjects.Length; ++i)
        {
            PlayerController benchDetector = gameObjects[i].GetComponent<PlayerController>();
            if (!benchDetector.playerBench)
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
        }


        return nearestEnemy;
    }

    double findDistance(Vector3 myPos, Vector3 targetPos)
    {
        double distance = Math.Sqrt(Math.Pow(targetPos.x - myPos.x, 2) + Math.Pow(targetPos.z - myPos.z, 2));
        return distance;

    }
    public void isCombat() {
        //print("combat ");
        combatState = true;
    }

    public void notCombat() {
        combatState = false;
    }

}
