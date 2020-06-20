using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaterWarrior : MonoBehaviour
{
    public GameObject WaterWarrior;

    public void spawnWaterWarrior()
    {
        GameObject Sokka = Instantiate(WaterWarrior, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
