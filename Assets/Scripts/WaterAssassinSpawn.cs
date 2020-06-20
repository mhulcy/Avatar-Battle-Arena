using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class WaterAssassinSpawn : MonoBehaviour
{
    public GameObject WaterAssassin;

    public void spawnWaterAssassin()
    {
        GameObject Water_Assassin = Instantiate(WaterAssassin, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
