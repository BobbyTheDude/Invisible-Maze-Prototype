using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTimePad : MonoBehaviour
{
    public bool Stepped = false;
    public GameObject Timer;
    public Material Color;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Stepped == false)
            {
                Timer.GetComponent<Timer>().TimeRemaining += 10f;
                this.gameObject.GetComponent<MeshRenderer>().material = Color;
                Stepped = true;
            }
        }
    }
}

