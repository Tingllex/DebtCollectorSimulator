using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensitivity;
    public Transform target;
    float mouseX, mouseY;
    public ConfigurableJoint hipJoint, stomachJoint;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
        mouseY = Mathf.Clamp(mouseY, -15, 60);
        Quaternion targetRotation = Quaternion.Euler(mouseY, mouseX, 0);
        target.rotation = targetRotation;

        hipJoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        stomachJoint.targetRotation = Quaternion.Euler(-mouseY, 0, 0);
    }
}