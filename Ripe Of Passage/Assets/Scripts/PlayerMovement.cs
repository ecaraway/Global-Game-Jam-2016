using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour

{
    private Vector3 movementVector;
    private CharacterController characterController;
    [SerializeField]
    private float movementSpeed = 8;
    //private float jumpPower = 15;
    //private float gravity = 0;


    void Start()
    {
        //characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        //movementVector.x = Input.GetAxis("LeftJoystickX") * movementSpeed;
        //movementVector.y = Input.GetAxis("LeftJoystickY") * movementSpeed;
        ////This turns right or left. I decided to go for a directional approach. 8 directions
        ////transform.Rotate(0, 0, 8 * Input.GetAxis("RightJoystickY"));

        //if (characterController.isGrounded)
        //{
        //    movementVector.z = 0;

        //    //if (Input.GetButtonDown("A"))
        //    //{
        //    //	movementVector.y = jumpPower;
        //    //}
        //}


        ////movementVector.y -= gravity * Time.deltaTime;

        //characterController.Move(movementVector * Time.deltaTime);



        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        transform.Translate(movement * movementSpeed * .1f);

    }

}
