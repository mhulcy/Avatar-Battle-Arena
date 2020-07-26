using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class AirWarriorSpawn : MonoBehaviour
{
    public GameObject AirWarrior;

    public void spawnAirWarrior()
    {
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 1)
        {
            GameObject Air_Warrior = Instantiate(AirWarrior, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(1);
        }
    }
}
