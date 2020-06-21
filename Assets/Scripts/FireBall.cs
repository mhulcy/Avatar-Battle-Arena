using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private GameObject target;
    private float _speed = .2f;
    private float _time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("ran");
       // this.transform.position = target.transform.position;
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(target.transform.position.x, target.transform.position.y + 1.1f, target.transform.position.z), _speed);
        _time += Time.deltaTime;

        if (_time > 1.5)
        {
            Destroy(this.gameObject);
        }

    }
   public void setTarget(GameObject attackMe)
    {
        target = attackMe;
    }
}
