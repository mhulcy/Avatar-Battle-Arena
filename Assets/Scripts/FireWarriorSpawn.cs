using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class FireWarriorSpawn : MonoBehaviour
{
    public GameObject FireWarrior;

    public void spawnWarrior()
    {
        GameObject Fire_Warrior = Instantiate(FireWarrior, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
