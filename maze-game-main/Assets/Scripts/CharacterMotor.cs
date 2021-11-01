using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public static CharacterMotor Instance;

    public Vector3 MoveVector{
        get; 
        set;
    }

    public float ForwardSpeed = 3f;

    public float BackwardSpeed = 3f;

    public float StrafeSpeed = 3f;

    public float JumpSpeed = 3f;

    public float Gravity = 21f;

    public float TerminalVelocity = 20f;

    public float VerticalVelocity{
        get;
        set;
    }

    private void Awake() {
        Instance = this;
    }

    public void UpdateMotor() {
        this.AlignCharacterWithCamera();
        this.ProcessMotion();
    }

    public void ProcessMotion(){
        MoveVector = transform.TransformDirection(MoveVector);

        if (MoveVector.magnitude > 1)
        {
            MoveVector = Vector3.Normalize(MoveVector);
        }

        MoveVector *= ForwardSpeed;

        MoveVector = new Vector3(MoveVector.x, VerticalVelocity, MoveVector.z);

        ApplyGravity();

        PlayerController.CController.Move(MoveVector * Time.deltaTime);
    }
    public void ApplyGravity(){
        if (MoveVector.y > -TerminalVelocity)
        {
            MoveVector = new Vector3(MoveVector.x, MoveVector.y - Gravity * Time.deltaTime, MoveVector.z);
        }
    }
    public void AlignCharacterWithCamera(){
        if ((MoveVector.x != 0 || MoveVector.z != 0)) 
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, transform.transform.eulerAngles.z);
        }
    }
    public void Jump(){
         if (PlayerController.CController.isGrounded)
        {
            VerticalVelocity = JumpSpeed;
        }
    }
    
}
