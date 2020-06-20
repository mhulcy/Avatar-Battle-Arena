using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaterBender : MonoBehaviour
{
    public GameObject WaterBender;

    public void spawnWaterBender()
    {
        GameObject Sokka = Instantiate(WaterBender, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
