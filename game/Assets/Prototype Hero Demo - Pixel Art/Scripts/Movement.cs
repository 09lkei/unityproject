using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    private float HorizontalMovement = 0f;
    public float movementSpeed = 0f;

    private bool jump = false;
    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal") * movementSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(HorizontalMovement * Time.fixedDeltaTime,false,jump);
    }
}
