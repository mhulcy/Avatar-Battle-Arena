using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAirWarrior : MonoBehaviour
{
    public GameObject AirWarrior;

    public void spawnAirWarrior()
    {
        GameObject Sokka = Instantiate(AirWarrior, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
