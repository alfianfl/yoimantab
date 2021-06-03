using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitifity = 100f;
    public Transform playerBody ;
    float xRotation = 0f;
    private float rotY = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        // Mengatur view pada mouse berdasarkan X atau Y
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitifity * Time.deltaTime ; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitifity * Time.deltaTime; 
        
        // rotasi dibatasi dari -90derjat sampai 90 derjat pada sumbu Y
        xRotation -= mouseY;
        rotY += mouseX * mouseSensitifity * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);

        transform.localRotation = Quaternion.Euler(xRotation,rotY,0f);
        playerBody.Rotate(Vector3.up * mouseY) ;
    }

}
