using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float ScrollSpeed = 2f;
    public float zLimit = 40f;
    public Vector3 pos;

    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;

    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMousetInput();
        transform.position  = Vector3.Lerp(transform.position, pos, Time.deltaTime*5);
    }
    void HandleMousetInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if(plane.Raycast(ray, out entry))
            {
                dragStartPosition = ray.GetPoint(entry);
            }
        }
        if (Input.GetMouseButton(0))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if(plane.Raycast(ray, out entry))
            {
                dragCurrentPosition = ray.GetPoint(entry);
                pos = transform.position + (dragStartPosition - dragCurrentPosition);
            }
        }
    }
    
}
