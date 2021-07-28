using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public Transform snapPoint;
    public List<DragObject> draggableObjects;
    public float snapRange = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        foreach (DragObject draggable in draggableObjects)
        {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }
    private void OnDragEnded(DragObject draggable)
    {
        float currentDistance = Vector3.Distance(draggable.transform.position, snapPoint.position);
        Debug.Log("currentDistance " + currentDistance);

        if (currentDistance <= snapRange)
        {
            draggable.transform.position = snapPoint.position;
        } else
            draggable.ReturnToStartPosition();
    }
}