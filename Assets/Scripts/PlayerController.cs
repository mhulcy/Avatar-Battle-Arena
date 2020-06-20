using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private bool isSelected = false;

    public Camera cam;

    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        
        if (isSelected)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    this.transform.position = hit.point;
                    
                }
                isSelected = false;
            }
        }
        


    }

    void OnMouseDown()
    {
        
        
            print("Got into if statement");
            isSelected = true;
        
    }
}
