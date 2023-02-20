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
    [SerializeField] private float aggroRange = 1f;
	[SerializeField] private float minRange = 0.1f;
    [SerializeField] private Attributes selfAttributes;
    private bool canShoot;
    private float HorizontalMovement = 0f;
    private float currentSpeed = 0f;
    private bool jump = false;
	private int stuntime = 0;
    private float hitRange = 1f;
    // Update is called once per frame
    void Start() {
        currentSpeed=movementSpeed;
    }
    void Update()
    {
        if (Math.Abs(player.position.x - self.position.x) < hitRange && canShoot)
        {

        }

        if (Math.Abs(player.position.x - self.position.x) < aggroRange && Math.Abs(player.position.x - self.position.x) > minRange && stuntime == 0)
        {
            if (player.position.x > self.position.x)
            {
                HorizontalMovement = 1f;
            }
            else
            {
                HorizontalMovement = -1f;
            }
        }
        else
        {
            HorizontalMovement = 0;
        }

        animator.SetFloat("Speed",Math.Abs(HorizontalMovement*currentSpeed));
        animator.SetFloat("Vertical",rb.velocity.y);
    }
    void FixedUpdate()
    {
		if (stuntime==0) {
        	controller.Move(HorizontalMovement*currentSpeed,false,jump);
        	jump = false;
		}
    }
    public void takeDamage() {
        rb.velocity = new Vector2(self.position.x-player.position.x,3);
        animator.SetTrigger("Hurt");
		if (stuntime==0) {
			stuntime = 15;
			StartCoroutine(stun());
		} else {
			stuntime = 15;
		}
    }
    IEnumerator stun() {
		if (stuntime>0) {
        	yield return new WaitForSeconds(0.1f);
			stuntime -=1;
			StartCoroutine(stun());
		}
    }
    
    void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(transform.position, aggroRange);
		Gizmos.DrawWireSphere(transform.position, minRange);
    }
}
