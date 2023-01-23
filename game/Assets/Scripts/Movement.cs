using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    private float HorizontalMovement = 0f;
    public float movementSpeed = 0f;
    public Animator animator;
    public Rigidbody2D rb;

    private bool jump = false;
    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        Debug.Log(HorizontalMovement);
        if (movementSpeed<1) {
            movementSpeed+=HorizontalMovement/1000;
        }
        if (movementSpeed!=0 && HorizontalMovement==0) {
            movementSpeed=0;
        }
        animator.SetFloat("Speed",Math.Abs(HorizontalMovement));
        animator.SetFloat("Horizontal",rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(movementSpeed,false,jump);
        jump = false;
    }
}
