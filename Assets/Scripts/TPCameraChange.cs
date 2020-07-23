using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCameraChange : MonoBehaviour
{
    public GameObject Camera;
    public bool Close;
    void Start()
    {
        Close = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (Close)
            {

                Camera.GetComponent<vThirdPersonCamera>().height = 12f;
                Camera.GetComponent<vThirdPersonCamera>().defaultDistance = 12f;
                Close = false;

            }
            else
            {
                Camera.GetComponent<vThirdPersonCamera>().height = 5f;
                Camera.GetComponent<vThirdPersonCamera>().defaultDistance = 5f;
                Close = true;
            }
        }
    }
}
