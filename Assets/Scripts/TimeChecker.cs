using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChecker : MonoBehaviour
{
    public int TimeInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            Debug.Log(TimeInt.ToString());
            TimeInt += 1;
        }
        
    }
}
