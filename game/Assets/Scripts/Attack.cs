using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange =2f;
    public LayerMask enemyLayers;
    
    void Start() {

    }
    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            attack();
		}
    }
    void attack() {
        animator.SetTrigger("Attack1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies) {
            enemy.GetComponent<Enemy>().takeDamage();
        }
    }
    void OnDrawGizmosSelected() {
        if (attackPoint == null) {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
