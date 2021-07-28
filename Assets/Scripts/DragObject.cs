using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public delegate void DragEndedDelegate(DragObject draggableObject);
    public DragEndedDelegate dragEndedCallback;

    public float yOffsetForDraggedObject = 1;
    Vector3 objectDragStartPosition;
    Quaternion objectDragStartRotation;
    Plane plane;
    float distance;
    bool isDragged = false;

    private void Start()
    {
        plane = new Plane(Vector3.up, new Vector3(0, yOffsetForDraggedObject, 0));
    }

    private void OnMouseDown()
    {
        isDragged = true;
        objectDragStartPosition = transform.position;
        //Debug.Log("objectDragStartPosition" + objectDragStartPosition);
        objectDragStartRotation = transform.rotation;
        //Debug.Log("objectDragStartRotation" + objectDragStartRotation);
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (plane.Raycast(ray, out distance))
            {
                transform.position = ray.GetPoint(distance);
            }
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallback(this);
    }

    public void ReturnToStartPosition()
    {
        transform.position = objectDragStartPosition;
        transform.rotation = objectDragStartRotation;
    }
}