using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    public float cameraMinClamp, cameraMaxClamp;
    float cameraVerticalRotation;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        //Get mouse input
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;

        //rotate around its local X axis
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, cameraMinClamp, cameraMaxClamp);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        //rotate around its Y axis
        transform.Rotate(Vector3.up * inputX);
    }
}
