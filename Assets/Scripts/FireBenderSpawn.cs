﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class FireBenderSpawn : MonoBehaviour
{
    public GameObject FireBender;

    public void spawnFireBender()
    {
        GameObject Fire_Bender = Instantiate(FireBender, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
