using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAirAssassin : MonoBehaviour
{
    public GameObject AirAssassin;

    public void spawnAirAssassin()
    {
        GameObject Sokka = Instantiate(AirAssassin, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
