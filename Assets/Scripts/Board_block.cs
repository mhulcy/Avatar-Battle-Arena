using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board_block : MonoBehaviour
{
    // Start is called before the first frame update
    Outline outline;
    void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        outline.enabled = true;
    }
    private void OnMouseExit() {
        outline.enabled = false;
    }
}
