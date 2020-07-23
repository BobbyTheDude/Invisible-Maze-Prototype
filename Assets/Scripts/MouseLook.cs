using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float MouseSensitivity = 100f;

    float XRotation = 0f;

    public Transform PlayerBody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        XRotation -= MouseY;

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}
