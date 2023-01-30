using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    private float HorizontalMovement = 0f;
    private float currentSpeed = 0f;
    public Animator animator;
    public Rigidbody2D rb;
	public float maxSpeed = 1;
	public float movementSpeed = 1;

    private bool jump = false;
    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal")*movementSpeed;
        if (Math.Abs(currentSpeed)<maxSpeed) {
            currentSpeed+=HorizontalMovement/1000;
        }
        if (movementSpeed!=0 && HorizontalMovement==0) {
            currentSpeed=0;
        }
        animator.SetFloat("Speed",Math.Abs(currentSpeed));
        animator.SetFloat("Vertical",rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(currentSpeed,false,jump);
        jump = false;
    }
}
