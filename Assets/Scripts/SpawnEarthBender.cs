using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEarthBender : MonoBehaviour
{
    public GameObject EarthBender;

    public void spawnEarthBender()
    {
        GameObject Sokka = Instantiate(EarthBender, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
