using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private Transform cameraTransform;

    private Vector3 cameraRotation;
    //灵敏度
    public float MouseSensitivity = 3;
       
    //限制度数
    public Vector2 MaxminAngle;

    public CharacterController controller;

    public Vector3 pos;

    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = transform;
        cameraRotation.z = transform.eulerAngles.x;
        cameraRotation.y = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            float MouseX = Input.GetAxis("Mouse X");
            float MouseY = Input.GetAxis("Mouse Y");

            cameraRotation.z -= MouseY * MouseSensitivity;
            cameraRotation.y += MouseX * MouseSensitivity;

            cameraTransform.rotation = Quaternion.Euler(cameraRotation.z, cameraRotation.y, 0);
        }
        float z = Input.GetAxis("Mouse ScrollWheel");
        Vector3 move = transform.forward * z;
        controller.Move(move * 100f * Time.deltaTime);
        /*else if (Input.GetMouseButtonUp(0))//如果鼠标左键抬起，就恢复摄像机拍摄主角的位置
        {
            //重置摄像机父物体归零
            cameraTransform.localPosition = new Vector3(0, 0, 0);
            cameraTransform.localRotation = Quaternion.Euler(0, 0, 0);
        }
*/      HandleMousetInput();

    }

    void HandleMousetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if (plane.Raycast(ray, out entry))
            {
                dragStartPosition = ray.GetPoint(entry);
            }
        }
        if (Input.GetMouseButton(0))
        {
            Plane plane = new Plane(Vector3.forward, Vector3.zero);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if (plane.Raycast(ray, out entry))
            {
                dragCurrentPosition = ray.GetPoint(entry);
                pos = transform.position + (dragStartPosition - dragCurrentPosition);
            }
        }
        if (Input.GetMouseButton(0))
        {
            controller.Move((dragStartPosition - dragCurrentPosition) * 5f * Time.deltaTime);
        }
    }
}
