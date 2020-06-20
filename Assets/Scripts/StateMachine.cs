using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public enum State
{
    TITLE,
    PLAYERTURN,
    COMBAT,
    WIN,
    LOSE
}

public class StateMachine : MonoBehaviour
{

    public State state;

    // Start is called before the first frame update
    void Start()
    {
        state = State.TITLE;
    }

    void Update()
    {
        
    }

}
