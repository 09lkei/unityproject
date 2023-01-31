using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform self;
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Transform player;
    [SerializeField] private float maxSpeed = 0.5f;
	[SerializeField] private float movementSpeed = 0.5f;
    private float HorizontalMovement = 0f;
    private float currentSpeed = 0f;
    private bool jump = false;
    // Update is called once per frame
    void Start() {
        currentSpeed=movementSpeed;
    }
    void Update()
    {
        Debug.Log(movementSpeed);
        if (player.position.x>self.position.x) {
            HorizontalMovement=1f;
        } else {
            HorizontalMovement=-1f;
        }
        animator.SetFloat("Speed",Math.Abs(HorizontalMovement*currentSpeed));
        animator.SetFloat("Vertical",rb.velocity.y);
        
    }
    void FixedUpdate()
    {
        controller.Move(HorizontalMovement*currentSpeed,false,jump);
        jump = false;
    }
    public void takeDamage() {
        rb.velocity = new Vector2(self.position.x-player.position.x,3);
        animator.SetTrigger("Hurt");
        StartCoroutine(stun());
    }
    IEnumerator stun() {
        currentSpeed = 0;
        yield return new WaitForSeconds(3);
        currentSpeed=movementSpeed;
    }
}
