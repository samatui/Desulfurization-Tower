using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private Transform cameraTransform;

    public CharacterController controller;

    public Vector3 pos;

    private Vector3 dragStartPosition;
    private Vector3 dragCurrentPosition;

    void Start()
    {
        cameraTransform = transform;
    }
    void Update()
    { 
        float z = Input.GetAxis("Mouse ScrollWheel");
        Vector3 move = transform.forward * z;
        controller.Move(move * 100f * Time.deltaTime);
        HandleMouseInput();
    }

    void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(2))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);
            //Plane plane = new Plane(cameraTransform.position.normalized, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if (plane.Raycast(ray, out entry))
            {
                dragStartPosition = ray.GetPoint(entry);
            }
        }
        if (Input.GetMouseButton(2))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);
            //Plane plane = new Plane(cameraTransform.position.normalized, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if (plane.Raycast(ray, out entry))
            {
                dragCurrentPosition = ray.GetPoint(entry);
                pos = transform.position + (dragStartPosition - dragCurrentPosition);
            }
        }
        if (Input.GetMouseButton(2))
        {
            controller.Move((dragStartPosition - dragCurrentPosition) * 5f * Time.deltaTime);
        }
    }
}
