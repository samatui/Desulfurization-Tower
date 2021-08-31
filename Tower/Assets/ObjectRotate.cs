using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public GameObject mainCamera;
    private Vector3 cameraRotation;
    public float MouseSensitivity = 3;

    private float MouseX;
    private float MouseY;
    private void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            MouseX = Input.GetAxis("Mouse X");
            MouseY = Input.GetAxis("Mouse Y");

            cameraRotation.z -= MouseY * MouseSensitivity;
            cameraRotation.y += MouseX * MouseSensitivity;

            transform.rotation = Quaternion.Euler(0, -cameraRotation.y, 0);
        }
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(Vector3.zero);
        //mainCamera.transform.position = new Vector3(-2f, -0.5f, 8f);
    }
}
