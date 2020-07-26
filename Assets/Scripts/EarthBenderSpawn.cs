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
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 3)
        {
            GameObject Earth_Bender = Instantiate(EarthBender, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(3);
        }
    }
}
