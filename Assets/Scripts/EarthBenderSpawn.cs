using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class EarthBenderSpawn : MonoBehaviour
{
    public GameObject EarthBender;

    public void spawnEarthBender()
    {
        GameObject Earth_Bender = Instantiate(EarthBender, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
