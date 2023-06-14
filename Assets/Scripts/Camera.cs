using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouseSensitivity = 2f;

    [Header("Clamp Values")]
    public float cameraMinClampX;
    public float cameraMaxClampX;
    /*public float cameraMinClampY;
    public float cameraMaxClampY;*/

    float cameraVerticalRotation;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        //Get mouse input
        float inputY = Input.GetAxis    ("Mouse Y") * mouseSensitivity;
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;

        //rotate around its Y axis
        transform.Rotate(Vector3.up * inputX);

        //rotate around its local X axis
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, cameraMinClampX, cameraMaxClampX);
        //transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
        transform.localEulerAngles = new Vector3(cameraVerticalRotation, transform.localEulerAngles.y, 0f);
    }
}
