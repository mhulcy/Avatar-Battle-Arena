using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class AirBenderSpawn : MonoBehaviour
{
    public GameObject AirBender;

    public void spawnAirBender()
    {
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 3)
        {
            GameObject Air_Bender = Instantiate(AirBender, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(3);
        }
    }
}
