using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEarthAssassin : MonoBehaviour
{
    public GameObject EarthAssassin;

    public void spawnEarthAssassin()
    {
        GameObject Sokka = Instantiate(EarthAssassin, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
