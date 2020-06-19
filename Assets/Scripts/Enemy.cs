using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 EnemyCoor()
    {
        float xVal = transform.position.x;
        float yVal = transform.position.y;
        float zVal = transform.position.z;
        Vector3 coordinates = new Vector3(xVal, yVal, zVal);
        return coordinates;
    }
}
