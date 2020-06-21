using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    ParticleSystem WaterEffect;
    // Start is called before the first frame update
    void Start()
    {
        WaterEffect = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootWater() {
        WaterEffect.Play();
    }
}
