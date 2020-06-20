using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnEarthWarrior : MonoBehaviour
{
   public GameObject EarthWarrior;
      
   public void spawnWarrior()
    {
        GameObject Sokka = Instantiate(EarthWarrior, new Vector3(1, 1, 1), Quaternion.identity);
    }

}
