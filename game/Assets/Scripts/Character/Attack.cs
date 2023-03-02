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
    [SerializeField] private Attributes attribute;

    public Projectile ProjectilePrefab;
    public Transform LaunchOffset;
    public float punchDelay;
    public float shootDelay;
    public Attributes player;
   // public Reload playerReloadScript;
    
    private float Damage;
    public bool canShoot = true;
    public bool canPunch = true;

    void Start() {
        Damage = player.strength; //TODO just use .strength
    }

    void Update()
    {
        //if (Input.GetButtonDown("Fire2") && canShoot){
        //    punch();
        //    StartCoroutine(delay(AttackDelay));
		//}


        //if (Input.GetButtonDown("Fire1") && canShoot)
        //{
        //    Instantiate(ProjectilePrefab, LaunchOffset.position, new Quaternion(0, 0, 0, transform.localScale.x));
        //    StartCoroutine(delay(ShootDelay));
    
        //}

    }
	public void shoot() {
		Instantiate(ProjectilePrefab, LaunchOffset.position, new Quaternion(0, 0, 0, transform.localScale.x));
		StartCoroutine(ShootDelay());
    }


    public IEnumerator ShootDelay()
    {
        canShoot = false;
        //playerReloadScript.UpdateReload(delayTime);
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }

    public IEnumerator PunchDelay()
    {
        canPunch = false;
        //playerReloadScript.UpdateReload(delayTime);
        yield return new WaitForSeconds(punchDelay);
        canPunch = true;
    }


    public void punch() {
        animator.SetTrigger("Attack1");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies) {
            enemy.GetComponent<Attributes>().TakeDamage(Damage);
            if (enemy.GetComponent<Attributes>().isEnemy)
            {
                enemy.GetComponent<Enemy>().takeDamage();
                
            }
            else if (enemy.GetComponent<Attributes>().isEnemy == false)
            {
                enemy.GetComponent<Movement>().takeDamage();
            }
        }
        StartCoroutine(PunchDelay());

    }
	public void heal()
    {
        attribute.changeHealth(10,0.5f);
    }

    void OnDrawGizmosSelected() {
        if (attackPoint == null) {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
