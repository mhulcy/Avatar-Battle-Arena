using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnWarrior : MonoBehaviour
{
   public GameObject EarthWarrior;
      
   public void spawnWarrior()
    {
        print("called");
        GameObject Sokka = Instantiate(EarthWarrior, new Vector3(1, 1, 1), Quaternion.identity);
    }

}
