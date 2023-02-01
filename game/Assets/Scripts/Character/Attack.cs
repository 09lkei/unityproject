using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackRange =2f;
    [SerializeField] private LayerMask enemyLayers;

    public Projectile ProjectilePrefab;
    public Transform LaunchOffset;

    void Start() {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            attack();
		}


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, new Quaternion(0, 0, 0, transform.localScale.x));

        }
    }




    void attack() {
        animator.SetTrigger("Attack1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies) {
            enemy.GetComponent<Enemy>().takeDamage();
            enemy.GetComponent<Attributes>().TakeDamage(10f);
        }
        
    }

    void OnDrawGizmosSelected() {
        if (attackPoint == null) {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
