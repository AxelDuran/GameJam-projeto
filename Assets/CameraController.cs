using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float _sensibilidade = 100f;
    public Transform playerBody;
    float xRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * _sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensibilidade * Time.deltaTime;
        
        float _mouseScrool = Input.mouseScrollDelta.y;

        transform.position += transform.forward * _mouseScrool;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -20f, 20f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
