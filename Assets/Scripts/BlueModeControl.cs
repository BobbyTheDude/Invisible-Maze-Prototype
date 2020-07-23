using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueModeControl : MonoBehaviour
{
    public int TotalPads;
    public int RemainingPads;

    // Start is called before the first frame update
    void Start()
    {
        TotalPads = GameObject.FindGameObjectsWithTag("ChangePad").Length;
        RemainingPads = TotalPads;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
