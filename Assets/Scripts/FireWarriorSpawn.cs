using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FireWarriorSpawn : MonoBehaviour
{
    public GameObject FireWarrior;

    public void spawnFireWarrior()
    {
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 1)
        {
            GameObject Fire_Warrior = Instantiate(FireWarrior, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(1);
        }
    }
}
