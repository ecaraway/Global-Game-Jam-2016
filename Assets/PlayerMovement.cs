using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour

{
    private Vector3 movementVector;
    private CharacterController characterController;
    private float movementSpeed = 8;
    private float jumpPower = 15;
    private float gravity = 40;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;
        movementVector.z = Input.GetAxis("LeftJoystickY") * movementSpeed;
        //This turns right or left. I decided to go for a directional approach. 8 directions
        transform.Rotate(0, 8 * Input.GetAxis("RightJoystickY"), 0);

        if (characterController.isGrounded)
        {
            movementVector.y = 0;

            if (Input.GetButtonDown("A"))
            {
                movementVector.y = jumpPower;
            }
        }


        movementVector.y -= gravity * Time.deltaTime;

        characterController.Move(movementVector * Time.deltaTime);

    }

}
