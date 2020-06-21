using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class WaterBenderSpawn : MonoBehaviour
{
    public GameObject WaterBender;

    public void spawnWaterBender()
    {
        GameObject Water_Bender = Instantiate(WaterBender, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
