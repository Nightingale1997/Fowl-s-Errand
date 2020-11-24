using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target, Chicken;
    float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60); //keep the camera focused around chicken

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        //Chicken.rotation = Quaternion.Euler(0, mouseX, 0);
        //Camera can rotate but also the chicken

    }

    // Update is called once per frame
    void Update()
    {
        CamControl();
    }
}

