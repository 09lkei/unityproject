using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public HealthBar healthBar;
    public float armour;
    [SerializeField] public float strength;
    bool alive;
	public bool isEnemy;



    void Start()
    {
        healthBar.UpdateHealthBar();
    }

    public void changeHealth(float change, float duration)
    {
		float perTick = change*0.1f/duration;
		StartCoroutine(healthTick(perTick, duration));
    }
	IEnumerator healthTick(float tick, float remainingTime) {
		if (tick+health<maxHealth) {
			health+=tick;
			healthBar.UpdateHealthBar();
		}
		if (health <= 0)
        {
            alive = false;
            Destroy(gameObject);
        }
		yield return new WaitForSeconds(0.1f);
		if (remainingTime-0.1f>0) {
			StartCoroutine(healthTick(tick, remainingTime-0.1f));
		}
	}
    public void TakeDamage(float amount)
    {
        amount = amount / armour;
        health -= amount;

        if (health <= 0)
        {
            alive = false;
            Destroy(gameObject);
        }

        healthBar.UpdateHealthBar();
    }

}
