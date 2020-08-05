using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkChangePad : MonoBehaviour
{
    public Material Color;
    public bool BlueMode = false;
    public GameObject BlueController;
    public bool HasSteppedOn = false;
    public GameObject BlueLight;

    void Start()
    {
        //this.gameObject.GetComponent<MeshRenderer>().material = Color;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<MeshRenderer>().material = Color;
            BlueLight.SetActive(true);
            if (BlueMode)
            {
                if (HasSteppedOn == false)
                {
                    BlueController.GetComponent<BlueModeControl>().RemainingPads -= 1;
                    HasSteppedOn = true;
                    BlueLight.SetActive(true);
                }

            }
        }
    }
}
