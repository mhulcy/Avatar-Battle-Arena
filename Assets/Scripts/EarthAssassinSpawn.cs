using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class EarthAssassinSpawn : MonoBehaviour
{
    public GameObject EarthAssassin;

    public void spawnEarthAssassin()
    {
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 2)
        {
            GameObject Earth_Assassin = Instantiate(EarthAssassin, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(2);
        }
    }
}
