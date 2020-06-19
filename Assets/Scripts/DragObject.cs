using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
       // print("Mouse down was called");
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mousePoint.y;
        mousePoint.y = 1.1f;
        

       // print("mouse point:" + mousePoint);

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
       // print("mouse Dragging called");
        transform.position = new Vector3 (GetMouseAsWorldPoint().x , 1.1f, GetMouseAsWorldPoint().z / 10);
    }

}
