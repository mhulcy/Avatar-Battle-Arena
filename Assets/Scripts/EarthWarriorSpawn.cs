using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class EarthWarriorSpawn : MonoBehaviour
{
    public GameObject EarthWarrior;

    public void spawnEarthWarrior()
    {
        GameObject Earth_Warrior = Instantiate(EarthWarrior, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
