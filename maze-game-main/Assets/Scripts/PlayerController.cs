using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public static CharacterController CController;
    public static PlayerController Instance;

    private void Awake()
    {
        Instance = this;
        CController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void LateUpdate()
    {
        if (Camera.main == null)
        {
            return;
        }

        this.GetLocomotionInput();
        this.HandleActionInput();

        CharacterMotor.Instance.UpdateMotor();
    }
    void GetLocomotionInput()
    {

        float deadZone = 0.1f;

        CharacterMotor.Instance.VerticalVelocity = CharacterMotor.Instance.MoveVector.y;

        CharacterMotor.Instance.MoveVector = Vector3.zero;

            if (Input.GetAxis("Vertical") > deadZone || Input.GetAxis("Vertical") < -deadZone)
            {
                CharacterMotor.Instance.MoveVector += new Vector3(0, 0, Input.GetAxis("Vertical"));
            }

            if (Input.GetAxis("Horizontal") > deadZone || Input.GetAxis("Horizontal") < -deadZone)
            {
                CharacterMotor.Instance.MoveVector += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            }
        
    }
    void HandleActionInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Jump();
        }
    }
    void Jump()
    {
        CharacterMotor.Instance.Jump();
    }
}
