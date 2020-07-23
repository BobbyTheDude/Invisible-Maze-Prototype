using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public Camera Cam1;
    public Camera Cam2;
 
    void Start()
    {
        Cam1 = Camera1.GetComponent<Camera>();
        Cam2 = Camera2.GetComponent<Camera>();
        Cam1.enabled = true;
        Cam2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Cam1.enabled = !Cam1.enabled;
            Cam2.enabled = !Cam2.enabled;
        }
    }
}
