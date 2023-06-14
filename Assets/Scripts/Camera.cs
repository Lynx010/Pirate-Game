using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(Vector3.up * inputX);
    }
}
