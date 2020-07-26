using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FireAssassinSpawn : MonoBehaviour
{
    public GameObject FireAssassin;

    public void spawnFireAssassin()
    {
        if (Camera.main.GetComponent<PlayerMoney>().getPlayerMoney() >= 2)
        {
            GameObject Fire_Assassin = Instantiate(FireAssassin, new Vector3(0, 0, 0), Quaternion.identity);
            Camera.main.GetComponent<PlayerMoney>().subtractMoney(2);
        }
    }

}
