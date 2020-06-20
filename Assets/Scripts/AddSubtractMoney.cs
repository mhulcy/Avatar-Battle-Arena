using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSubtractMoney : MonoBehaviour
{

    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("p"))
        {
            cam.GetComponent<PlayerMoney>().addMoney(5);
        }

        if (Input.GetKey("o"))
        {
            cam.GetComponent<PlayerMoney>().subtractMoney(5);
        }
    }
}
