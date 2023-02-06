using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private LayerMask enemyLayers;

    public Projectile ProjectilePrefab;
    public Transform LaunchOffset;
    public float AttackDelay = 0.5f;
    public float ShootDelay = 2f;
    public Attributes player;
    public Reload playerReloadScript;
    
    private float Damage = 0;
    public bool canShoot = true;

    void Start() {
        float Damage = player.returnStrength();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && canShoot){
            attack();
            StartCoroutine(delay(AttackDelay));
		}


        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, new Quaternion(0, 0, 0, transform.localScale.x));
            StartCoroutine(delay(ShootDelay));
    
        }

    }



    public IEnumerator delay(float delayTime)
    {
        canShoot = false;
        playerReloadScript.UpdateReload(delayTime);
        yield return new WaitForSeconds(delayTime);
        canShoot = true;
    }


    void attack() {
        animator.SetTrigger("Attack1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies) {
            enemy.GetComponent<Enemy>().takeDamage();
            enemy.GetComponent<Attributes>().TakeDamage(Damage);
        }
        
    }

    void OnDrawGizmosSelected() {
        if (attackPoint == null) {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
