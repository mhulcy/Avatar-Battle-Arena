using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAirBender : MonoBehaviour
{
    public GameObject AirBender;

    public void spawnAirBender()
    {
        GameObject Sokka = Instantiate(AirBender, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
