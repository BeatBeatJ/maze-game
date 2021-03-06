using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = .8f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Vector3 velocity;
    bool isGrounded;
    
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //Could be 0.
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //Relative movement.

        controller.Move(move * speed * Time.deltaTime);


        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //teleporter!!
        if(hit.gameObject.name == "Teleporter1")
        {
            gameObject.transform.position = new Vector3(47f, transform.position.y, transform.position.z);
        }

        if(hit.gameObject.name == "Teleporter2")
        {
            gameObject.transform.position = new Vector3(27f, transform.position.y, transform.position.z);
        }

        //jumpPad!! copied jump script from above
        if(hit.gameObject.name == "JumpPad")
        {
            velocity.y = Mathf.Sqrt(3f * -2f * gravity);
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }

    
    

    
}
