using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPathfinder : MonoBehaviour
{
    public NavMeshAgent agent;
    private Enemy _Enemy;



    void Start()
    {
        _Enemy = GameObject.Find("Enemy_Piece").GetComponent<Enemy>();
        if(_Enemy == null)
        {
           print("WE messed up badly");
        }
    }

    // Update is called once per frame
    void Update()
    {
       print( _Enemy.EnemyCoor());
        Vector3 vektor = new Vector3 (1, 2, 3);
        agent.SetDestination(_Enemy.EnemyCoor());
    }





}
