using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaterAssassin : MonoBehaviour
{
    public GameObject WaterAssassin;

    public void spawnWaterAssassin()
    {
        GameObject Sokka = Instantiate(WaterAssassin, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
