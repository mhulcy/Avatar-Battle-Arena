using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class WaterWarriorSpawn : MonoBehaviour
{
    public GameObject WaterWarrior;

    public void spawnWaterWarrior()
    {
        GameObject Water_Warrior = Instantiate(WaterWarrior, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
