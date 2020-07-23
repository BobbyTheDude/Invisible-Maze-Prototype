using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    // declare this and initialize outside your function
    Vector3 moveDirection = Vector3.forward; // *assuming your platform starts at the bottom
    public int speed = 2;

    private void Update()
    {
        move();
    }
    void move()
    {
        if (transform.position.y >= 8)
        {
            moveDirection = Vector3.back;
        }

        else if(transform.position.y <= 0)
        {
            moveDirection = Vector3.forward;
        }
        // implicit else... if it's in between, it should keep moving in the same direction it last was...

        transform.Translate(moveDirection * Time.deltaTime * speed);
    }
}
