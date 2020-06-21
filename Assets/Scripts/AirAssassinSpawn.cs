using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class AirAssassinSpawn : MonoBehaviour
{
    public GameObject AirAssassin;

    public void spawnAirAssassin()
    {
        GameObject Air_Assassin = Instantiate(AirAssassin, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
