using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bench_Script : MonoBehaviour
{
    private bool isOccupied = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void occupy()
    {
        isOccupied = true;
    }

    void unOccupy()
    {
        isOccupied = false;
    }

    bool occupancy()
    {
        return isOccupied;
    }



}
