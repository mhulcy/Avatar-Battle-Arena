using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnWarrior : MonoBehaviour
{
   public void spawnWarrior()
    {
        Instantiate(Character_Samurai_Grunt, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
