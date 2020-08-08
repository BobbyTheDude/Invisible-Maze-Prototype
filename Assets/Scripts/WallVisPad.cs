using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVisPad : MonoBehaviour
{
    public bool SteppedOn = false;
    public GameObject WallVisibilityController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (SteppedOn == false)
            {
                WallVisibilityController.GetComponent<WallVisibilityControl>().VisPadSteppedOn();
                SteppedOn = true;
            }
        }
    }
}
