using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Camera myCamera;
    public float rotationSpeed = 15f;
    CharacterController controller;
    float x, z;
    float speed = 5f;
    float desiredRotation = 0f;
    float speedY = 0f;
    float gravity = -9.81f;
    //float jumpSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //movement inputs
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, z).normalized; //prevents movement to be faster when pressing two directions

        //allows movement to be relative to camera direction
        Vector3 rotatedMovement = Quaternion.Euler(0, myCamera.transform.rotation.eulerAngles.y, 0) * movement;



        //setting gravity
        Vector3 verticalMovement = Vector3.up * speedY;

        if (!controller.isGrounded)
        {

            speedY += gravity * Time.deltaTime;
        }
        else
        {
            speedY = 0f;

            //if (Input.GetButtonDown("Jump"))
            //speedY += jumpSpeed * Time.deltaTime;


        }



        //actual move function
        controller.Move(verticalMovement + (rotatedMovement * speed) * Time.deltaTime);


        //only rotate when moving
        if (rotatedMovement.magnitude > 0)
        {
            desiredRotation = Mathf.Atan2(rotatedMovement.x, rotatedMovement.z) * Mathf.Rad2Deg;  //converts movement vector into an angle
                                                                                                  //Mathf.Rad2Deg means convert from radians to degrees
        }

        //allows for smooth transition between rotations
        Quaternion currentRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(0, desiredRotation, 0);
        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);


    }
}
