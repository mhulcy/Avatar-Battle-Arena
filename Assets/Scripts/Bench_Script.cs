using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bench_Script : MonoBehaviour
{
    [SerializeField]
    private bool isOccupied = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void occupy()
    {
        isOccupied = true;
    }

    public void unOccupy()
    {
        isOccupied = false;
    }

   public bool occupancy()
    {
        return isOccupied;
    }



}
