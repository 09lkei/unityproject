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
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(Input.GetAxisRaw("Horizontal"));
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(HorizontalMovement,false,jump);
    }
}
