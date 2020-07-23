using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;
    public float gravity = -10f;
    public float jumpHeight = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    public bool canMove = true;

    void Update()
    {
        if (canMove)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButton("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }

    //Moves the player to a new location
    public void Teleport(Vector3 destination)
    {
        //Turn off canMove so update doesn't run any movement code
        canMove = false;
        transform.position = destination;
        Invoke("ResetMovement", .05f);
    }

    //Resets canMove boolean so player is able to move
    void ResetMovement()
    {
        canMove = true;
    }
    public IEnumerator GameOver()
    {
        Debug.Log("Gameover works");
        yield return new WaitForSeconds(3);
        Debug.Log("Waitforseconbds works");
        SceneManager.LoadScene("GameOver");
    }
}
